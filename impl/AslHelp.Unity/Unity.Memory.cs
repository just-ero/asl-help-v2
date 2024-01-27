using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

using AslHelp.Common;
using AslHelp.Memory.Ipc;
using AslHelp.Unity.Memory.Ipc;

public partial class Unity
{
    public new IMonoProcessMemory? Memory => (IMonoProcessMemory?)base.Memory;

    protected override IProcessMemory InitializeMemory(Process process)
    {
        return new MonoProcessMemory(process);
    }

    protected override void DisposeGameData()
    {
        base.DisposeGameData();

        _mono = null;
    }

    [MemberNotNull(nameof(Memory))]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private void EnsureMemoryInitialized()
    {
        if (Memory is null)
        {
            const string Msg = "Attempted to access uninitialized memory.";
            ThrowHelper.ThrowInvalidOperationException(Msg);
        }
    }
}
