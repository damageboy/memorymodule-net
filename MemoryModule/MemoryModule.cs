using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MemoryModule
{
  public class MemoryModule
  {
    private unsafe byte* codeBase;
    private int numModules;
    private bool initialized;
    private object modules;
    private object userData;
    private unsafe IMAGE_NT_HEADERS* headers;
    public static unsafe MemoryModule Load(byte* data, object userData)
    {
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
      MemoryModule result;
      try
      {
        result = new MemoryModule();
      }
      catch
      {
        Win32.VirtualFree(code, 0, Win32.MEM_RELEASE);
        throw;
      }
      try
      {
        result.codeBase = code;
        result.numModules = 0;
        result.modules = null;
        result.initialized = false;
        result.userData = userData;

        // commit memory for headers
        var headers = (byte*)Win32.VirtualAlloc(code,
          old_header->OptionalHeader.SizeOfHeaders,
          Win32.MEM_COMMIT, Win32.PAGE_READWRITE);

        // copy PE header to code
        Mem.Cpy((byte*)dos_header, (byte*)headers,
          (int)(dos_header->e_lfanew + old_header->OptionalHeader.SizeOfHeaders));
        result.headers = (IMAGE_NT_HEADERS*)&(headers[dos_header->e_lfanew]);

        // update position
        result.headers->OptionalHeader.ImageBase = new IntPtr(code);

        // copy sections from DLL file block to new memory location
        CopySections(data, old_header, result);

        // adjust base address of imported data
        var locationDelta = (IntPtr)(code - (byte*)old_header->OptionalHeader.ImageBase.ToPointer());
        if (locationDelta != IntPtr.Zero)
        {
          PerformBaseRelocation(result, locationDelta);
        }

        // load required dlls and adjust function table of imports
        if (!BuildImportTable(result))
        {
          throw new Exception("Failed to build import table");
        }

        // mark memory pages depending on section headers and release
        // sections that are marked as "discardable"
        FinalizeSections(result);

        // get entry point of loaded library
        if (result.headers->OptionalHeader.AddressOfEntryPoint != 0)
        {
          var dllEntry = (DllEntryDelegate)
            Marshal.GetDelegateForFunctionPointer(
            new IntPtr(code + result.headers->OptionalHeader.AddressOfEntryPoint),
            typeof(DllEntryDelegate));
          // notify library about attaching to process
          var successfull = dllEntry(code, NativeConstants.DLL_PROCESS_ATTACH, null);
          if (!successfull)
          {
            throw new Exception("Dll initialization faild");
          }
          result.initialized = true;
        }

        return result;
      }
      catch
      {
        Free(result);
        throw;
      }
      return null;
    }

    private static void Free(MemoryModule result)
    {
      throw new NotImplementedException();
    }
    private unsafe delegate bool DllEntryDelegate(byte* hInstance, uint reason, void* reserved);

    private static void PerformBaseRelocation(MemoryModule result, IntPtr locationDelta)
    {
      throw new NotImplementedException();
    }

    private static void FinalizeSections(MemoryModule result)
    {
      throw new NotImplementedException();
    }

    private static bool BuildImportTable(MemoryModule result)
    {
      throw new NotImplementedException();
    }

    private static unsafe void CopySections(byte* data, IMAGE_NT_HEADERS* old_headers, MemoryModule module)
    {
      int i;
      uint size;
      byte *codeBase = module.codeBase;
      byte *dest;
      var section = GetFirstSection(module.headers);
      for (i=0; i< module.headers->FileHeader.NumberOfSections; i++, section++) {
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
