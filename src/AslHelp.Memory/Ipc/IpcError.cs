using System.Runtime.CompilerServices;

using AslHelp.Common.Results.Errors;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

internal sealed record IpcError : ResultError
{
    private IpcError(string message)
        : base(message) { }

    public static IpcError Other(string message)
    {
        return new(message);
    }

    public static IpcError InvalidAddress(nuint address)
    {
        return new($"Provided address had an invalid value (0x{address:X}).");
    }

    public static IpcError DerefFailure
        => new($"Failed to dereference pointer ({WinInteropWrapper.GetLastWin32ErrorMessage()}).");
}
