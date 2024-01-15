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

    public static IpcError ProcessMemoryWasDisposed
        => new("Cannot interact with the process memory after it has been disposed.");

    public static IpcError ModuleNameMustNotBeNull
        => new("The provided module name must not be null.");

    public static IpcError ModuleMustNotBeNull
        => new("The provided module must not be null.");

    public static IpcError BaseAddressMustNotBeNull
        => new("The provided base address must not be null.");

    public static IpcError DerefFailure(nuint address)
    {
        return new($"Failed to dereference address at {(ulong)address:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}");
    }

    public static IpcError DerefFailureNullPointer
        => new("Dereference resulted in a null pointer.");

    public static IpcError ReadMemoryFailure(nuint address)
    {
        return new($"Failed to read memory at {(ulong)address:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}");
    }

    public static IpcError WriteMemoryFailure(nuint address)
    {
        return new($"Failed to write memory at {(ulong)address:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}");
    }
}
