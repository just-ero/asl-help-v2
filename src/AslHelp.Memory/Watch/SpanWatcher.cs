using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory.Ipc;

namespace AslHelp.Memory.Watch;

internal sealed class SpanWatcher<T> : WatcherBase<T[]>
    where T : unmanaged
{
    private readonly int _length;

    public unsafe SpanWatcher(IProcessMemory memory, int length, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets)
    {
        _length = length;
    }

    protected override unsafe bool TryRead(nuint address, [NotNullWhen(true)] out T[]? value)
    {
        // We need to allocate a new array here every single time.
        // Otherwise, we would be changing the contents of `_old` as well.
        // This would cause the `Equals` method to always return true.

        value = new T[_length];
        return _memory.TryReadSpan<T>(value, address);
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
}
