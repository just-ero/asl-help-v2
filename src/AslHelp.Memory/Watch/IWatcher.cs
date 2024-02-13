using AslHelp.Common.Results;

namespace AslHelp.Memory.Watch;

public interface IWatcher
{
    object? Current { get; }
    object? Old { get; }
    bool Changed { get; }

    bool Enabled { get; set; }
    bool UpdateOnFail { get; set; }

    Result<nuint> Deref();
}

public interface IWatcher<out T> : IWatcher
{
    new T? Current { get; }
    new T? Old { get; }
}
