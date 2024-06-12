using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public nuint Deref(int baseOffset, params int[] offsets)
    {
        return Deref(MainModule, baseOffset, offsets);
    }

    public nuint Deref([NotNull] string? moduleName, int baseOffset, params int[] offsets)
    {
        ThrowHelper.ThrowIfNull(moduleName);

        return Deref(Modules[moduleName], baseOffset, offsets);
    }

    public nuint Deref([NotNull] Module? module, int baseOffset, params int[] offsets)
    {
        ThrowHelper.ThrowIfNull(module);

        return Deref(module.Base + (nuint)baseOffset, offsets);
    }

    public unsafe nuint Deref(nuint baseAddress, params int[] offsets)
    {
        if (_disposed)
        {
            const string Msg = "Cannot interact with the process memory after it has been disposed.";
            ThrowHelper.ThrowInvalidOperationException(Msg);
        }

        if (baseAddress == 0)
        {
            const string Msg = "The provided base address must not be null.";
            ThrowHelper.ThrowArgumentException(Msg, nameof(baseAddress));
        }

        nuint result = baseAddress;
        uint size = PointerSize;

        for (int i = 0; i < offsets.Length; i++)
        {
            if (!WinInteropWrapper.ReadMemory(_handle, result, &result, size))
            {
                string msg = $"Failed to dereference address at {(ulong)result:X}: {WinInteropWrapper.GetLastWin32ErrorMessage()}";
                ThrowHelper.ThrowException(msg);
            }

            if (result == 0)
            {
                const string Msg = "Dereference resulted in a null pointer.";
                ThrowHelper.ThrowException(Msg);
            }

            result += (nuint)offsets[i];
        }

        return result;
    }
}
