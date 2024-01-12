using AslHelp.Common;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV2
{
    protected override bool TryGetMonoClassFieldCount(nuint klass, out uint fieldCount)
    {
        fieldCount = default;

        if (!TryGetMonoClassClassKind(klass, out MonoTypeKind classKind))
        {
            return false;
        }

        switch (classKind)
        {
            case MonoTypeKind.DEF:
            case MonoTypeKind.GTD:
                return _memory.TryRead(out fieldCount, klass + _structs["MonoClassDef"]["field_count"]);
            case MonoTypeKind.GINST:
                return TryGetMonoGenericClassClass(klass, out nuint genericClass)
                    && TryGetMonoClassFieldCount(genericClass, out fieldCount);
        }

        string msg = $"Getting field count for type {nameof(MonoTypeKind)}.{classKind} is not implemented.";
        ThrowHelper.ThrowNotImplementedException(msg);

        return false;
    }

    protected virtual bool TryGetMonoClassClassKind(nuint klass, out MonoTypeKind classKind)
    {
        classKind = default;

        if (!_memory.TryRead(out uint classKindValue, klass + _structs["MonoClass"]["class_kind"]))
        {
            return false;
        }

        classKind = (MonoTypeKind)(classKindValue & _structs["MonoClass"]["class_kind"]);
        return true;
    }

    protected override bool TryGetMonoGenericClassClass(nuint genericInst, out nuint klass)
    {
        klass = default;

        return _memory.TryRead(out nuint genericClass, genericInst + _structs["MonoClassGenericInst"]["generic_class"])
            && _memory.TryRead(out klass, genericClass + _structs["MonoGenericClass"]["container_class"]);
    }

    protected override bool TryGetMonoClassNextClassCache(nuint klass, out nuint nextClassCache)
    {
        return _memory.TryRead(out nextClassCache, klass + _structs["MonoClassDef"]["next_class_cache"]);
    }
}
