using System.Diagnostics;

using AslHelp.Memory.Ipc;
using AslHelp.Unity.Memory.Ipc;

public partial class Unity
{
    protected override IProcessMemory InitializeMemory(Process process)
    {
        return new MonoProcessMemory(process);
    }

    protected override void DisposeGameData()
    {
        base.DisposeGameData();

        _mono = null;
    }
}
