using AslHelp.Common.Results;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1
{
    public override Result<nuint> GetTypeData(nuint type)
    {
        return GetTypeElementType(type)
            .AndThen<nuint>(elementType => elementType switch
            {
                MonoElementType.Object => _defaults.ObjectClass,
                MonoElementType.Void => _defaults.VoidClass,
                MonoElementType.Boolean => _defaults.BooleanClass,
                MonoElementType.Char => _defaults.CharClass,
                MonoElementType.I1 => _defaults.SByteClass,
                MonoElementType.U1 => _defaults.ByteClass,
                MonoElementType.I2 => _defaults.Int16Class,
                MonoElementType.U2 => _defaults.UInt16Class,
                MonoElementType.I4 => _defaults.Int32Class,
                MonoElementType.U4 => _defaults.UInt32Class,
                MonoElementType.I8 => _defaults.Int64Class,
                MonoElementType.U8 => _defaults.UInt64Class,
                MonoElementType.R4 => _defaults.SingleClass,
                MonoElementType.R8 => _defaults.DoubleClass,
                MonoElementType.String => _defaults.StringClass,
                MonoElementType.I => _defaults.IntPtrClass,
                MonoElementType.U => _defaults.UIntPtrClass,
                MonoElementType.Array => GetMonoTypeData(type).AndThen(GetMonoArrayTypeClass),
                MonoElementType.SzArray => GetMonoTypeData(type),
                MonoElementType.Class or MonoElementType.ValueType => GetMonoTypeData(type),
                MonoElementType.GenericInst => GetMonoTypeData(type).AndThen(GetMonoGenericInstClass),
                MonoElementType.Ptr => GetMonoTypeData(type).AndThen(GetTypeData),
                _ => MonoOpError.ElementType_NotSupported(elementType)
            });
    }

    public override Result<MonoFieldAttribute> GetTypeAttributes(nuint type)
    {
        return _memory.Read<MonoFieldAttribute>(type + _structs["MonoType"]["attrs"]);
    }

    public override Result<MonoElementType> GetTypeElementType(nuint type)
    {
        return _memory.Read<MonoElementType>(type + _structs["MonoType"]["type"]);
    }
}
