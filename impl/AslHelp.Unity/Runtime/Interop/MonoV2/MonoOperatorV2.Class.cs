namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV2
{
    public override bool TryGetClassStaticDataChunk(nuint klass, out nuint staticDataChunk)
    {
        staticDataChunk = default;

        return TryGetMonoClassVTable(klass, out var monoClassVTable)
            && _memory.TryRead(out uint vTableSize, klass + _structs["MonoClass"]["vtable_size"])
            && _memory.TryRead(out staticDataChunk, monoClassVTable + _structs["MonoClass"]["vtable"] + (_memory.PointerSize * vTableSize));
    }
}
