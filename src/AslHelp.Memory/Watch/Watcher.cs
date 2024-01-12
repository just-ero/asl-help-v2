using AslHelp.Memory.Ipc;

namespace AslHelp.Memory.Watch;

internal sealed class Watcher<T> : WatcherBase<T>
    where T : unmanaged
{
    public Watcher(IProcessMemory memory, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets) { }

    protected override bool TryRead(nuint address, out T value)
    {
        return _memory.TryRead(out value, address);
    }

    protected override bool Equals(T old, T current)
    {
        return old.Equals(current);
    }
}
