namespace AslHelp.Memory.Watch;

public interface IWatcher
{
    object? Current { get; set; }
    object? Old { get; set; }
    bool Changed { get; }

    bool Enabled { get; set; }
    bool UpdateOnFail { get; set; }

    bool TryDeref(out nuint result);
}

public interface IWatcher<T> : IWatcher
{
    new T? Current { get; set; }
    new T? Old { get; set; }
}
