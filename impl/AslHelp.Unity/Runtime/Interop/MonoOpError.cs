using AslHelp.Common.Results.Errors;

namespace AslHelp.Unity.Runtime.Interop;

internal sealed record MonoOpError : ResultError
{
    private MonoOpError(string message)
        : base(message) { }

    public static MonoOpError Other(string message)
    {
        return new(message);
    }

    public static MonoOpError ElementType_NotSupported(MonoElementType elementType)
    {
        return new($"Getting class for element type '{elementType}' is not supported.");
    }

    public static MonoOpError ClassKind_NotSupported(MonoTypeKind classKind)
    {
        return new($"Getting field count for class kind '{classKind}' is not supported.");
    }

    public static MonoOpError ClassNamespace_Is_Null
        => new("Class namespace was null.");
}
