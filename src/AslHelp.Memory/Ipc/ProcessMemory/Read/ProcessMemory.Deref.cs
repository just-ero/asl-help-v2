using System.Diagnostics.CodeAnalysis;

using AslHelp.Common;
using AslHelp.Common.Results;
using AslHelp.Memory.Native;

namespace AslHelp.Memory.Ipc;

public partial class ProcessMemory
{
    public nuint Deref(uint baseOffset, params int[] offsets)
    {
        return Deref(MainModule, baseOffset, offsets);
    }

    public nuint Deref(string moduleName, uint baseOffset, params int[] offsets)
    {
        return Deref(Modules[moduleName], baseOffset, offsets);
    }

    public nuint Deref(Module module, uint baseOffset, params int[] offsets)
    {
        return Deref(module.Base + baseOffset, offsets);
    }

    public unsafe nuint Deref(nuint baseAddress, params int[] offsets)
    {
        if (_isDisposed)
        {
            ThrowHelper.ThrowObjectDisposedException(nameof(ProcessMemory));
        }

        if (baseAddress == 0)
        {
            string msg = IpcError.InvalidAddress(baseAddress).Message;
            ThrowHelper.ThrowArgumentOutOfRangeException(nameof(baseAddress), msg);
        }

        nuint result = baseAddress;

        for (int i = 0; i < offsets.Length; i++)
        {
            if (!WinInteropWrapper.ReadMemory(_handle, result, &result, PointerSize)
                || result == 0)
            {
                string msg = IpcError.DerefFailure.Message;
                ThrowHelper.ThrowInvalidOperationException(msg);
            }

            result += (nuint)offsets[i];
        }

        return result;
    }

    public bool TryDeref(out nuint result, uint baseOffset, params int[] offsets)
    {
        return TryDeref(out result, MainModule, baseOffset, offsets);
    }

    public bool TryDeref(out nuint result, [NotNullWhen(true)] string? moduleName, uint baseOffset, params int[] offsets)
    {
        if (moduleName is null)
        {
            result = default;
            return false;
        }

        return TryDeref(out result, Modules[moduleName], baseOffset, offsets);
    }

    public bool TryDeref(out nuint result, [NotNullWhen(true)] Module? module, uint baseOffset, params int[] offsets)
    {
        if (module is null)
        {
            result = default;
            return false;
        }

        return TryDeref(out result, module.Base + baseOffset, offsets);
    }

    public unsafe bool TryDeref(out nuint result, nuint baseAddress, params int[] offsets)
    {
        if (_isDisposed)
        {
            result = default;
            return false;
        }

        if (baseAddress == 0)
        {
            result = default;
            return false;
        }

        result = baseAddress;

        fixed (nuint* pResult = &result)
        {
            for (int i = 0; i < offsets.Length; i++)
            {
                if (!WinInteropWrapper.ReadMemory(_handle, result, pResult, PointerSize)
                    || result == 0)
                {
                    return false;
                }

                result += (nuint)offsets[i];
            }
        }

        return true;
    }
}
