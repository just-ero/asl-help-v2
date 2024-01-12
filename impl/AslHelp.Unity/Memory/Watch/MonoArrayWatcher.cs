using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory.Watch;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Memory.Watch;

internal sealed class MonoArrayWatcher<T> : WatcherBase<T[]>
    where T : unmanaged
{
    private new readonly IMonoProcessMemory _memory;

    public MonoArrayWatcher(IMonoProcessMemory memory, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets)
    {
        _memory = memory;
    }

    protected override bool TryRead(nuint address, [NotNullWhen(true)] out T[]? value)
    {
        return _memory.TryReadArray(out value, address);
    }

    protected override bool Equals(T[]? old, T[]? current)
    {
        if (old is null || current is null)
        {
            return false;
        }

        if (old.Length != current.Length)
        {
            return false;
        }

        for (int i = 0; i < old.Length; i++)
        {
            if (!old[i].Equals(current[i]))
            {
                return false;
            }
        }

        return true;
    }
}
