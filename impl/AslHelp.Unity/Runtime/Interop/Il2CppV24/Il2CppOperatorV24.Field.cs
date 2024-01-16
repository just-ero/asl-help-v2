using System.Collections.Generic;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppOperatorV24
{
    public override Result<IEnumerable<Result<nuint>>> GetFields(nuint klass)
    {
        return GetIl2CppClassFields(klass)
            .AndThen(fields => GetIl2CppClassFieldCount(klass)
                .AndThen(fieldCount => getFields(fieldCount, fields).AsOk()));

        IEnumerable<Result<nuint>> getFields(int fieldCount, nuint fields)
        {
            for (uint i = 0; i < fieldCount; i++)
            {
                yield return _memory.Read<nuint>(fields + (_structs["FieldInfo"].SelfAlignedSize * i));
            }
        }
    }

    public override Result<string> GetFieldName(nuint field)
    {
        return _memory.Read<nuint>(field + _structs["FieldInfo"]["name"])
            .AndThen(nameStart => _memory.ReadString(128, StringType.Ansi, nameStart));
    }

    public override Result<int> GetFieldOffset(nuint field)
    {
        return _memory.Read<int>(field + _structs["FieldInfo"]["offset"]);
    }

    public override Result<nuint> GetFieldType(nuint field)
    {
        return _memory.Read<nuint>(field + _structs["FieldInfo"]["type"]);
    }
}
