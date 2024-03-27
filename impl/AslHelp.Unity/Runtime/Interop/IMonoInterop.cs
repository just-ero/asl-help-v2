using System.Collections.Generic;

using AslHelp.Common.Results;

namespace AslHelp.Unity.Runtime.Interop;

public interface IMonoInterop
{
    Result<IEnumerable<nuint>> GetImages();
    Result<string> GetImageName(nuint image);
    Result<string> GetImageFileName(nuint image);

    Result<IEnumerable<nuint>> GetClasses(nuint image);
    Result<string> GetClassName(nuint klass);
    Result<string> GetClassNamespace(nuint klass);

    Result<IEnumerable<nuint>> GetFields(nuint klass);
    Result<string> GetFieldName(nuint field);
    Result<int> GetFieldOffset(nuint field);
    Result<nuint> GetFieldType(nuint field);

    Result<nuint> GetTypeData(nuint type);
    Result<MonoFieldAttribute> GetTypeAttributes(nuint type);
    Result<MonoElementType> GetTypeElementType(nuint type);
}
