using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MemoryModule
{
  public class Win32
  {
    public const uint MEM_WRITE_WATCH = 0x200000;
    public const uint MEM_LARGE_PAGES = 0x20000000;
    public const uint MEM_4MB_PAGES = 0x80000000;
    public const uint MEM_TOP_DOWN = 0x100000;
    public const uint MEM_PHYSICAL = 0x400000;
    public const uint MEM_DECOMMIT = 0x4000;
    public const uint MEM_RESERVE = 0x2000;
    public const uint MEM_RELEASE = 0x8000;
    public const uint MEM_PRIVATE = 0x20000;
    public const uint MEM_MAPPED = 0x40000;
    public const uint MEM_COMMIT = 0x1000;
    public const uint MEM_RESET = 0x80000;
    public const uint MEM_IMAGE = SEC_IMAGE;
    public const uint MEM_FREE = 0x10000;
    public const uint SEC_IMAGE = 0x1000000;

    
    public const uint PAGE_EXECUTE_WRITECOPY = 0x80;
    public const uint PAGE_EXECUTE_READWRITE = 0x40;
    public const uint PAGE_WRITECOMBINE = 0x400;
    public const uint PAGE_EXECUTE_READ = 0x20;
    public const uint PAGE_WRITECOPY = 0x8;
    public const uint PAGE_READWRITE = 0x4;
    public const uint PAGE_READONLY = 0x2;
    public const uint PAGE_NOACCESS = 0x1;
    public const uint PAGE_NOCACHE = 0x200;
    public const uint PAGE_EXECUTE = 0x10;
    public const uint PAGE_GUARD = 0x100;


    /// Return Type: LPVOID->void*
    ///lpAddress: LPVOID->void*
    ///dwSize: SIZE_T->ULONG_PTR->unsigned int
    ///flAllocationType: DWORD->unsigned int
    ///flProtect: DWORD->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "VirtualAlloc")]
    public unsafe static extern void *VirtualAlloc(
      void *lpAddress, uint dwSize, uint flAllocationType, uint flProtect);


    /// Return Type: LPVOID->void*
    ///hProcess: HANDLE->void*
    ///lpAddress: LPVOID->void*
    ///dwSize: SIZE_T->ULONG_PTR->unsigned int
    ///flAllocationType: DWORD->unsigned int
    ///flProtect: DWORD->unsigned int
    [DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx")]
    public unsafe static extern void *VirtualAllocEx(
      IntPtr hProcess, 
      void *lpAddress, 
      uint dwSize, uint flAllocationType, uint flProtect);

    /// Return Type: BOOL->int
    ///hProcess: HANDLE->void*
    ///lpAddress: LPVOID->void*
    ///dwSize: SIZE_T->ULONG_PTR->unsigned int
    ///dwFreeType: DWORD->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "VirtualFreeEx")]
    public unsafe static extern bool VirtualFreeEx(
      System.IntPtr hProcess, 
      void *lpAddress, uint dwSize, uint dwFreeType);


    /// Return Type: BOOL->int
    ///lpAddress: LPVOID->void*
    ///dwSize: SIZE_T->ULONG_PTR->unsigned int
    ///dwFreeType: DWORD->unsigned int
    [System.Runtime.InteropServices.DllImportAttribute("kernel32.dll", EntryPoint = "VirtualFree")]
    public unsafe static extern bool VirtualFree(
      void *lpAddress, uint dwSize, uint dwFreeType);


  }
}
