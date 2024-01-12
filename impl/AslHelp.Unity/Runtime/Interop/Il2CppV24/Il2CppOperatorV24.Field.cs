using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppOperatorV24
{
    public override IEnumerable<nuint> TryGetFields(nuint klass)
    {
        if (!TryGetIl2CppClassFields(klass, out nuint fields) || fields == 0
            || !TryGetIl2CppClassFieldCount(klass, out ushort fieldCount) || fieldCount == 0)
        {
            Trace.WriteLine($"[asl-help] [Warn] fields: {(ulong)fields:X}");
            yield break;
        }

        for (uint i = 0; i < fieldCount; i++)
        {
            yield return fields + (_structs["FieldInfo"].SelfAlignedSize * i);
        }
    }

    public override bool TryGetFieldName(nuint field, [NotNullWhen(true)] out string? name)
    {
        name = default;

        return _memory.TryRead(out nuint nameStart, field + _structs["FieldInfo"]["name"])
            && _memory.TryReadString(out name, 128, StringType.Ansi, nameStart);
    }

    public override bool TryGetFieldOffset(nuint field, out int offset)
    {
        return _memory.TryRead(out offset, field + _structs["FieldInfo"]["offset"]);
    }

    public override bool TryGetFieldType(nuint field, out nuint type)
    {
        return _memory.TryRead(out type, field + _structs["FieldInfo"]["type"]);
    }
}
