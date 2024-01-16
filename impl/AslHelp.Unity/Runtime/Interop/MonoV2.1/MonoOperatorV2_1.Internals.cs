using AslHelp.Common.Results;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV2_1
{
    protected override Result<MonoTypeKind> GetMonoClassClassKind(nuint klass)
    {
        return _memory.Read<MonoTypeKind>(klass + _structs["MonoClass"]["class_kind"]);
    }
}
