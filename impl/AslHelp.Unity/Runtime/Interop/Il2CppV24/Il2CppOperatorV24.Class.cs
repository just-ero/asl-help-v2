using System.Collections.Generic;
using System.Linq;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppOperatorV24
{
    public override Result<IEnumerable<Result<nuint>>> GetClasses(nuint image)
    {
        return GetIl2CppImageTypeStart(image)
            .AndThen(typeStart => GetIl2CppImageTypeCount(image)
                .Map(typeCount => (typeStart, typeCount)))
            .AndThen(r =>
            {
                (int typeStart, uint typeCount) = r;

                return _memory.Read<nuint>(_typeInfoDefinitions)
                    .AndThen(typeInfos => _memory.ReadSpan<nuint>((int)typeCount, typeInfos + (_memory.PointerSize * (uint)typeStart)));
            })
            .AndThen(types => types.Where(t => t != 0).Select(t => t.AsOk()).AsOk());
    }

    public override Result<string> GetClassName(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["Il2CppClass"]["name"])
            .AndThen(nameStart => _memory.ReadString(128, StringType.Ansi, nameStart));
    }

    public override Result<string> GetClassNamespace(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["Il2CppClass"]["namespaze"])
            .AndThen(namespaceStart => _memory.ReadString(128, StringType.Ansi, namespaceStart));
    }

    public override Result<nuint> GetClassParent(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["Il2CppClass"]["parent"]);
    }

    public override Result<nuint> GetClassStaticDataChunk(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["Il2CppClass"]["static_fields"]);
    }
}
