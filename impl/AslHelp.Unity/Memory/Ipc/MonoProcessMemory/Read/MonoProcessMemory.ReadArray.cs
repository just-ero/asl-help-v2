using System.Diagnostics.CodeAnalysis;

namespace AslHelp.Unity.Memory.Ipc;

internal partial class MonoProcessMemory
{
    public bool TryReadArray<T>([NotNullWhen(true)] out T[]? results, nuint address, params int[] offsets)
        where T : unmanaged
    {
        results = default;

        if (!TryRead(out nuint array, address, offsets))
        {
            return false;
        }

        if (!TryRead(out int length, array + (PointerSize * 3U)))
        {
            return false;
        }

        results = new T[length];
        return TryReadSpan<T>(results, array + (PointerSize * 4U));
    }
}
