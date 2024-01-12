namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppOperatorV24
{
    protected virtual bool TryGetIl2CppAssemblyImage(nuint assembly, out nuint image)
    {
        return _memory.TryRead(out image, assembly + _structs["Il2CppAssembly"]["image"]);
    }

    protected virtual bool TryGetIl2CppImageTypeStart(nuint image, out int typeStart)
    {
        return _memory.TryRead(out typeStart, image + _structs["Il2CppImage"]["typeStart"]);
    }

    protected virtual bool TryGetIl2CppImageTypeCount(nuint image, out uint typeCount)
    {
        return _memory.TryRead(out typeCount, image + _structs["Il2CppImage"]["typeCount"]);
    }

    protected virtual bool TryGetIl2CppClassFields(nuint klass, out nuint fields)
    {
        return _memory.TryRead(out fields, klass + _structs["Il2CppClass"]["fields"]);
    }

    protected virtual bool TryGetIl2CppClassFieldCount(nuint klass, out ushort fieldCount)
    {
        return _memory.TryRead(out fieldCount, klass + _structs["Il2CppClass"]["field_count"]);
    }

    protected virtual bool TryGetIl2CppGenericClassClass(nuint genericClass, out nuint klass)
    {
        return _memory.TryRead(out klass, genericClass + _structs["Il2CppGenericClass"]["cached_class"]);
    }

    protected virtual bool TryGetIl2CppTypeData(nuint type, out nuint data)
    {
        return _memory.TryRead(out data, type + _structs["Il2CppType"]["data"]);
    }
}
