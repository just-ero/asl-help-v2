using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppOperatorV24
{
    public override IEnumerable<nuint> TryGetImages()
    {
        // il2cpp::vm::s_Assemblies is a std::vector<Il2CppAssembly*>
        if (!_memory.TryRead(out nuint front, _loadedAssemblies + (_memory.PointerSize * 0U))
            || !_memory.TryRead(out nuint back, _loadedAssemblies + (_memory.PointerSize * 1U)))
        {
            yield break;
        }

        int assembliesSize = (int)(back - front) / _memory.PointerSize;
        nuint[] assemblies = new nuint[assembliesSize];
        if (!_memory.TryReadSpan<nuint>(assemblies, front))
        {
            yield break;
        }

        foreach (nuint assembly in assemblies)
        {
            if (TryGetIl2CppAssemblyImage(assembly, out nuint image) && image != 0)
            {
                yield return image;
            }
        }
    }

    public override bool TryGetImageName(nuint image, [NotNullWhen(true)] out string? name)
    {
        name = default;

        return _memory.TryRead(out nuint nameStart, image + _structs["Il2CppImage"]["nameNoExt"])
            && _memory.TryReadString(out name, 256, StringType.Ansi, nameStart);
    }

    public override bool TryGetImageFileName(nuint image, [NotNullWhen(true)] out string? fileName)
    {
        // TODO: Check if this is correct. Might be Il2CppImage.assembly.aname.name?

        fileName = default;

        return _memory.TryRead(out nuint nameStart, image + _structs["Il2CppImage"]["name"])
            && _memory.TryReadString(out fileName, 260, StringType.Ansi, nameStart);
    }
}
