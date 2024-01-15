using AslHelp.Memory.Ipc;
using AslHelp.Memory.Inspect.Initialization;

namespace AslHelp.LiveSplit;

public partial class AslHelpEntryPoint
{
    public abstract IProcessMemory? Memory { get; }
    public abstract WatcherFactory? Watchers { get; }

    protected abstract void DisposeGameData();
}
