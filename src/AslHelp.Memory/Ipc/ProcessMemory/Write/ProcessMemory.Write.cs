using AslHelp.Common.Results;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result Write<T>(T value, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return Write(value, MainModule, baseOffset, offsets);
    }

    public Result Write<T>(T value, string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return Write(value, Modules[moduleName], baseOffset, offsets);
    }

    public Result Write<T>(T value, Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return Write(value, module.Base + (nuint)baseOffset, offsets);
    }

    public Result Write<T>(T value, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return
            Deref(baseAddress, offsets)
            .AndThen(deref => Write(value, deref));
    }

    private unsafe Result Write<T>(T value, nuint address)
        where T : unmanaged
    {
        if (!WinInteropWrapper.WriteMemory(_handle, address, &value, GetNativeSizeOf<T>()))
        {
            return IpcError.WriteMemoryFailure_Win32Error(address);
        }

        return Result.Ok();
    }
}
