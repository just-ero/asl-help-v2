using AslHelp.Common.Results;
using AslHelp.Memory.Ipc;

namespace AslHelp.Memory.Inspect;

internal sealed class SpanWatcher<T> : WatcherBase<T[]>
    where T : unmanaged
{
    private readonly int _length;

    public unsafe SpanWatcher(IProcessMemory memory, int length, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets)
    {
        _length = length;
    }

    protected override Result<T[]> Read(nuint address)
    {
        return _memory.ReadSpan<T>(_length, address);
    }

    protected override bool Equals(T[]? old, T[]? current)
    {
        if (old is null || current is null)
        {
            return false;
        }

        for (int i = 0; i < _length; i++)
        {
            if (!old[i].Equals(current[i]))
            {
                return false;
            }
        }

        return true;
    }

    public override string ToString()
    {
        return $"{nameof(SpanWatcher<T>)}<{typeof(T).Name}>({WatcherPathToString()})";
    }
}
