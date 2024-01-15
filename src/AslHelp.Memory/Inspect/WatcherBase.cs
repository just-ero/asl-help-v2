using System.Linq;

using AslHelp.Common.Results;
using AslHelp.Memory.Ipc;

namespace AslHelp.Memory.Inspect;

public abstract class WatcherBase<T> : IWatcher<T>
{
    private readonly nuint _baseAddress;
    private readonly int[] _offsets;

    private uint _tick;
    private T? _current;
    private T? _old;

    protected readonly IProcessMemory _memory;

    protected WatcherBase(IProcessMemory memory, nuint baseAddress, params int[] offsets)
    {
        _memory = memory;
        _baseAddress = baseAddress;
        _offsets = offsets;
    }

    /// <inheritdoc/>
    public T? Current
    {
        get
        {
            if (_tick != _memory.Tick)
            {
                Update();
            }

            return _current;
        }
    }

    /// <inheritdoc/>
    public T? Old
    {
        get
        {
            if (_tick != _memory.Tick)
            {
                Update();
            }

            return _old;
        }
    }

    /// <inheritdoc/>
    public bool Changed { get; private set; }

    /// <inheritdoc/>
    public bool Enabled { get; set; }

    /// <inheritdoc/>
    public bool UpdateOnFail { get; set; } = false;

    /// <inheritdoc/>
    public virtual Result<nuint> Deref()
    {
        return _memory.Deref(_baseAddress, _offsets);
    }

    private void Update()
    {
        if (!Enabled)
        {
            return;
        }

        _tick = _memory.Tick;
        _old = _current;

        Deref()
            .AndThen(Read)
            .AndThen(value => _current = value)
            .OrElse(_ =>
            {
                if (UpdateOnFail)
                {
                    _current = default;
                }
            });

        Changed = !Equals(_old, _current);
    }

    protected abstract Result<T> Read(nuint address);
    protected abstract bool Equals(T? old, T? current);

    public abstract override string ToString();

    protected string WatcherPathToString()
    {
        return $"0x{(ulong)_baseAddress:X}, {string.Join(", ", _offsets.Select(static o => $"0x{o:X}"))}";
    }

    object? IWatcher.Current => Current;
    object? IWatcher.Old => Old;
}
