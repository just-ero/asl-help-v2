using System.Collections.Generic;

using AslHelp.Memory.Ipc;

namespace AslHelp.Unity.Memory.Ipc;

public interface IMonoMemoryWriter : IMemoryWriter
{
    bool WriteArray<T>(T[] values, nuint address, params int[] offsets) where T : unmanaged;

    bool WriteList<T>(List<T> values, nuint address, params int[] offsets) where T : unmanaged;

    // Result<MonoIpcError> TryWriteHashSet<T>(HashSet<T> values, nuint address, params int[] offsets) where T : unmanaged;
}
