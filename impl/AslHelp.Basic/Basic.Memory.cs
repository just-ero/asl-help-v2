using System.Diagnostics;

using AslHelp.Memory.Ipc;
using AslHelp.Memory.Watch.Initialization;

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
                    Debug.Info("Initializing memory...");

                    using (Debug.Indent())
                    {
                        _memory = InitializeMemory(game);

                        Debug.Info("Success.");
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

    protected override void DisposeProcessInstanceData()
    {
        _memory?.Dispose();

        _game = null;
        _memory = default;
        _watchers = default;
    }
}
