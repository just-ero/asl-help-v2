using System.Diagnostics;

using AslHelp.Memory.Ipc;
using AslHelp.Unity.Memory.Ipc;
using AslHelp.Unity.Runtime.Interop;

public partial class Unity
{
    private MonoOperator? _mono;
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

            Debug.Info("Initializing Mono...");

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
