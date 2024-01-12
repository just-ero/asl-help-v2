using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppOperatorV24
{
    public override IEnumerable<nuint> TryGetClasses(nuint image)
    {
        if (!_memory.TryRead(out nuint typeInfos, _typeInfoDefinitions))
        {
            yield break;
        }

        if (!TryGetIl2CppImageTypeStart(image, out int typeStart)
            || !TryGetIl2CppImageTypeCount(image, out uint typeCount))
        {
            yield break;
        }

        nuint[] types = new nuint[typeCount];
        if (!_memory.TryReadSpan<nuint>(types, typeInfos + (_memory.PointerSize * (uint)typeStart)))
        {
            yield break;
        }

        foreach (nuint type in types)
        {
            if (type != 0)
            {
                yield return type;
            }
        }
    }

    public override bool TryGetClassName(nuint klass, [NotNullWhen(true)] out string? name)
    {
        name = default;

        return _memory.TryRead(out nuint nameStart, klass + _structs["Il2CppClass"]["name"])
            && _memory.TryReadString(out name, 128, StringType.Ansi, nameStart);
    }

    public override bool TryGetClassNamespace(nuint klass, [NotNullWhen(true)] out string? @namespace)
    {
        @namespace = default;

        return _memory.TryRead(out nuint namespaceStart, klass + _structs["Il2CppClass"]["namespaze"])
            && _memory.TryReadString(out @namespace, 128, StringType.Ansi, namespaceStart);
    }

    public override bool TryGetClassParent(nuint klass, out nuint parent)
    {
        return _memory.TryRead(out parent, klass + _structs["Il2CppClass"]["parent"]);
    }

    public override bool TryGetClassStaticDataChunk(nuint klass, out nuint staticDataChunk)
    {
        return _memory.TryRead(out staticDataChunk, klass + _structs["Il2CppClass"]["static_fields"]);
    }
}
