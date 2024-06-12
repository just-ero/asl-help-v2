using AslHelp.Common.Results.Errors;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Errors;

internal sealed record IpcError : ResultError
{
    private IpcError(string message)
        : base(message) { }

    public static IpcError Other(string message)
    {
        return new(message);
    }

    // Pre-op
    public static IpcError ProcessMemoryDisposed
        => new("Cannot interact with the process memory after it has been disposed.");

    public static IpcError ModuleNameNull
        => new("The provided module name must not be null.");

    public static IpcError ModuleNotFound(string moduleName)
    {
        return new($"A module with the name '{moduleName}' was not present in the target process.");
    }

    public static IpcError ModuleNull
        => new("The provided module must not be null.");

    public static IpcError BaseAddressNull
        => new("The provided base address must not be null.");

    public static IpcError ReadStringMaxLengthNegative
        => new("The maximum string length must not be a negative integer.");

    public static IpcError ScanRegionEndLessThanRegionStart
        => new("The pattern scan region start address must be less than the end address.");

    public static IpcError ScanRegionSizeNegative
        => new("The pattern scan region size must be a positive integer.");

    // Op
    public static IpcError DerefNull
        => new("Dereference resulted in a null pointer.");

    public static IpcError DerefFailure(nuint address)
    {
        return new($"Failed to dereference address at {(ulong)address:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}");
    }

    public static IpcError ReadMemoryFailure(nuint address)
    {
        return new($"Failed to read memory at {(ulong)address:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}");
    }

    public static IpcError WriteMemoryFailure(nuint address)
    {
        return new($"Failed to write memory at {(ulong)address:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}");
    }

    public static IpcError ScanNoMatch
        => new("No matches were found for the provided pattern.");
}
