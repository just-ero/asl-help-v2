using AslHelp.Common.Results;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppRuntimeV24
{
    protected virtual Result<nuint> GetIl2CppAssemblyImage(nuint assembly)
    {
        return _memory.Read<nuint>(assembly + _structs["Il2CppAssembly"]["image"]);
    }

    protected virtual Result<int> GetIl2CppImageTypeStart(nuint image)
    {
        return _memory.Read<int>(image + _structs["Il2CppImage"]["typeStart"]);
    }

    protected virtual Result<uint> GetIl2CppImageTypeCount(nuint image)
    {
        return _memory.Read<uint>(image + _structs["Il2CppImage"]["typeCount"]);
    }

    protected virtual Result<nuint> GetIl2CppClassFields(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["Il2CppClass"]["fields"]);
    }

    protected virtual Result<ushort> GetIl2CppClassFieldCount(nuint klass)
    {
        return _memory.Read<ushort>(klass + _structs["Il2CppClass"]["field_count"]);
    }

    protected virtual Result<nuint> GetIl2CppGenericClassClass(nuint genericClass)
    {
        return _memory.Read<nuint>(genericClass + _structs["Il2CppGenericClass"]["cached_class"]);
    }

    protected virtual Result<nuint> GetIl2CppTypeData(nuint type)
    {
        return _memory.Read<nuint>(type + _structs["Il2CppType"]["data"]);
    }
}
