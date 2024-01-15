using System.Diagnostics;

using AslHelp.Memory.Ipc;
using AslHelp.Memory.Inspect.Initialization;

public partial class Basic
{
    private IProcessMemory? _memory;
    public override IProcessMemory? Memory
    {
        get
        {
            EnsureInitialized();

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

    private WatcherFactory? _watchers;
    public override WatcherFactory? Watchers
    {
        get
        {
            EnsureInitialized();

            if (_watchers is null)
            {
                if (Memory is IProcessMemory memory)
                {
                    _watchers = new(memory);
                }
            }

            return _watchers;
        }
    }

    protected virtual IProcessMemory InitializeMemory(Process process)
    {
        return new ProcessMemory(process);
    }

    protected override void DisposeGameData()
    {
        _memory?.Dispose();

        _game = null;
        _memory = default;
        _watchers = default;
    }
}
