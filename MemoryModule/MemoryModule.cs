using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryModule
{
  public class MemoryModule
  {
    public static unsafe MemoryModule Load(byte* data, object userData)
    {
      var dos_header = (IMAGE_DOS_HEADER*)data;
      if (dos_header->e_magic != NativeConstants.IMAGE_DOS_SIGNATURE)
        throw new BadImageFormatException("Invalid DOS magic");

      var old_header = (IMAGE_NT_HEADERS64*)&(data[dos_header->e_lfanew]);
      if (old_header->Signature != NativeConstants.IMAGE_NT_SIGNATURE)
        throw new BadImageFormatException("Invalid NT magic");

      // reserve memory for image of library
      // XXX: is it correct to commit the complete memory region at once?
      //      calling DllEntry raises an exception if we don't...
      var code = (byte*)Win32.VirtualAlloc((byte *)(old_header->OptionalHeader.ImageBase),
        old_header->OptionalHeader.SizeOfImage,
        Win32.MEM_RESERVE | Win32.MEM_COMMIT,
        Win32.PAGE_READWRITE);

      if (code == null) {
        // try to allocate memory at arbitrary position
        code = (byte*)Win32.VirtualAlloc(null, old_header->OptionalHeader.SizeOfImage,
            Win32.MEM_RESERVE | Win32.MEM_COMMIT,
            Win32.PAGE_READWRITE);
        if (code == null)
          throw new OutOfMemoryException("trying to virtual-alloc");
      }


      return null;
    }


  }
}
