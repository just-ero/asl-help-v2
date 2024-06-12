using System;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public void WriteArray<T>(ReadOnlySpan<T> values, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        WriteArray(values, MainModule, baseOffset, offsets);
    }

    public void WriteArray<T>(ReadOnlySpan<T> values, [NotNull] string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(moduleName);

        WriteArray(values, Modules[moduleName], baseOffset, offsets);
    }

    public void WriteArray<T>(ReadOnlySpan<T> values, [NotNull] Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(module);

        WriteArray(values, module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe void WriteArray<T>(ReadOnlySpan<T> values, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        nuint deref = Deref(baseAddress, offsets);
        uint size = GetNativeSizeOf<T>() * (uint)values.Length;

        fixed (T* pValues = values)
        {
            if (!WinInteropWrapper.WriteMemory(_handle, deref, pValues, size))
            {
                string msg = $"Failed to write memory at {(ulong)deref:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}";
                ThrowHelper.ThrowException(msg);
            }
        }
    }
}
