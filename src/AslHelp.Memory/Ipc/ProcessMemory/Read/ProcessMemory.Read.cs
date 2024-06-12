using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public T Read<T>(int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        return Read<T>(MainModule, baseOffset, offsets);
    }

    public T Read<T>([NotNull] string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(moduleName);

        return Read<T>(Modules[moduleName], baseOffset, offsets);
    }

    public T Read<T>([NotNull] Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(module);

        return Read<T>(module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe T Read<T>(nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        nuint deref = Deref(baseAddress, offsets);
        uint size = GetNativeSizeOf<T>();

        T result;
        if (!WinInteropWrapper.ReadMemory(_handle, deref, &result, size))
        {
            string msg = $"Failed to read memory at {(ulong)deref:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}";
            ThrowHelper.ThrowException(msg);
        }

        return result;
    }
}
