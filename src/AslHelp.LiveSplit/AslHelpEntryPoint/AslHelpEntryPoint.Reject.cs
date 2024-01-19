using System.Linq;

using AslHelp.Memory;

namespace AslHelp.LiveSplit;

public partial class AslHelpEntryPoint
{
    public bool Reject(params uint[] moduleMemorySizes)
    {
        EnsureMemoryInitialized();

        return Reject(Memory.MainModule, moduleMemorySizes);
    }

    public bool Reject(string moduleName, params uint[] moduleMemorySizes)
    {
        EnsureMemoryInitialized();

        return Reject(Memory.Modules[moduleName], moduleMemorySizes);
    }

    public bool Reject(Module module, params uint[] moduleMemorySizes)
    {
        EnsureMemoryInitialized();

        if (moduleMemorySizes.Length == 0)
        {
            Game = null;
            return true;
        }

        uint memorySize = module.MemorySize;
        if (moduleMemorySizes.Any(mms => mms == memorySize))
        {
            Game = null;
            return true;
        }

        return false;
    }
}
