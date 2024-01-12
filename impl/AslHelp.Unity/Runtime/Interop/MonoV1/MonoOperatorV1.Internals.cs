namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1
{
    protected virtual bool TryGetGListData(nuint gList, out nuint gListData)
    {
        return _memory.TryRead(out gListData, gList + _structs["GList"]["data"]);
    }

    protected virtual bool TryGetGListNext(nuint gList, out nuint gListNext)
    {
        return _memory.TryRead(out gListNext, gList + _structs["GList"]["next"]);
    }

    protected virtual bool TryGetMonoAssemblyImage(nuint assembly, out nuint image)
    {
        return _memory.TryRead(out image, assembly + _structs["MonoAssembly"]["image"]);
    }

    protected virtual bool TryGetMonoClassFields(nuint klass, out nuint classFields)
    {
        return _memory.TryRead(out classFields, klass + _structs["MonoClass"]["fields"]);
    }

    protected virtual bool TryGetMonoClassFieldCount(nuint klass, out uint fieldCount)
    {
        return _memory.TryRead(out fieldCount, klass + _structs["MonoClass"]["field.count"]);
    }

    protected virtual bool TryGetMonoClassNextClassCache(nuint monoClass, out nuint nextClassCache)
    {
        return _memory.TryRead(out nextClassCache, monoClass + _structs["MonoClass"]["next_class_cache"]);
    }

    protected virtual bool TryGetMonoClassVTable(nuint klass, out nuint vTable)
    {
        vTable = default;

        return _memory.TryRead(out nuint runtimeInfo, klass + _structs["MonoClass"]["runtime_info"])
            && _memory.TryRead(out vTable, runtimeInfo + _structs["MonoClassRuntimeInfo"]["domain_vtables"]);
    }

    protected virtual bool TryGetMonoGenericClassClass(nuint genericClass, out nuint klass)
    {
        return _memory.TryRead(out klass, genericClass + _structs["MonoGenericClass"]["container_class"]);
    }

    protected virtual bool TryGetMonoTypeData(nuint type, out nuint data)
    {
        return _memory.TryRead(out data, type + _structs["MonoType"]["data"]);
    }

    protected virtual bool TryGetMonoArrayTypeClass(nuint arrayType, out nuint klass)
    {
        return _memory.TryRead(out klass, arrayType + _structs["MonoArrayType"]["eklass"]);
    }
}
