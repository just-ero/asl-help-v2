using System.Collections.Generic;

using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.Ipc;

namespace AslHelp.Unity.Memory.Ipc;

public interface IMonoMemoryReader : IMemoryReader
{
    Result<T[]> ReadArray<T>(int baseOffset, params int[] offsets) where T : unmanaged;
    Result<T[]> ReadArray<T>(string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    Result<T[]> ReadArray<T>(Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    Result<T[]> ReadArray<T>(nuint baseAddress, params int[] offsets) where T : unmanaged;

    Result<List<T>> ReadList<T>(int baseOffset, params int[] offsets) where T : unmanaged;
    Result<List<T>> ReadList<T>(string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    Result<List<T>> ReadList<T>(Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    Result<List<T>> ReadList<T>(nuint baseAddress, params int[] offsets) where T : unmanaged;

    // Result<ISet<T>> ReadHashSet<T>(int baseOffset, params int[] offsets) where T : unmanaged;
    // Result<ISet<T>> ReadHashSet<T>(string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result<ISet<T>> ReadHashSet<T>(Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result<ISet<T>> ReadHashSet<T>(nuint baseAddress, params int[] offsets) where T : unmanaged;

    // Result<IDictionary<TKey, TValue>> ReadDictionary<TKey, TValue>(int baseOffset, params int[] offsets) where TKey : unmanaged where TValue : unmanaged;
    // Result<IDictionary<TKey, TValue>> ReadDictionary<TKey, TValue>(string? moduleName, int baseOffset, params int[] offsets) where TKey : unmanaged where TValue : unmanaged;
    // Result<IDictionary<TKey, TValue>> ReadDictionary<TKey, TValue>(Module? module, int baseOffset, params int[] offsets) where TKey : unmanaged where TValue : unmanaged;
    // Result<IDictionary<TKey, TValue>> ReadDictionary<TKey, TValue>(nuint baseAddress, params int[] offsets) where TKey : unmanaged where TValue : unmanaged;

    // Result<IDictionary<string, TValue>> ReadDictionary<TValue>(int baseOffset, params int[] offsets) where TValue : unmanaged;
    // Result<IDictionary<string, TValue>> ReadDictionary<TValue>(string? moduleName, int baseOffset, params int[] offsets) where TValue : unmanaged;
    // Result<IDictionary<string, TValue>> ReadDictionary<TValue>(Module? module, int baseOffset, params int[] offsets) where TValue : unmanaged;
    // Result<IDictionary<string, TValue>> ReadDictionary<TValue>(nuint baseAddress, params int[] offsets) where TValue : unmanaged;

    Result<string> ReadString(int baseOffset, params int[] offsets);
    Result<string> ReadString(string? moduleName, int baseOffset, params int[] offsets);
    Result<string> ReadString(Module? module, int baseOffset, params int[] offsets);
    Result<string> ReadString(nuint baseAddress, params int[] offsets);
}
