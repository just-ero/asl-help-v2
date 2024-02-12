using AslHelp.Memory.StructReflection;
using AslHelp.Unity.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop.Initialization;

internal class MonoInitializerV2 : MonoInitializerV1
{
    protected override string Version { get; } = "2.0";

    protected override MonoRuntime GetOperator(IMonoProcessMemory memory, Reflection structs, MonoDefaults defaults, nuint loadedAssemblies)
    {
        return new MonoRuntimeV2(memory, structs, defaults, loadedAssemblies);
    }
}
