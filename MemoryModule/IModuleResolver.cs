namespace MemoryModule
{

  public enum ArchType
  {
    x86,
    x64,
    ARM,
  }

  public interface IModuleResolver
  {
    unsafe void *Load(string moduleName, string loaderModule, ArchType arch );
    unsafe void Free(void *module);
  }
}