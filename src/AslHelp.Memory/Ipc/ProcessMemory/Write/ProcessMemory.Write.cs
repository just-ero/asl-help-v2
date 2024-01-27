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
            return IpcError.ModuleName_Is_Null;
        }

        return Write(value, Modules[moduleName], baseOffset, offsets);
    }

    public Result Write<T>(T value, Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.Module_Is_Null;
        }

        return Write(value, module.Base + (nuint)baseOffset, offsets);
    }

    public Result Write<T>(T value, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return
            Deref(baseAddress, offsets)
            .AndThen(deref => WriteOp(value, deref));
    }

    private unsafe Result WriteOp<T>(T value, nuint address)
        where T : unmanaged
    {
        return WriteOp(address, &value, GetNativeSizeOf<T>());
    }

    private unsafe Result WriteOp<T>(nuint deref, T* data, uint dataLength)
        where T : unmanaged
    {
        if (!WinInteropWrapper.WriteMemory(_handle, deref, data, dataLength))
        {
            return IpcError.WriteMemoryFailure_Win32Error(deref);
        }

        return Result.Ok();
    }
}
