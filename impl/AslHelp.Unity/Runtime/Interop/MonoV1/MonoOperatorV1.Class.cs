using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1
{
    public override IEnumerable<nuint> TryGetClasses(nuint image)
    {
        nuint classCache = image + _structs["MonoImage"]["class_cache"];
        if (!_memory.TryRead(out int size, classCache + _structs["MonoInternalHashTable"]["size"]) || size == 0
            || !_memory.TryRead(out nuint table, classCache + _structs["MonoInternalHashTable"]["table"]) || table == 0)
        {
            yield break;
        }

        nuint[] classes = new nuint[size];
        if (!_memory.TryReadSpan<nuint>(classes, table))
        {
            yield break;
        }

        for (int i = 0; i < classes.Length; i++)
        {
            nuint klass = classes[i];
            while (klass != 0)
            {
                yield return klass;

                if (!TryGetMonoClassNextClassCache(klass, out klass))
                {
                    break;
                }
            }
        }
    }

    public override bool TryGetClassName(nuint klass, [NotNullWhen(true)] out string? name)
    {
        name = default;

        return _memory.TryRead(out nuint nameStart, klass + _structs["MonoClass"]["name"])
            && _memory.TryReadString(out name, 128, StringType.Ansi, nameStart);
    }

    public override bool TryGetClassNamespace(nuint klass, [NotNullWhen(true)] out string? @namespace)
    {
        @namespace = default;

        return _memory.TryRead(out nuint nameSpaceStart, klass + _structs["MonoClass"]["name_space"])
            && _memory.TryReadString(out @namespace, 256, StringType.Ansi, nameSpaceStart);
    }

    public override bool TryGetClassParent(nuint klass, out nuint classParent)
    {
        return _memory.TryRead(out classParent, klass + _structs["MonoClass"]["parent"]);
    }

    public override bool TryGetClassStaticDataChunk(nuint klass, out nuint staticDataChunk)
    {
        staticDataChunk = default;

        return TryGetMonoClassVTable(klass, out nuint vTable)
            && _memory.TryRead(out staticDataChunk, klass + _structs["MonoVTable"]["data"]);
    }
}
