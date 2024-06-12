using System.Diagnostics;

using AslHelp.LiveSplit.Diagnostics;
using AslHelp.Memory.Ipc;

public partial class BasicPlugin
{
    private IProcessMemory? _memory;

    public override IProcessMemory? Memory
    {
        get
        {
            if (_memory is null)
            {
                if (Game is Process game)
                {
                    AslDebug.Info("Initializing memory...");
                    using (AslDebug.Indent())
                    {
                        _memory = InitializeMemory(game);

                        AslDebug.Info("Success.");
                    }
                }
            }

            return _memory;
        }
    }

    protected virtual IProcessMemory InitializeMemory(Process process)
    {
        return new ProcessMemory(process);
    }

    protected override void DisposeGameAndMemory()
    {
        Game?.Dispose();
        _memory?.Dispose();

        Game = null;
        _memory = null;
    }
}
