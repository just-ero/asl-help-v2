using System.Collections.Generic;

using AslHelp.Common.Results;

namespace AslHelp.Unity.Runtime.Interop;

internal sealed partial class MonoInteropV1 : MonoInterop
{
    private static uint MonoBlobEntryHash(string entry)
    {
        uint hash = 0;

        foreach (char c in entry[1..])
        {
            hash = (hash << 5) - (hash + c);
        }

        return (hash << 5) - hash;
    }

    public override Result<IEnumerable<nuint>> GetClasses(nuint image)
    {
        throw new System.NotImplementedException();
    }

    public override Result<string> GetClassName(nuint klass)
    {
        throw new System.NotImplementedException();
    }

    public override Result<string> GetClassNamespace(nuint klass)
    {
        throw new System.NotImplementedException();
    }

    public override Result<string> GetFieldName(nuint field)
    {
        throw new System.NotImplementedException();
    }

    public override Result<int> GetFieldOffset(nuint field)
    {
        throw new System.NotImplementedException();
    }

    public override Result<IEnumerable<nuint>> GetFields(nuint klass)
    {
        throw new System.NotImplementedException();
    }

    public override Result<nuint> GetFieldType(nuint field)
    {
        throw new System.NotImplementedException();
    }

    public override Result<string> GetImageFileName(nuint image)
    {
        throw new System.NotImplementedException();
    }

    public override Result<string> GetImageName(nuint image)
    {
        return _memory.ReadString(128, Memory.StringType.Ansi, image + )
    }

    public override Result<IEnumerable<nuint>> GetImages()
    {
        return _memory.Read<nuint>(_loadedAssemblies)
            .AndThen();

        IEnumerable<nuint> getImages(nuint assemblies)
        {
            while (assemblies != 0)
            {
                nuint assembly = _memory.Read<nuint>(assemblies);
                assemblies = _memory.Read<nuint>(assemblies + 8);
                yield return assembly;
            }
        }
    }

    public override Result<MonoFieldAttribute> GetTypeAttributes(nuint type)
    {
        throw new System.NotImplementedException();
    }

    public override Result<nuint> GetTypeData(nuint type)
    {
        throw new System.NotImplementedException();
    }

    public override Result<MonoElementType> GetTypeElementType(nuint type)
    {
        throw new System.NotImplementedException();
    }
}
