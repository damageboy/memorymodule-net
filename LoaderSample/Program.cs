using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using MemoryModule;

namespace LoaderSample
{
  class Program
  {
    static unsafe void Main(string[] args)
    {
      var dllBytes = File.ReadAllBytes(@"..\..\..\bin\Debug-x64\SampleDLL.dll");
      var gch = GCHandle.Alloc(dllBytes, GCHandleType.Pinned);
      var dp = (byte *) gch.AddrOfPinnedObject().ToPointer();

      var mm = MemoryModule.MemoryModule.Load(dp, null);
    }
  }
}
