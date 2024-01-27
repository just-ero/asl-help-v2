using AslHelp.Common.Results;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result<T> Read<T>(int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return Read<T>(MainModule, baseOffset, offsets);
    }

    public Result<T> Read<T>(string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_Is_Null;
        }

        return Read<T>(Modules[moduleName], baseOffset, offsets);
    }

    public Result<T> Read<T>(Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.Module_Is_Null;
        }

        return Read<T>(module.Base + (nuint)baseOffset, offsets);
    }

    public Result<T> Read<T>(nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return
            Deref(baseAddress, offsets)
            .AndThen(ReadOp<T>);
    }

    private unsafe Result<T> ReadOp<T>(nuint deref)
        where T : unmanaged
    {
        T result;
        return ReadOp(deref, &result, GetNativeSizeOf<T>())
            .Map(result);
    }

    private unsafe Result ReadOp<T>(nuint deref, T* buffer, uint bufferLength)
        where T : unmanaged
    {
        if (!WinInteropWrapper.ReadMemory(_handle, deref, buffer, bufferLength))
        {
            return IpcError.ReadMemoryFailure_Win32Error(deref);
        }

        return Result.Ok();
    }
}
