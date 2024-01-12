using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1
{
    public override IEnumerable<nuint> TryGetImages()
    {
        if (!_memory.TryRead(out nuint assemblies, _loadedAssemblies))
        {
            yield break;
        }

        while (assemblies != 0)
        {
            if (TryGetGListData(assemblies, out nuint gListData)
                && TryGetMonoAssemblyImage(gListData, out nuint image))
            {
                yield return image;
            }

            if (!TryGetGListNext(assemblies, out assemblies))
            {
                yield break;
            }
        }
    }

    public override bool TryGetImageName(nuint image, [NotNullWhen(true)] out string? name)
    {
        name = default;

        return _memory.TryRead(out nuint assemblyNameStart, image + _structs["MonoImage"]["assembly_name"])
            && _memory.TryReadString(out name, 256, StringType.Ansi, assemblyNameStart);
    }

    public override bool TryGetImageFileName(nuint image, [NotNullWhen(true)] out string? fileName)
    {
        fileName = default;

        return _memory.TryRead(out nuint nameStart, image + _structs["MonoImage"]["name"])
            && _memory.TryReadString(out fileName, 260, StringType.Ansi, nameStart);
    }
}
