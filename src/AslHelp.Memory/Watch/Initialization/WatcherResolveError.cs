using AslHelp.Common.Results.Errors;

namespace AslHelp.Memory.Watch.Initialization;

internal sealed record WatcherResolveError : ResultError
{
    private WatcherResolveError(string message)
        : base(message) { }

    public static WatcherResolveError Other(string message)
    {
        return new(message);
    }

    public static WatcherResolveError ModuleNotFound(string moduleName)
    {
        return new($"Module '{moduleName}' not yet found.");
    }
}
