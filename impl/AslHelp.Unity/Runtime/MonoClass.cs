using AslHelp.Collections;
using AslHelp.Common.Results;
using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime;

public sealed class MonoClass(
    nuint address,
    MonoOperator mono)
{
    private readonly MonoOperator _mono = mono;

    public nuint Address { get; } = address;

    public Result<string> Name => _mono.GetClassName(Address);
    public Result<string> Namespace => _mono.GetClassNamespace(Address);
    public Result<MonoClass> Parent => _mono.GetClassParent(Address).AndThen<MonoClass>(parent => new MonoClass(parent, _mono));
    public Result<nuint> StaticDataChunk => _mono.GetClassStaticDataChunk(Address);

    public KeyedCollection<string, MonoField> Fields { get; } = new MonoFieldLookup(address, mono);

    public override string ToString()
    {
        return Name
            .AndThen(name => Namespace
                .AndThen<string>(@namespace =>
                {
                    if (!string.IsNullOrEmpty(@namespace))
                    {
                        return $"{@namespace}.{name}";
                    }
                    else
                    {
                        return name;
                    }
                }))
            .UnwrapOr($"{nameof(MonoClass)}@{(ulong)Address:X}");
    }
}
