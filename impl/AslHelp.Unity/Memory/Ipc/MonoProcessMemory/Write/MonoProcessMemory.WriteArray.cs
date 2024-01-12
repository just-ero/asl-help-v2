namespace AslHelp.Unity.Memory.Ipc;

internal partial class MonoProcessMemory
{
    public bool WriteArray<T>(T[] values, nuint address, params int[] offsets)
        where T : unmanaged
    {
        throw new System.NotImplementedException();
    }
}
