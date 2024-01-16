using System.Collections.Generic;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1
{
    public override Result<IEnumerable<Result<nuint>>> GetFields(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["MonoClass"]["fields"])
            .AndThen(fields => _memory.Read<uint>(klass + _structs["MonoClass"]["field_count"])
                .AndThen(fieldCount => getFields(fieldCount, fields).AsOk()));

        IEnumerable<Result<nuint>> getFields(uint fieldCount, nuint fields)
        {
            for (uint i = 0; i < fieldCount; i++)
            {
                yield return fields + (_structs["MonoClassField"].SelfAlignedSize * i);
            }
        }
    }

    public override Result<string> GetFieldName(nuint field)
    {
        return _memory.Read<nuint>(field + _structs["MonoClassField"]["name"])
            .AndThen(nameStart => _memory.ReadString(128, StringType.Ansi, nameStart));
    }

    public override Result<int> GetFieldOffset(nuint field)
    {
        return _memory.Read<int>(field + _structs["MonoClassField"]["offset"]);
    }

    public override Result<nuint> GetFieldType(nuint field)
    {
        return _memory.Read<nuint>(field + _structs["MonoClassField"]["type"]);
    }
}
