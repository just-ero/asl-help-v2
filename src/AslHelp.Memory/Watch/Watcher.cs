using AslHelp.Common.Results;
using AslHelp.Memory.Ipc;

namespace AslHelp.Memory.Watch;

internal sealed class Watcher<T> : WatcherBase<T>
    where T : unmanaged
{
    public Watcher(IProcessMemory memory, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets) { }

    protected override Result<T> Read(nuint address)
    {
        return _memory.Read<T>(address);
    }

    protected override bool Equals(T old, T current)
    {
        return old.Equals(current);
    }

    public override string ToString()
    {
        return $"{nameof(Watcher<T>)}<{typeof(T).Name}>({WatcherPathToString()})";
    }
}
