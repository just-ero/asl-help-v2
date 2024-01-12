using AslHelp.Collections;
using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime;

public sealed class MonoClass(
    nuint address,
    MonoOperator mono)
{
    private readonly MonoOperator _mono = mono;

    public nuint Address { get; } = address;

    private string? _name;
    public string? Name
    {
        get
        {
            if (_name is null)
            {
                if (_mono.TryGetClassName(Address, out string? name))
                {
                    _name = name;
                }
            }

            return _name;
        }
    }

    private string? _namespace;
    public string? Namespace
    {
        get
        {
            if (_namespace is null)
            {
                if (_mono.TryGetClassNamespace(Address, out string? @namespace))
                {
                    _namespace = @namespace;
                }
            }

            return _namespace;
        }
    }

    private MonoClass? _parent;
    public MonoClass? Parent
    {
        get
        {
            if (_parent is null)
            {
                if (_mono.TryGetClassParent(Address, out nuint parent) && parent != 0)
                {
                    _parent = new(parent, _mono);
                }
            }

            return _parent;
        }
    }

    private nuint? _staticDataChunk;
    public nuint? StaticDataChunk
    {
        get
        {
            if (_staticDataChunk is null)
            {
                if (_mono.TryGetClassStaticDataChunk(Address, out nuint staticDataChunk))
                {
                    _staticDataChunk = staticDataChunk;
                }
            }

            return _staticDataChunk;
        }
    }

    public KeyedCollection<string, MonoField> Fields { get; } = new MonoFieldLookup(address, mono);

    public override string ToString()
    {
        if (Name is not string name)
        {
            return $"{nameof(MonoClass)}@{(ulong)Address:X}";
        }

        if (Namespace is not { Length: > 0 } @namespace)
        {
            return name;
        }

        return $"{@namespace}.{name}";
    }
}
