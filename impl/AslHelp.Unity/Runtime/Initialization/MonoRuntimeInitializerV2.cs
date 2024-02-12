using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;
using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime.Initialization;

internal class MonoRuntimeInitializerV2 : MonoRuntimeInitializerV1
{
    protected override string Version { get; } = "2.0";

    protected override MonoRuntime GetOperator(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint loadedAssemblies)
    {
        return new MonoRuntimeV2(memory, structs, defaults, loadedAssemblies);
    }
}
