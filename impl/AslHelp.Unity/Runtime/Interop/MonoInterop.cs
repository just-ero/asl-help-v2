using System.Collections.Generic;

using AslHelp.Common.Results;
using AslHelp.Memory.Ipc;

namespace AslHelp.Unity.Runtime.Interop;

internal abstract class MonoInterop : IMonoInterop
{
    protected readonly IProcessMemory _memory;

    public abstract Result<IEnumerable<nuint>> GetClasses(nuint image);
    public abstract Result<string> GetClassName(nuint klass);
    public abstract Result<string> GetClassNamespace(nuint klass);
    public abstract Result<string> GetFieldName(nuint field);
    public abstract Result<int> GetFieldOffset(nuint field);
    public abstract Result<IEnumerable<nuint>> GetFields(nuint klass);
    public abstract Result<nuint> GetFieldType(nuint field);
    public abstract Result<string> GetImageFileName(nuint image);
    public abstract Result<string> GetImageName(nuint image);
    public abstract Result<IEnumerable<nuint>> GetImages();
    public abstract Result<MonoFieldAttribute> GetTypeAttributes(nuint type);
    public abstract Result<nuint> GetTypeData(nuint type);
    public abstract Result<MonoElementType> GetTypeElementType(nuint type);
}
