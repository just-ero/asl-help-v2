namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV2_1
{
    protected override bool TryGetMonoClassClassKind(nuint klass, out MonoTypeKind classKind)
    {
        return _memory.TryRead(out classKind, klass + _structs["MonoClass"]["class_kind"]);
    }
}
