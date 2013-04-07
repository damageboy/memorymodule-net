using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MemoryModule
{
  public class EmbeddedResourceResolver : IModuleResolver
  {
    private bool _archAsPrefix;
    private string _ns;
    private Assembly _asm;
    private Dictionary<string, string> _rsc;
    private Dictionary<ulong, GCHandle> _loadedResources;
    public EmbeddedResourceResolver(Assembly asm, string ns, bool archAsPrefix = true)
    {
      _asm = asm;      
      _ns = ns;

      _rsc = _asm.GetManifestResourceNames().Where(n => n.StartsWith(_ns)).Select(n => n.Remove(0, _ns.Length)).ToDictionary(x => x, x => x);
      _loadedResources = new Dictionary<ulong,GCHandle>();

      _archAsPrefix = archAsPrefix;

    }
    public unsafe void* Load(string moduleName, string loaderModule, ArchType arch)
    {
      var candidate = _archAsPrefix ? arch + "." + moduleName + ".dll" : moduleName + "." + arch + ".dll";
      if (!_rsc.ContainsKey(candidate))
        return null;

      var dllStream = _asm.GetManifestResourceStream(candidate);
      var memory = new byte[dllStream.Length];
      dllStream.Read(memory, 0, (int) dllStream.Length);
      var gch = GCHandle.Alloc(memory, GCHandleType.Pinned);
      _loadedResources[(ulong) gch.AddrOfPinnedObject().ToPointer()] = gch;
      return (void *) gch.AddrOfPinnedObject().ToPointer();
    }

    public unsafe void Free(void* module)
    {
      if (!_loadedResources.ContainsKey((ulong)module))
        throw new ArgumentException("No module with specified address was loaded by the EmbeddedResourceResolver");

      _loadedResources[(ulong)module].Free();
      _loadedResources.Remove((ulong)module);

    }
  }
}
