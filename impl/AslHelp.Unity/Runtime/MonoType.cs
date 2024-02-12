using System;
using System.Text;

using AslHelp.Common.Results;
using AslHelp.Unity.Runtime.Interop;

namespace AslHelp.Unity.Runtime;

public sealed class MonoType(
    nuint address,
    MonoRuntime mono)
{
    private readonly MonoRuntime _mono = mono;

    public nuint Address { get; } = address;

    public Result<MonoClass> Class => _mono.GetTypeData(Address).AndThen<MonoClass>(data => new MonoClass(data, _mono));
    public Result<MonoElementType> ElementType => _mono.GetTypeElementType(Address);
    public Result<MonoFieldAttribute> Attributes => _mono.GetTypeAttributes(Address);

    public override string ToString()
    {
        return Class
            .AndThen(klass => Attributes
                .AndThen<string>(attr =>
                {
                    StringBuilder sb = new();

                    sb.Append((attr & MonoFieldAttribute.FIELD_ACCESS) switch
                    {
                        MonoFieldAttribute.PRIVATE => "private ",
                        MonoFieldAttribute.FAM_AND_ASSEM => "private protected ",
                        MonoFieldAttribute.ASSEMBLY => "internal ",
                        MonoFieldAttribute.FAMILY => "protected ",
                        MonoFieldAttribute.FAM_OR_ASSEM => "protected internal ",
                        MonoFieldAttribute.PUBLIC => "public ",
                        _ => ""
                    });

                    if (attr.HasFlag(MonoFieldAttribute.LITERAL))
                    {
                        sb.Append("const ");
                    }
                    else if (attr.HasFlag(MonoFieldAttribute.STATIC))
                    {
                        sb.Append("static ");
                    }

                    if (attr.HasFlag(MonoFieldAttribute.INIT_ONLY))
                    {
                        sb.Append("readonly ");
                    }

                    sb.Append(klass);

                    return sb.ToString();
                })
                .Or(klass.ToString())
            .Or($"{nameof(MonoType)}@{(ulong)Address:X}"))
            .Unwrap();
    }
}
