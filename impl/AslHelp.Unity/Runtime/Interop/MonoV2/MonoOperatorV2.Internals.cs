using AslHelp.Common;
using AslHelp.Common.Results;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV2
{
    protected override Result<uint> GetMonoClassFieldCount(nuint klass)
    {
        return GetMonoClassClassKind(klass)
            .AndThen(classKind => classKind switch
            {
                MonoTypeKind.DEF or MonoTypeKind.GTD => _memory.Read<uint>(klass + _structs["MonoClassDef"]["field_count"]),
                MonoTypeKind.GINST => GetMonoGenericInstClass(klass)
                    .AndThen(GetMonoClassFieldCount),
                _ => MonoOpError.ClassKindNotSupported(classKind)
            });
    }

    protected virtual Result<MonoTypeKind> GetMonoClassClassKind(nuint klass)
    {
        return _memory.Read<uint>(klass + _structs["MonoClass"]["class_kind"])
            .AndThen<MonoTypeKind>(classKindValue => (MonoTypeKind)(classKindValue & _structs["MonoClass"]["class_kind"]));
    }

    protected override Result<nuint> GetMonoGenericInstClass(nuint genericInst)
    {
        return _memory.Read<nuint>(genericInst + _structs["MonoClassGenericInst"]["generic_class"])
            .AndThen(genericClass => _memory.Read<nuint>(genericClass + _structs["MonoGenericClass"]["container_class"]));
    }

    protected override Result<nuint> GetMonoClassNextClassCache(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["MonoClassDef"]["next_class_cache"]);
    }
}
