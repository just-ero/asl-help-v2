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

    // Pre-op
    public static IpcError ProcessMemory_Is_Disposed
        => new("Cannot interact with the process memory after it has been disposed.");

    public static IpcError ModuleName_Is_Null
        => new("The provided module name must not be null.");

    public static IpcError Module_Is_Null
        => new("The provided module must not be null.");

    public static IpcError BaseAddress_Is_Null
        => new("The provided base address must not be null.");

    public static IpcError ReadString_MaxLength_Is_Negative
        => new("The maximum string length must not be a negative integer.");

    public static IpcError PatternScan_Alignment_IsNot_Positive
        => new("The pattern scan alignment must be a positive integer.");

    public static IpcError PatternScan_RegionStart_IsNot_LessThan_End
        => new("The pattern scan region start address must be less than the end address.");

    public static IpcError PatternScan_RegionSize_IsNot_Positive
        => new("The pattern scan region size must be a positive integer.");

    // Op
    public static IpcError Deref_Is_Null
        => new("Dereference resulted in a null pointer.");

    public static IpcError DerefFailure_Win32Error(nuint address)
    {
        return new($"Failed to dereference address at {(ulong)address:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}");
    }

    public static IpcError ReadMemoryFailure_Win32Error(nuint address)
    {
        return new($"Failed to read memory at {(ulong)address:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}");
    }

    public static IpcError WriteMemoryFailure_Win32Error(nuint address)
    {
        return new($"Failed to write memory at {(ulong)address:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}");
    }

    public static IpcError PatternScan_NotFound
        => new("No matches were found for the provided pattern.");
}
