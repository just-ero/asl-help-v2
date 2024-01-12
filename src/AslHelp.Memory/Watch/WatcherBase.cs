using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory.Ipc;

namespace AslHelp.Memory.Watch;

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
        set => _current = value;
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
        set => _old = value;
    }

    /// <inheritdoc/>
    public bool Changed { get; private set; }

    /// <inheritdoc/>
    public bool Enabled { get; set; }

    /// <inheritdoc/>
    public bool UpdateOnFail { get; set; } = false;

    /// <inheritdoc/>
    public virtual bool TryDeref(out nuint result)
    {
        return _memory.TryDeref(out result, _baseAddress, _offsets);
    }

    private void Update()
    {
        if (!Enabled)
        {
            return;
        }

        _tick = _memory.Tick;
        _old = _current;

        if (TryDeref(out nuint deref)
            && TryRead(deref, out T? value))
        {
            _current = value;
            Changed = !Equals(_old, _current);
        }
        else if (UpdateOnFail)
        {
            _current = default;
            Changed = false;
        }
    }

    protected abstract bool TryRead(nuint address, [NotNullWhen(true)] out T? value);
    protected abstract bool Equals(T? old, T? current);

    object? IWatcher.Current
    {
        get => Current;
        set => Current = (T?)value;
    }

    object? IWatcher.Old
    {
        get => Old;
        set => Old = (T?)value;
    }
}
