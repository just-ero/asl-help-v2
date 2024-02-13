using AslHelp.Common.Results;
using AslHelp.Memory.Ipc;

namespace AslHelp.Memory.Watch;

internal sealed class StringWatcher : WatcherBase<string>
{
    private readonly int _maxLength;
    private readonly StringType _stringType;

    public StringWatcher(IProcessMemory memory, int maxLength, nuint baseAddress, params int[] offsets)
        : this(memory, maxLength, StringType.Auto, baseAddress, offsets) { }

    public StringWatcher(IProcessMemory memory, int maxLength, StringType stringType, nuint baseAddress, params int[] offsets)
        : base(memory, baseAddress, offsets)
    {
        _maxLength = maxLength;
        _stringType = stringType;
    }

    protected override Result<string> Read(nuint address)
    {
        return _memory.ReadString(_maxLength, _stringType, address);
    }

    protected override bool Equals(string? old, string? current)
    {
        return old == current;
    }

    public override string ToString()
    {
        return $"{nameof(StringWatcher)}({WatcherPathToString()})";
    }
}
