using System.Collections.Generic;

namespace AslHelp.Unity.Memory.Ipc;

internal partial class MonoProcessMemory
{
    public bool WriteList<T>(List<T> values, nuint address, params int[] offsets)
        where T : unmanaged
    {
        throw new System.NotImplementedException();
    }
}
