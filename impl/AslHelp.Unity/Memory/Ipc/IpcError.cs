using AslHelp.Common.Results.Errors;

namespace AslHelp.Unity.Memory.Ipc;

internal sealed record IpcError : ResultError
{
    private IpcError(string message)
        : base(message) { }

    public static IpcError Other(string message)
    {
        return new(message);
    }

    // Pre-op
    public static IpcError ModuleName_Is_Null
        => new("The provided module name must not be null.");

    public static IpcError Module_Is_Null
        => new("The provided module must not be null.");
}
