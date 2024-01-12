using System;

using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public unsafe bool WriteSpan<T>(ReadOnlySpan<T> values, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        uint size = GetNativeSizeOf<T>() * (uint)values.Length;

        fixed (T* pValues = values)
        {
            return
                TryDeref(out nuint deref, baseAddress, offsets)
                && WinInteropWrapper.WriteMemory(_handle, deref, pValues, size);
        }
    }
}
