using System;

using AslHelp.Common.Results;
using AslHelp.Memory.Errors;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result WriteArray<T>(ReadOnlySpan<T> values, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return WriteArray(values, MainModule, baseOffset, offsets);
    }

    public Result WriteArray<T>(ReadOnlySpan<T> values, string? moduleName, int baseOffset, params int[] offsets)
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

        return WriteArray(values, module, baseOffset, offsets);
    }

    public Result WriteArray<T>(ReadOnlySpan<T> values, Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.ModuleNull;
        }

        return WriteArray(values, module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result WriteArray<T>(ReadOnlySpan<T> values, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        if (!Deref(baseAddress, offsets)
            .TryUnwrap(out nuint deref, out var err))
        {
            return Result.Err(err);
        }

        uint size = GetNativeSizeOf<T>() * (uint)values.Length;

        fixed (T* pValues = values)
        {
            if (!WinInteropWrapper.WriteMemory(_handle, deref, pValues, size))
            {
                return IpcError.WriteMemoryFailure(deref);
            }
        }

        return Result.Ok();
    }
}
