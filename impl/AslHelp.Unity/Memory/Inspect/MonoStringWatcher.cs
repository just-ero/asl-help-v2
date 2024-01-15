using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory.Inspect;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Memory.Inspect;

internal sealed class MonoStringWatcher : WatcherBase<string>
{
    private new readonly IMonoProcessMemory _memory;

    public MonoStringWatcher(IMonoProcessMemory memory, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets)
    {
        _memory = memory;
    }

    protected override bool TryRead(nuint address, [NotNullWhen(true)] out string? value)
    {
        return _memory.TryReadString(out value, address);
    }

    protected override bool Equals(string? old, string? current)
    {
        return old == current;
    }
}
