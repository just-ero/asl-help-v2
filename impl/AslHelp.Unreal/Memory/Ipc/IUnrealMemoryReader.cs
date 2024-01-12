using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory.Ipc;

namespace AslHelp.Unreal.Memory.Ipc;

internal interface IUnrealMemoryReader : IMemoryReader
{
    bool TryReadTArray<T>([NotNullWhen(true)] out T[]? results, nuint address, params int[] offsets) where T : unmanaged;

    bool TryReadTSet<T>([NotNullWhen(true)] out HashSet<T>? results, nuint address, params int[] offsets) where T : unmanaged;

    // bool TryReadTMap<TKey, TValue>([NotNullWhen(true)] out Dictionary<TKey, TValue>? results, nuint address, params int[] offsets) where TKey : unmanaged where TValue : unmanaged;

    // bool TryReadTMap<TValue>([NotNullWhen(true)] out Dictionary<string, TValue>? results, nuint address, params int[] offsets) where TValue : unmanaged;

    bool TryReadFString([NotNullWhen(true)] out string? result, nuint address, params int[] offsets);
}
