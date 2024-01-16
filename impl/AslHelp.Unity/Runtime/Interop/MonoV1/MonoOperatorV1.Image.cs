using System.Collections.Generic;

using AslHelp.Common.Extensions;
using AslHelp.Common.Results;
using AslHelp.Memory;

namespace AslHelp.Unity.Runtime.Interop;

internal partial class MonoOperatorV1
{
    public override Result<IEnumerable<Result<nuint>>> GetImages()
    {
        return _memory.Read<nuint>(_loadedAssemblies)
            .AndThen(assemblies => getImages(assemblies).AsOk());

        IEnumerable<Result<nuint>> getImages(nuint assemblies)
        {
            while (assemblies != 0)
            {
                yield return GetGListData(assemblies)
                    .AndThen(GetMonoAssemblyImage);

                assemblies = GetGListNext(assemblies)
                    .UnwrapOrDefault();
            }
        }
    }

    public override Result<string> GetImageName(nuint image)
    {
        return _memory.Read<nuint>(image + _structs["MonoImage"]["assembly_name"])
            .AndThen(nameStart => _memory.ReadString(256, StringType.Ansi, nameStart));
    }

    public override Result<string> GetImageFileName(nuint image)
    {
        return _memory.Read<nuint>(image + _structs["MonoImage"]["name"])
            .AndThen(nameStart => _memory.ReadString(260, StringType.Ansi, nameStart));
    }
}
