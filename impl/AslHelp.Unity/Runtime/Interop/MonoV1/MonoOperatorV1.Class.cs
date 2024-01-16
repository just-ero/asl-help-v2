using System.Collections.Generic;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1
{
    public override Result<IEnumerable<Result<nuint>>> GetClasses(nuint image)
    {
        nuint classCache = image + _structs["MonoImage"]["class_cache"];

        return _memory.Read<int>(classCache + _structs["MonoInternalHashTable"]["size"])
            .AndThen(size => _memory.Read<nuint>(classCache + _structs["MonoInternalHashTable"]["table"])
                .AndThen(table => _memory.ReadSpan<nuint>(size, table)))
            .AndThen(classes => getClasses(classes).AsOk());

        IEnumerable<Result<nuint>> getClasses(nuint[] classes)
        {
            for (int i = 0; i < classes.Length; i++)
            {
                nuint klass = classes[i];
                while (klass != 0)
                {
                    yield return klass;

                    klass = GetMonoClassNextClassCache(klass)
                        .UnwrapOrDefault();
                }
            }
        }
    }

    public override Result<string> GetClassName(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["MonoClass"]["name"])
            .AndThen(nameStart => _memory.ReadString(128, StringType.Ansi, nameStart));
    }

    public override Result<string> GetClassNamespace(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["MonoClass"]["name_space"])
            .AndThen(nameSpaceStart => _memory.ReadString(256, StringType.Ansi, nameSpaceStart));
    }

    public override Result<nuint> GetClassParent(nuint klass)
    {
        return _memory.Read<nuint>(klass + _structs["MonoClass"]["parent"]);
    }

    public override Result<nuint> GetClassStaticDataChunk(nuint klass)
    {
        return GetMonoClassVTable(klass)
            .AndThen(vTable => _memory.Read<nuint>(klass + _structs["MonoVTable"]["data"]));
    }
}
