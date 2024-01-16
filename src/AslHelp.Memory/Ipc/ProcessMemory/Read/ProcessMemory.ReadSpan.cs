using System;
using System.Runtime.InteropServices;

using AslHelp.Common.Results;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result<T[]> ReadSpan<T>(int length, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return ReadSpan<T>(length, MainModule, baseOffset, offsets);
    }

    public Result<T[]> ReadSpan<T>(int length, string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return ReadSpan<T>(length, Modules[moduleName], baseOffset, offsets);
    }

    public Result<T[]> ReadSpan<T>(int length, Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return ReadSpan<T>(length, module.Base + (nuint)baseOffset, offsets);
    }

    public Result<T[]> ReadSpan<T>(int length, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        T[] result = new T[length];
        return
            ReadSpan<T>(result, baseAddress, offsets)
            .And<T[]>(result);
    }

    public Result ReadSpan<T>(Span<T> buffer, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return ReadSpan(buffer, MainModule, baseOffset, offsets);
    }

    public Result ReadSpan<T>(Span<T> buffer, string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (moduleName is null)
        {
            return IpcError.ModuleName_MustNot_BeNull;
        }

        return ReadSpan(buffer, Modules[moduleName], baseOffset, offsets);
    }

    public Result ReadSpan<T>(Span<T> buffer, Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.Module_MustNot_BeNull;
        }

        return ReadSpan(buffer, module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result ReadSpan<T>(Span<T> buffer, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        if (buffer.Length == 0)
        {
            return Result.Ok();
        }

        if (!Is64Bit && IsNativeInt<T>())
        {
            // Need to read 32-bit integers for the pointers and then copy.

            Span<uint> buf32 = MemoryMarshal.Cast<T, uint>(buffer);
            Span<ulong> buf64 = MemoryMarshal.Cast<T, ulong>(buffer);

            Result res = ReadSpan(buf32[buf64.Length..], baseAddress, offsets);
            if (res.IsErr)
            {
                return Result.Err(res.UnwrapErr());
            }

            for (int i = 0; i < buf64.Length; i++)
            {
                buf64[i] = buf32[buf64.Length + i];
            }

            return Result.Ok();
        }

        Result<nuint> deref = Deref(baseAddress, offsets);
        if (deref.IsErr)
        {
            return Result.Err(deref.UnwrapErr());
        }

        uint size = GetNativeSizeOf<T>() * (uint)buffer.Length;

        fixed (T* pBuffer = buffer)
        {
            return ReadOp(deref.Unwrap(), pBuffer, size);
        }
    }
}
