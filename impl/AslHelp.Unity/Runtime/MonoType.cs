using System.Text;

using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime;

public sealed class MonoType(
    nuint address,
    MonoOperator mono)
{
    private readonly MonoOperator _mono = mono;

    public nuint Address { get; } = address;

    private MonoClass? _class;
    public MonoClass? Class
    {
        get
        {
            if (_class is null)
            {
                if (_mono.TryGetTypeData(Address, out nuint data))
                {
                    _class = new(data, _mono);
                }
            }

            return _class;
        }
    }

    private MonoElementType? _elementType;
    public MonoElementType? ElementType
    {
        get
        {
            if (_elementType is null)
            {
                if (_mono.TryGetTypeElementType(Address, out MonoElementType elementType))
                {
                    _elementType = elementType;
                }
            }

            return _elementType;
        }
    }

    private MonoFieldAttribute? _attributes;
    public MonoFieldAttribute? Attributes
    {
        get
        {
            if (_attributes is null)
            {
                if (_mono.TryGetTypeAttributes(Address, out MonoFieldAttribute attributes))
                {
                    _attributes = attributes;
                }
            }

            return _attributes;
        }
    }

    public override string ToString()
    {
        if (Class is not MonoClass klass)
        {
            return $"{nameof(MonoType)}@{(ulong)Address:X}";
        }

        if (Attributes is not MonoFieldAttribute attributes)
        {
            return klass.ToString();
        }

        StringBuilder sb = new();

        sb.Append((attributes & MonoFieldAttribute.FIELD_ACCESS) switch
        {
            MonoFieldAttribute.PRIVATE => "private ",
            MonoFieldAttribute.FAM_AND_ASSEM => "private protected ",
            MonoFieldAttribute.ASSEMBLY => "internal ",
            MonoFieldAttribute.FAMILY => "protected ",
            MonoFieldAttribute.FAM_OR_ASSEM => "protected internal ",
            MonoFieldAttribute.PUBLIC => "public ",
            _ => string.Empty,
        });

        if (hasFlag(MonoFieldAttribute.LITERAL))
        {
            sb.Append("const ");
        }
        else if (hasFlag(MonoFieldAttribute.STATIC))
        {
            sb.Append("static ");
        }

        if (hasFlag(MonoFieldAttribute.INIT_ONLY))
        {
            sb.Append("readonly ");
        }

        sb.Append(klass);

        return sb.ToString();

        bool hasFlag(MonoFieldAttribute flag)
        {
            return (attributes & flag) == flag;
        }
    }
}
