using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Unity.Memory.Ipc;
using AslHelp.Unity.Runtime.Interop;
using AslHelp.Unity.Runtime.Interop.Initialization;

public partial class Unity
{
    private MonoOperator? _mono;
    public Result<MonoOperator> InitializeMono()
    {
        if (_mono is not null)
        {
            return _mono;
        }

        EnsureInitialized();
        EnsureMemoryInitialized();

        // CS8600: Converting possible null value to non-nullable type
        // `EnsureHasMemory` already asserted that this isn't the case.
        IMonoProcessMemory memory = (IMonoProcessMemory)Memory!;

        if (memory.Modules.TryGetValue("mono.dll", out Module? monoModule))
        {
            return InitializeMono<MonoInitializerV1>(memory, monoModule);
        }

        if (memory.Modules.TryGetValue("mono-2.0-bdwgc.dll", out monoModule))
        {
            return InitializeMonoV2(memory, monoModule);
        }

        if (memory.Modules.TryGetValue("GameAssembly.dll", out monoModule))
        {
            return InitializeIl2Cpp(memory, monoModule);
        }

        return default!;
    }

    public Result<MonoOperator> InitializeMonoV1(
        string monoModuleName)
    {
        if (_mono is not null)
        {
            return _mono;
        }

        EnsureInitialized();
        EnsureMemoryInitialized();

        // CS8600: Converting possible null value to non-nullable type
        // `EnsureHasMemory` already asserted that this isn't the case.
        IMonoProcessMemory memory = (IMonoProcessMemory)Memory!;

        if (memory.Modules.TryGetValue(monoModuleName, out Module? monoModule))
        {
            return InitializeMonoV1(memory, monoModule);
        }

        return default!;
    }

    public Result<MonoOperator> InitializeMonoV2(
        string monoModuleName)
    {
        if (_mono is not null)
        {
            return _mono;
        }

        EnsureInitialized();
        EnsureMemoryInitialized();

        // CS8600: Converting possible null value to non-nullable type
        // `EnsureHasMemory` already asserted that this isn't the case.
        IMonoProcessMemory memory = (IMonoProcessMemory)Memory!;

        if (memory.Modules.TryGetValue(monoModuleName, out Module? monoModule))
        {
            return InitializeMonoV2(memory, monoModule);
        }

        return default!;
    }

    private Result<MonoOperator> InitializeMono<TInitializer>(
        IMonoProcessMemory memory,
        Module monoModule)
        where TInitializer : MonoInitializer, new()
    {
        return new TInitializer().Initialize(memory, monoModule);
    }
}
