using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory.Inspect;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Memory.Inspect;

internal sealed class MonoListWatcher<T> : WatcherBase<List<T>>
    where T : unmanaged
{
    private new readonly IMonoProcessMemory _memory;

    public MonoListWatcher(IMonoProcessMemory memory, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets)
    {
        _memory = memory;
    }

    protected override bool TryRead(nuint address, [NotNullWhen(true)] out List<T>? value)
    {
        return _memory.TryReadList(out value, address);
    }

    protected override bool Equals(List<T>? old, List<T>? current)
    {
        if (old is null || current is null)
        {
            return false;
        }

        if (old.Count != current.Count)
        {
            return false;
        }

        for (int i = 0; i < old.Count; i++)
        {
            if (!old[i].Equals(current[i]))
            {
                return false;
            }
        }

        return true;
    }
}
