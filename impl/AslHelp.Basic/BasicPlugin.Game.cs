using System.Diagnostics;

using AslHelp.LiveSplit.Diagnostics;
using AslHelp.Memory.Ipc;
using AslHelp.Memory.Watch.Initialization;

public partial class BasicPlugin
{
    private IProcessMemory? _memory;
    private IWatcherFactory? _watchers;

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

    public override IWatcherFactory? Watchers
    {
        get
        {
            if (_watchers is null)
            {
                if (Memory is IProcessMemory memory)
                {
                    _watchers = new WatcherFactory(memory);
                }
            }

            return _watchers;
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
        _watchers = null;
    }
}
