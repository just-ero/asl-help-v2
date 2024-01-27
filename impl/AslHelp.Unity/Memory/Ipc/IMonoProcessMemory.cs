using AslHelp.Memory;
using AslHelp.Memory.Ipc;

namespace AslHelp.Unity.Memory.Ipc;

public interface IMonoProcessMemory : IProcessMemory, IMonoMemoryReader, IMonoMemoryWriter
{ }
