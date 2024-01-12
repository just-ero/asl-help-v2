using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Collections.Extensions;

namespace AslHelp.Unity.Memory.Ipc;

internal partial class MonoProcessMemory
{
    public bool TryReadList<T>([NotNullWhen(true)] out List<T>? results, nuint address, params int[] offsets)
        where T : unmanaged
    {
        results = default;

        if (!TryRead(out nuint list, address, offsets))
        {
            return false;
        }

        if (!TryRead(out int count, list + (PointerSize * 3U)))
        {
            return false;
        }

        List<T> values = new(count);
        return TryReadSpan(ListExtensions.AsSpan(values), list + (PointerSize * 4U));
    }
}
