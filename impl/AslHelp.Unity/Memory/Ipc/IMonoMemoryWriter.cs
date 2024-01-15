using System.Collections.Generic;

using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.Ipc;

namespace AslHelp.Unity.Memory.Ipc;

public interface IMonoMemoryWriter : IMemoryWriter
{
    // Result WriteArray<T>(T[] values, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result WriteArray<T>(T[] values, string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result WriteArray<T>(T[] values, Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result WriteArray<T>(T[] values, nuint baseAddress, params int[] offsets) where T : unmanaged;

    // Result WriteList<T>(List<T> values, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result WriteList<T>(List<T> values, string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result WriteList<T>(List<T> values, Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result WriteList<T>(List<T> values, nuint baseAddress, params int[] offsets) where T : unmanaged;

    // Result WriteHashSet<T>(HashSet<T> values, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result WriteHashSet<T>(HashSet<T> values, string? moduleName, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result WriteHashSet<T>(HashSet<T> values, Module? module, int baseOffset, params int[] offsets) where T : unmanaged;
    // Result WriteHashSet<T>(HashSet<T> values, nuint baseAddress, params int[] offsets) where T : unmanaged;
}
