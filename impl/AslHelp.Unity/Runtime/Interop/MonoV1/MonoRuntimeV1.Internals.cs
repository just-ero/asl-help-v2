using AslHelp.Common.Results;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoRuntimeV1
{
    protected virtual Result<nuint> GetGListData(nuint gList)
    {
        return _memory.Read<nuint>(gList + _structs["GList"]["data"]);
    }

    protected virtual Result<nuint> GetGListNext(nuint gList)
    {
        return _memory.Read<nuint>(gList + _structs["GList"]["next"]);
    }

    protected virtual Result<nuint> GetMonoAssemblyImage(nuint assembly)
    {
        return _memory.Read<nuint>(assembly + _structs["MonoAssembly"]["image"]);
    }

    protected virtual Result<nuint> GetMonoClassFields(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["MonoClass"]["fields"]);
    }

    protected virtual Result<uint> GetMonoClassFieldCount(nuint klass)
    {
        return _memory.Read<uint>(klass + _structs["MonoClass"]["field.count"]);
    }

    protected virtual Result<nuint> GetMonoClassNextClassCache(nuint monoClass)
    {
        return _memory.Read<nuint>(monoClass + _structs["MonoClass"]["next_class_cache"]);
    }

    protected virtual Result<nuint> GetMonoClassVTable(nuint klass)
    {
        return
            _memory.Read<nuint>(klass + _structs["MonoClass"]["runtime_info"])
            .AndThen(runtimeInfo => _memory.Read<nuint>(runtimeInfo + _structs["MonoClassRuntimeInfo"]["domain_vtables"]));
    }

    protected virtual Result<nuint> GetMonoGenericInstClass(nuint genericClass)
    {
        return _memory.Read<nuint>(genericClass + _structs["MonoGenericClass"]["container_class"]);
    }

    protected virtual Result<nuint> GetMonoTypeData(nuint type)
    {
        return _memory.Read<nuint>(type + _structs["MonoType"]["data"]);
    }

    protected virtual Result<nuint> GetMonoArrayTypeClass(nuint arrayType)
    {
        return _memory.Read<nuint>(arrayType + _structs["MonoArrayType"]["eklass"]);
    }
}
