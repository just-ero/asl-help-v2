using AslHelp.Common;
using AslHelp.Common.Results;
using AslHelp.Memory.Errors;
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
            return IpcError.ModuleNameNull;
        }

        if (!Modules.TryGetValue(moduleName, out Module? module))
        {
            return IpcError.ModuleNotFound(moduleName);
        }

        return Read<T>(module, baseOffset, offsets);
    }

    public Result<T> Read<T>(Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.ModuleNull;
        }

        return Read<T>(module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result<T> Read<T>(nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        return Deref(baseAddress, offsets)
            .AndThen<T>(deref =>
            {
                uint size = GetNativeSizeOf<T>();

                T result;
                if (!WinInteropWrapper.ReadMemory(_handle, deref, &result, size))
                {
                    return IpcError.ReadMemoryFailure(deref);
                }

                return result;
            });
    }
}
