using AslHelp.Memory.Inspect;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Memory.Inspect;

internal abstract class MonoWatcherBase<T> : WatcherBase<T>
{
    protected new readonly IMonoProcessMemory _memory;

    protected MonoWatcherBase(IMonoProcessMemory memory, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets)
    {
        _memory = memory;
    }
}
