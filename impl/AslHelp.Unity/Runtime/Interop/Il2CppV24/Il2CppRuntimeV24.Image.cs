using System.Collections.Generic;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class Il2CppRuntimeV24
{
    public override Result<IEnumerable<Result<nuint>>> GetImages()
    {
        return _memory.Read<nuint>(_loadedAssemblies + (_memory.PointerSize * 0U))
            .AndThen(front => _memory.Read<nuint>(_loadedAssemblies + (_memory.PointerSize * 1U))
                .AndThen(back => _memory.ReadSpan<nuint>((int)(back - front) / _memory.PointerSize, front)))
            .AndThen(assemblies => getImages(assemblies).AsOk());

        IEnumerable<Result<nuint>> getImages(nuint[] assemblies)
        {
            foreach (nuint assembly in assemblies)
            {
                if (assembly != 0)
                {
                    yield return GetIl2CppAssemblyImage(assembly);
                }
            }
        }
    }

    public override Result<string> GetImageName(nuint image)
    {
        return _memory.Read<nuint>(image + _structs["Il2CppImage"]["nameNoExt"])
            .AndThen(nameStart => _memory.ReadString(256, StringType.Ansi, nameStart));
    }

    public override Result<string> GetImageFileName(nuint image)
    {
        // TODO: Check if this is correct. Might be Il2CppImage.assembly.aname.name?

        return _memory.Read<nuint>(image + _structs["Il2CppImage"]["name"])
            .AndThen(nameStart => _memory.ReadString(260, StringType.Ansi, nameStart));
    }
}
