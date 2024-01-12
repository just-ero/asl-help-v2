using AslHelp.Common;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppOperatorV24
{
    public override bool TryGetTypeData(nuint type, out nuint data)
    {
        data = default;

        if (!TryGetTypeElementType(type, out MonoElementType elementType))
        {
            return false;
        }

        switch (elementType)
        {
            case MonoElementType.Object:
            {
                data = _defaults.ObjectClass;
                return true;
            }
            case MonoElementType.Void:
            {
                data = _defaults.VoidClass;
                return true;
            }
            case MonoElementType.Boolean:
            {
                data = _defaults.BooleanClass;
                return true;
            }
            case MonoElementType.Char:
            {
                data = _defaults.CharClass;
                return true;
            }
            case MonoElementType.I1:
            {
                data = _defaults.SByteClass;
                return true;
            }
            case MonoElementType.U1:
            {
                data = _defaults.ByteClass;
                return true;
            }
            case MonoElementType.I2:
            {
                data = _defaults.Int16Class;
                return true;
            }
            case MonoElementType.U2:
            {
                data = _defaults.UInt16Class;
                return true;
            }
            case MonoElementType.I4:
            {
                data = _defaults.Int32Class;
                return true;
            }
            case MonoElementType.U4:
            {
                data = _defaults.UInt32Class;
                return true;
            }
            case MonoElementType.I8:
            {
                data = _defaults.Int64Class;
                return true;
            }
            case MonoElementType.U8:
            {
                data = _defaults.UInt64Class;
                return true;
            }
            case MonoElementType.R4:
            {
                data = _defaults.SingleClass;
                return true;
            }
            case MonoElementType.R8:
            {
                data = _defaults.DoubleClass;
                return true;
            }
            case MonoElementType.String:
            {
                data = _defaults.StringClass;
                return true;
            }
            case MonoElementType.I:
            {
                data = _defaults.IntPtrClass;
                return true;
            }
            case MonoElementType.U:
            {
                data = _defaults.UIntPtrClass;
                return true;
            }
            // case MonoElementType.Array:
            // {
            //     return MonoArrayTypeClass(MonoTypeData(type));
            // }
            // case MonoElementType.SzArray:
            // {
            //     return MonoTypeData(type);
            // }
            case MonoElementType.Class:
            case MonoElementType.ValueType:
            {
                if (!TryGetIl2CppTypeData(type, out nuint klassIndex))
                {
                    return false;
                }

                return _memory.TryRead(out nuint typeInfoDefinitionsTable, _typeInfoDefinitions)
                    && _memory.TryRead(out data, typeInfoDefinitionsTable + (_memory.PointerSize * (uint)klassIndex));
            }
            case MonoElementType.GenericInst:
            {
                return TryGetIl2CppTypeData(type, out nuint genericInst)
                    && TryGetIl2CppGenericClassClass(genericInst, out data);
            }
            // case MonoElementType.Ptr:
            // {
            //     return GetTypeClass(MonoTypeData(type));
            // }
        }

        string msg = $"Getting MonoClass for type {elementType} is not implemented.";
        ThrowHelper.ThrowNotImplementedException(msg);

        return false;
    }

    public override bool TryGetTypeAttributes(nuint type, out MonoFieldAttribute attributes)
    {
        return _memory.TryRead(out attributes, type + _structs["Il2CppType"]["attrs"]);
    }

    public override bool TryGetTypeElementType(nuint type, out MonoElementType elementType)
    {
        return _memory.TryRead(out elementType, type + _structs["Il2CppType"]["type"]);
    }
}
