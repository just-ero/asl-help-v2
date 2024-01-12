using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory.Ipc;

namespace AslHelp.Unity.Memory.Ipc;

public interface IMonoMemoryReader : IMemoryReader
{
    bool TryReadArray<T>([NotNullWhen(true)] out T[]? results, nuint address, params int[] offsets) where T : unmanaged;

    bool TryReadList<T>([NotNullWhen(true)] out List<T>? results, nuint address, params int[] offsets) where T : unmanaged;

    // Result<HashSet<T>, IpcError> TryReadHashSet<T>(nuint address, params int[] offsets) where T : unmanaged;

    // Result<Dictionary<TKey, TValue>, IpcError> TryReadDictionary<TKey, TValue>(nuint address, params int[] offsets) where TKey : unmanaged where TValue : unmanaged;

    // Result<Dictionary<string, TValue>, IpcError> TryReadDictionary<TValue>(nuint address, params int[] offsets) where TValue : unmanaged;

    bool TryReadString([NotNullWhen(true)] out string? result, nuint address, params int[] offsets);
}
