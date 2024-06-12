using System;
using System.Runtime.InteropServices;

using AslHelp.Common;
using AslHelp.Common.Results;
using AslHelp.Memory.Errors;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public Result<T[]> ReadArray<T>(int length, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        T[] results = new T[length];
        return ReadArray<T>(length, baseOffset, offsets)
            .And<T[]>(results);
    }

    public Result<T[]> ReadArray<T>(int length, string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        T[] results = new T[length];
        return ReadArray<T>(length, moduleName, baseOffset, offsets)
            .And<T[]>(results);
    }

    public Result<T[]> ReadArray<T>(int length, Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        T[] results = new T[length];
        return ReadArray<T>(length, module, baseOffset, offsets)
            .And<T[]>(results);
    }

    public Result<T[]> ReadArray<T>(int length, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        T[] results = new T[length];
        return ReadArray<T>(results, baseAddress, offsets)
            .And<T[]>(results);
    }

    public Result ReadArray<T>(Span<T> buffer, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return ReadArray(buffer, MainModule, baseOffset, offsets);
    }

    public Result ReadArray<T>(Span<T> buffer, string? moduleName, int baseOffset, params int[] offsets)
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

        return ReadArray(buffer, module, baseOffset, offsets);
    }

    public Result ReadArray<T>(Span<T> buffer, Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        if (module is null)
        {
            return IpcError.ModuleNull;
        }

        return ReadArray(buffer, module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe Result ReadArray<T>(Span<T> buffer, nuint baseAddress, params int[] offsets)
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

            if (ReadArray(buf32[buf64.Length..], baseAddress, offsets)
                .TryUnwrapErr(out var err1))
            {
                return Result.Err(err1);
            }

            for (int i = 0; i < buf64.Length; i++)
            {
                buf64[i] = buf32[buf64.Length + i];
            }

            return Result.Ok();
        }

        if (!Deref(baseAddress, offsets)
            .TryUnwrap(out nuint deref, out var err2))
        {
            return Result.Err(err2);
        }

        uint size = GetNativeSizeOf<T>() * (uint)buffer.Length;

        fixed (T* pBuffer = buffer)
        {
            if (!WinInteropWrapper.ReadMemory(_handle, deref, pBuffer, size))
            {
                return IpcError.ReadMemoryFailure(deref);
            }
        }

        return Result.Ok();
    }
}
