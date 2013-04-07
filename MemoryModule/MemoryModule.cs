using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MemoryModule
{
  public interface IModuleLoader
  {
    void Load(string moduleName);
    unsafe void* GetSymbolAddress(string symbol);
    void Free();
  }

  public class MemoryModule : IModuleLoader
  {
    #region Global Loader/Resoolver State
    public static IList<IModuleResolver> DefaultResolverChain { get; set; }
    public static IList<MemoryModule> AllLoadedModules;
    #endregion
      
    public static IList<IModuleResolver> Resolvers { get; private set; }
    public IList<MemoryModule> Modules { public get; set; }


    object userData;
    unsafe IMAGE_NT_HEADERS* headers;

    private unsafe byte* codeBase;
    bool initialized;
    IModuleResolver _resolver;
    unsafe void* _resolvedCode;



    public MemoryModule()
    {
      Resolvers = DefaultResolverChain;
    }


    public MemoryModule(IModuleResolver resolver)
    {
      Resolvers = new List<IModuleResolver> { resolver };
    }

    public MemoryModule(IEnumerable<IModuleResolver> resolvers)
    {
      Resolvers = resolvers.ToList();
    }

    public unsafe void Load(string moduleName, string loaderName = null)
    {
      if (Resolve(moduleName))
        Load(_resolvedCode);
      else
        throw new Exception("Failed to resolve " + moduleName);
    }

    public unsafe bool TryLoad(string moduleName, string loaderName = null)
    {
      if (Resolve(moduleName))
        return TryLoad(_resolvedCode);
      else
        return false;
    }


    private unsafe bool Resolve(string moduleName, string loaderName = null)
    {      
      if (Resolvers == null || !Resolvers.Any())
        return false;
      foreach (var r in Resolvers)
      {
        var code = r.Load(moduleName, loaderName, GetCurrentArch());
        if (code != null) {
          _resolver = r;
          _resolvedCode = code;
          return true;
        }
      }
      return false;
    }

    public unsafe MemoryModule Load(void* p)
    {
      byte* data = (byte*) p;
      var dos_header = (IMAGE_DOS_HEADER*)data;
      if (dos_header->e_magic != NativeConstants.IMAGE_DOS_SIGNATURE)
        throw new BadImageFormatException("Invalid DOS magic");

      var old_header = (IMAGE_NT_HEADERS*)&(data[dos_header->e_lfanew]);
      if (old_header->Signature != NativeConstants.IMAGE_NT_SIGNATURE)
        throw new BadImageFormatException("Invalid NT magic");

      // reserve memory for image of library
      // XXX: is it correct to commit the complete memory region at once?
      //      calling DllEntry raises an exception if we don't...
      var code = (byte*)Win32.VirtualAlloc((byte*)(old_header->OptionalHeader.ImageBase),
        old_header->OptionalHeader.SizeOfImage,
        Win32.MEM_RESERVE | Win32.MEM_COMMIT,
        Win32.PAGE_READWRITE);

      if (code == null)
      {
        // try to allocate memory at arbitrary position
        code = (byte*)Win32.VirtualAlloc(null, old_header->OptionalHeader.SizeOfImage,
            Win32.MEM_RESERVE | Win32.MEM_COMMIT,
            Win32.PAGE_READWRITE);
        if (code == null)
          throw new OutOfMemoryException("trying to virtual-alloc");
      }
      MemoryModule module;
      try {
        module = new MemoryModule();
      }
      catch {
        Win32.VirtualFree(code, 0, Win32.MEM_RELEASE);
        throw;
      }
      try
      {
        module.codeBase = code;
        module.Modules = new List<MemoryModule>();
        module.initialized = false;
        module.userData = userData;

        module.CopyHeaders(dos_header, old_header, code);

        // copy sections from DLL file block to new memory location
        module.CopySections(data, old_header);

        // adjust base address of imported data
        var locationDelta = (IntPtr)(code - (byte*)old_header->OptionalHeader.ImageBase.ToPointer());
        if (locationDelta != IntPtr.Zero)
          module.PerformBaseRelocation(locationDelta);

        // load required dlls and adjust function table of imports
        if (!module.BuildImportTable())
          throw new Exception("Failed to build import table");

        // mark memory pages depending on section headers and release
        // sections that are marked as "discardable"
        FinalizeSections(module);

        // get entry point of loaded library
        if (module.headers->OptionalHeader.AddressOfEntryPoint != 0)
        {
          var dllEntry = (DllEntryDelegate)
            Marshal.GetDelegateForFunctionPointer(
            new IntPtr(code + module.headers->OptionalHeader.AddressOfEntryPoint),
            typeof(DllEntryDelegate));
          // notify library about attaching to process
          var successfull = dllEntry(code, NativeConstants.DLL_PROCESS_ATTACH, null);
          if (!successfull)
          {
            throw new Exception("Dll initialization faild");
          }
          module.initialized = true;
        }

        return module;
      }
      catch
      {
        Free(module);
        throw;
      }
    }

    unsafe private void CopyHeaders(IMAGE_DOS_HEADER* dos_header, IMAGE_NT_HEADERS* old_header, byte* code)
    {

      // commit memory for headers
      var headers = (byte*)Win32.VirtualAlloc(code,
        old_header->OptionalHeader.SizeOfHeaders,
        Win32.MEM_COMMIT, Win32.PAGE_READWRITE);

      // copy PE header to code
      Mem.Cpy((byte*)dos_header, (byte*)headers,
        (int)(dos_header->e_lfanew + old_header->OptionalHeader.SizeOfHeaders));
      this.headers = (IMAGE_NT_HEADERS*)&(headers[dos_header->e_lfanew]);

      // update position
      this.headers->OptionalHeader.ImageBase = new IntPtr(code);
    }

    private static void Free(MemoryModule result)
    {
      throw new NotImplementedException();
    }
    private unsafe delegate bool DllEntryDelegate(byte* hInstance, uint reason, void* reserved);

    private unsafe IMAGE_DATA_DIRECTORY* GetHeaderDictionary(int idx)
    {
      return &headers->OptionalHeader.DataDirectory[idx];
    }
    private unsafe void PerformBaseRelocation(IntPtr delta)
    {
      IMAGE_DATA_DIRECTORY *directory = GetHeaderDictionary(NativeConstants.IMAGE_DIRECTORY_ENTRY_BASERELOC);
      if (directory->Size > 0) {
        IMAGE_BASE_RELOCATION *relocation = (IMAGE_BASE_RELOCATION *) (codeBase + directory->VirtualAddress);
        for (; relocation->VirtualAddress > 0; ) {
            byte *dest = codeBase + relocation->VirtualAddress;
            var relInfo = (ushort*)((byte*)relocation + NativeConstants.IMAGE_SIZEOF_BASE_RELOCATION);
            for (var i = 0; i < ((relocation->SizeOfBlock - NativeConstants.IMAGE_SIZEOF_BASE_RELOCATION) / 2); i++, relInfo++)
            {
                int *patchAddrHL;
                long *patchAddr64;
                int type, offset;

                // the upper 4 bits define the type of relocation
                type = *relInfo >> 12;
                // the lower 12 bits define the offset
                offset = *relInfo & 0xfff;
                
                switch (type)
                {
                  case NativeConstants.IMAGE_REL_BASED_ABSOLUTE:
                    // skip relocation
                    break;

                  case NativeConstants.IMAGE_REL_BASED_HIGHLOW:
                    // change complete 32 bit address
                    patchAddrHL = (int *) (dest + offset);
                    *patchAddrHL += (int) delta;
                    break;
                
                case NativeConstants.IMAGE_REL_BASED_DIR64:
                    patchAddr64 = (long *) (dest + offset);
                    *patchAddr64 += (long) delta;
                    break;

                  default:
                    //printf("Unknown relocation: %d\n", type);
                    break;
                }
            }

            // advance to next relocation block
            relocation = (IMAGE_BASE_RELOCATION *) (((char *) relocation) + relocation->SizeOfBlock);
        }
      }
    }

    private static void FinalizeSections(MemoryModule result)
    {
      throw new NotImplementedException();
    }

    private unsafe MemoryModule LoadDependancy(string name, string loaderName, object userData)
    {
      // First let's try the internal loader + resolver chain
      var dep = new MemoryModule(Resolvers);
      if (dep.TryLoad(name, loaderName);

        return new SystemModuleLoader(Win32.LoadLibrary(name));
      
      throw new Exception("Failed to load the " + name + " module");
        
    }

    private ArchType GetCurrentArch()
    {
      if (IntPtr.Size == 4)
        return ArchType.x86;
      else
        return ArchType.x64;
    }

    private unsafe bool BuildImportTable()
    {
    bool result=true;
    //HCUSTOMMODULE *tmp;

    IMAGE_DATA_DIRECTORY *directory = GetHeaderDictionary(NativeConstants.IMAGE_DIRECTORY_ENTRY_IMPORT);
    if (directory->Size > 0) {
        IMAGE_IMPORT_DESCRIPTOR *importDesc = (IMAGE_IMPORT_DESCRIPTOR *) (codeBase + directory->VirtualAddress);
        for (; /*!IsBadReadPtr(importDesc, sizeof(IMAGE_IMPORT_DESCRIPTOR)) && */ importDesc->Name != 0; importDesc++) {
            byte *thunkRef;
            byte *funcRef;
            var namePtr = (sbyte *) (codeBase + importDesc->Name);

            var handle = LoadDependancy(new string(namePtr, 0, String.Length(namePtr)), this.Name, userdata);

            tmp = (HCUSTOMMODULE *) realloc(modules, (module->numModules+1)*(sizeof(HCUSTOMMODULE)));
            if (tmp == NULL) {
                module->freeLibrary(handle, module->userdata);
                SetLastError(ERROR_OUTOFMEMORY);
                result = 0;
                break;
            }
            modules = tmp;

            modules[numModules++] = handle;
            if (importDesc->OriginalFirstThunk) {
                thunkRef = (byte *) (codeBase + importDesc->OriginalFirstThunk);
                funcRef = (byte *) (codeBase + importDesc->FirstThunk);
            } else {
                // no hint table
                thunkRef = (byte *) (codeBase + importDesc->FirstThunk);
                funcRef = (byte *) (codeBase + importDesc->FirstThunk);
            }
            for (; *thunkRef; thunkRef++, funcRef++) {
              if (IMAGE_SNAP_BY_ORDINAL(*thunkRef)) {
                *funcRef = getProcAddress(handle, (LPCSTR)IMAGE_ORDINAL(*thunkRef), userdata);
              }
              else {
                PIMAGE_IMPORT_BY_NAME thunkData = (PIMAGE_IMPORT_BY_NAME)(codeBase + (*thunkRef));
                *funcRef = getProcAddress(handle, (LPCSTR) & thunkData->Name, userdata);
              }
              if (*funcRef == 0) {
                result = 0;
                break;
              }
            }

            if (!result) {
                module->freeLibrary(handle, module->userdata);
                SetLastError(ERROR_PROC_NOT_FOUND);
                break;
            }
        }
    }

    return result;
    }

    private unsafe void CopySections(byte* data, IMAGE_NT_HEADERS* old_headers)
    {
      int i;
      uint size;
      byte *dest;
      var section = GetFirstSection(headers);
      for (i=0; i< headers->FileHeader.NumberOfSections; i++, section++) {
        if (section->SizeOfRawData == 0) {
            // section doesn't contain data in the dll itself, but may define
            // uninitialized data
            size = old_headers->OptionalHeader.SectionAlignment;
            if (size > 0) {
                dest = (byte *)Win32.VirtualAlloc(codeBase + section->VirtualAddress,
                    size,
                    Win32.MEM_COMMIT,
                    Win32.PAGE_READWRITE);

                section->Misc.PhysicalAddress = (uint) dest;
                //Mem.Set(dest, 0, size);
            }

            // section is empty
            continue;
        }

        // commit memory block and copy data from dll
        dest = (byte *)Win32.VirtualAlloc(codeBase + section->VirtualAddress,
                            section->SizeOfRawData,
                            Win32.MEM_COMMIT,
                            Win32.PAGE_READWRITE);
        Mem.Cpy(data + section->PointerToRawData, dest, (int) section->SizeOfRawData);
        section->Misc.PhysicalAddress = (uint) dest;
    }
    }

    private static unsafe IMAGE_SECTION_HEADER *GetFirstSection(IMAGE_NT_HEADERS* ntheader)
    {
      var p = (byte *)ntheader;
      return (IMAGE_SECTION_HEADER *)
        (p + Marshal.OffsetOf(typeof(IMAGE_NT_HEADERS), "OptionalHeader").ToInt32() + ntheader->FileHeader.SizeOfOptionalHeader);
    }


  }
}
