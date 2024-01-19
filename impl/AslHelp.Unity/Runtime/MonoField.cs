using AslHelp.Common.Results;
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

    public Result<string> Name => _mono.GetFieldName(Address)
        .Map(name => name is ['<', .. string propertyName, '>', 'k', '_', '_', 'B', 'a', 'c', 'k', 'i', 'n', 'g', 'F', 'i', 'e', 'l', 'd']
            ? propertyName
            : name);

    public Result<int> Offset => _mono.GetFieldOffset(Address);

    public Result<MonoType> Type => _mono.GetFieldType(Address)
        .AndThen<MonoType>(type => new MonoType(type, _mono));

    public override string ToString()
    {
        return Name
            .AndThen(name => Offset
                .AndThen(offset => Type
                    .AndThen<string>(type => $"0x{offset:X3}: {type} {name}")
                    .Or($"0x{offset:X3}: {name}"))
                .Or(name))
            .Or($"{nameof(MonoField)}@{(ulong)Address:X}")
            .Unwrap();
    }
}
