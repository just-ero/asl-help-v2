using AslHelp.Common.Results;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoRuntimeV2
{
    public override Result<nuint> GetClassStaticDataChunk(nuint klass)
    {
        return GetMonoClassVTable(klass)
            .AndThen(vTable => _memory.Read<nuint>(vTable + _structs["MonoClass"]["vtable_size"])
                .AndThen(vTableSize => _memory.Read<nuint>(vTable + _structs["MonoClass"]["vtable"] + (_memory.PointerSize * vTableSize))));
    }
}
