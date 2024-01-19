using System.Diagnostics;
using System.Linq;

using AslHelp.LiveSplit.Diagnostics;
using AslHelp.Memory;
using AslHelp.Memory.Ipc;
using AslHelp.Unity.Memory.Ipc;
using AslHelp.Unity.Runtime.Interop;

public partial class Unity
{
    private MonoOperator? _mono;
    public MonoOperator LoadMono(
        string? monoModuleName = default,
        string? dataDirectory = default)
    {
        EnsureInitialized();
        EnsureHasMemory();

        // Somehow there's a nullability warning here if we don't suppress.
        // `EnsureHasMemory` already asserted that this isn't the case.
        IMonoProcessMemory memory = (IMonoProcessMemory)Memory!;

        if (_mono is not null)
        {
            return _mono;
        }

        Module monoModule = monoModuleName is not null
            ? memory.Modules[monoModuleName]
            : memory.Modules.First(m => m.Name.ToLowerInvariant() is "mono.dll" or "mono-2.0-bdwgc.dll" or "gameassembly.dll");

        return default!;
    }

    public MonoOperator? Mono
    {
        get
        {
            if (_mono is not null)
            {
                return _mono;
            }

            if (Memory is not IMonoProcessMemory memory)
            {
                return default;
            }

            AslDebug.Info("Initializing Mono...");

            _mono = memory.RuntimeVersion >= MonoRuntimeVersion.Il2CppV24
                ? Il2CppOperator.Create(memory).Unwrap()
                : MonoOperator.Create(memory).Unwrap();

            return _mono;
        }
    }

    protected override IProcessMemory InitializeMemory(Process process)
    {
        return new MonoProcessMemory(process);
    }
}
