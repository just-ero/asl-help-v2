using AslHelp.Common.Results;
using AslHelp.Memory.Errors;
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
            return IpcError.ModuleNameNull;
        }

        if (!Modules.TryGetValue(moduleName, out Module? module))
        {
            return IpcError.ModuleNotFound(moduleName);
        }

        return Write(value, module, baseOffset, offsets);
    }

    public Result Write<T>(T value, Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.ModuleNull;
        }

        return Write(value, module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result Write<T>(T value, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        if (!Deref(baseAddress, offsets)
            .TryUnwrap(out nuint deref, out var err))
        {
            return Result.Err(err);
        }

        uint size = GetNativeSizeOf<T>();

        if (!WinInteropWrapper.WriteMemory(_handle, deref, &value, size))
        {
            return IpcError.WriteMemoryFailure(deref);
        }

        return Result.Ok();
    }
}
