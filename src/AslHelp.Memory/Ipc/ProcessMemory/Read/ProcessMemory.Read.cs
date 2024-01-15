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
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return Read<T>(Modules[moduleName], baseOffset, offsets);
    }

    public Result<T> Read<T>(Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return Read<T>(module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result<T> Read<T>(nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return
            Deref(baseAddress, offsets)
            .AndThen<T>(deref =>
            {
                T result;
                if (!WinInteropWrapper.ReadMemory(_handle, deref, &result, GetNativeSizeOf<T>()))
                {
                    return IpcError.ReadMemoryFailure_Win32Error(deref);
                }

                return result;
            });
    }
}
