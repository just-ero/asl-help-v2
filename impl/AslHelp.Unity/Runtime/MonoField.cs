using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime;

public sealed class MonoField
{
    private readonly MonoOperator _mono;

    internal MonoField(nuint address, MonoOperator mono)
    {
        Address = address;
        _mono = mono;
    }

    public nuint Address { get; }

    private string? _name;
    public string? Name
    {
        get
        {
            if (_name is null)
            {
                if (_mono.TryGetFieldName(Address, out string? name))
                {
                    _name =
                        name is ['<', .. string propertyName, '>', 'k', '_', '_', 'B', 'a', 'c', 'k', 'i', 'n', 'g', 'F', 'i', 'e', 'l', 'd']
                        ? propertyName
                        : name;
                }
            }

            return _name;
        }
    }

    private int? _offset;
    public int? Offset
    {
        get
        {
            if (_offset is null)
            {
                if (_mono.TryGetFieldOffset(Address, out int offset))
                {
                    _offset = offset;
                }
            }

            return _offset;
        }
    }

    private MonoType? _type;
    public MonoType? Type
    {
        get
        {
            if (_type is null)
            {
                if (_mono.TryGetFieldType(Address, out nuint type))
                {
                    _type = new(type, _mono);
                }
            }

            return _type;
        }
    }

    public override string ToString()
    {
        if (Name is not string name)
        {
            return $"{nameof(MonoField)}@{(ulong)Address:X}";
        }

        if (Type is not MonoType type)
        {
            return name;
        }

        if (Offset is not int offset)
        {
            return $"{type} {name}";
        }

        return $"0x{offset:X3}: {type} {name}";
    }
}
