using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common.Results;
using AslHelp.Memory.Inspect;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Memory.Inspect;

internal sealed class MonoListWatcher<T> : MonoWatcherBase<List<T>>
    where T : unmanaged
{
    public MonoListWatcher(IMonoProcessMemory memory, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets) { }

    protected override Result<List<T>> Read(nuint address)
    {
        return _memory.ReadList<T>(address);
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

    public override string ToString()
    {
        return $"{nameof(MonoListWatcher<T>)}<{typeof(T).Name}>({WatcherPathToString()})";
    }
}
