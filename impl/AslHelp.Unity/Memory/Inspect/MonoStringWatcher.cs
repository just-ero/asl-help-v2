using System.Diagnostics.CodeAnalysis;

using AslHelp.Common.Results;
using AslHelp.Memory.Inspect;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Memory.Inspect;

internal sealed class MonoStringWatcher : MonoWatcherBase<string>
{
    public MonoStringWatcher(IMonoProcessMemory memory, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets) { }

    protected override Result<string> Read(nuint address)
    {
        return _memory.ReadString(address);
    }

    protected override bool Equals(string? old, string? current)
    {
        return old == current;
    }

    public override string ToString()
    {
        return $"{nameof(MonoStringWatcher)}({WatcherPathToString()})";
    }
}
