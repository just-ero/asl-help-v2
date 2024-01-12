using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1
{
    public override IEnumerable<nuint> TryGetFields(nuint klass)
    {
        if (!TryGetMonoClassFields(klass, out nuint fields) || fields == 0
            || !TryGetMonoClassFieldCount(klass, out uint fieldCount) || fieldCount == 0)
        {
            yield break;
        }

        for (uint i = 0; i < fieldCount; i++)
        {
            yield return fields + (_structs["MonoClassField"].SelfAlignedSize * i);
        }
    }

    public override bool TryGetFieldName(nuint field, [NotNullWhen(true)] out string? name)
    {
        name = default;

        return _memory.TryRead(out nuint nameStart, field + _structs["MonoClassField"]["name"])
            && _memory.TryReadString(out name, 128, StringType.Ansi, nameStart);
    }

    public override bool TryGetFieldOffset(nuint field, out int offset)
    {
        return _memory.TryRead(out offset, field + _structs["MonoClassField"]["offset"]);
    }

    public override bool TryGetFieldType(nuint field, out nuint type)
    {
        return _memory.TryRead(out type, field + _structs["MonoClassField"]["type"]);
    }
}
