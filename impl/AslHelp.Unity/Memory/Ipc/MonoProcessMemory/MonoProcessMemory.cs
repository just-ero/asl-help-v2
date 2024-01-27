using System.Diagnostics;

using AslHelp.Common.Results;
using AslHelp.Memory;
using AslHelp.Memory.Ipc;

namespace AslHelp.Unity.Memory.Ipc;

public sealed partial class MonoProcessMemory : ProcessMemory, IMonoProcessMemory
{
    public MonoProcessMemory(Process process)
        : base(process) { }
}
