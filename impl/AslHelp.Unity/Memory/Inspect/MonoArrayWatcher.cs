using AslHelp.Common.Results;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Memory.Inspect;

internal sealed class MonoArrayWatcher<T> : MonoWatcherBase<T[]>
    where T : unmanaged
{
    public MonoArrayWatcher(IMonoProcessMemory memory, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets) { }

    protected override Result<T[]> Read(nuint address)
    {
        return _memory.ReadArray<T>(address);
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

    public override string ToString()
    {
        return $"{nameof(MonoArrayWatcher<T>)}<{typeof(T).Name}>({WatcherPathToString()})";
    }
}
