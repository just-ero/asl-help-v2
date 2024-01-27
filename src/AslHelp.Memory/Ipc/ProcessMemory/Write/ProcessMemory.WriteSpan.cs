using System;

using AslHelp.Common.Results;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result WriteSpan<T>(ReadOnlySpan<T> values, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return WriteSpan(values, MainModule, baseOffset, offsets);
    }

    public Result WriteSpan<T>(ReadOnlySpan<T> values, string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_Is_Null;
        }

        return WriteSpan(values, Modules[moduleName], baseOffset, offsets);
    }

    public Result WriteSpan<T>(ReadOnlySpan<T> values, Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.Module_Is_Null;
        }

        return WriteSpan(values, module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result WriteSpan<T>(ReadOnlySpan<T> values, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        Result<nuint> deref = Deref(baseAddress, offsets);
        if (deref.IsErr)
        {
            return Result.Err(deref.UnwrapErr());
        }

        uint size = GetNativeSizeOf<T>() * (uint)values.Length;

        fixed (T* pValues = values)
        {
            return WriteOp(deref.Unwrap(), pValues, size);
        }
    }
}
