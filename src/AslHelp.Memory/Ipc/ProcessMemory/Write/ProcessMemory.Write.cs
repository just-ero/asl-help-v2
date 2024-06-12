using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public void Write<T>(T value, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        Write(value, MainModule, baseOffset, offsets);
    }

    public void Write<T>(T value, [NotNull] string? moduleName, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(moduleName);

        Write(value, Modules[moduleName], baseOffset, offsets);
    }

    public void Write<T>(T value, [NotNull] Module? module, int baseOffset, params int[] offsets)
        where T : unmanaged
    {
        ThrowHelper.ThrowIfNull(module);

        Write(value, module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe void Write<T>(T value, nuint baseAddress, params int[] offsets)
        where T : unmanaged
    {
        nuint deref = Deref(baseAddress, offsets);
        uint size = GetNativeSizeOf<T>();

        if (!WinInteropWrapper.WriteMemory(_handle, deref, &value, size))
        {
            string msg = $"Failed to write memory at {(ulong)deref:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}";
            ThrowHelper.ThrowException(msg);
        }
    }
}
