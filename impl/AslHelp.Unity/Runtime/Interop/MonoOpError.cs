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

    public static MonoOpError ElementTypeNotSupported(MonoElementType elementType)
    {
        return new($"Getting class for element type '{elementType}' is not supported.");
    }

    public static MonoOpError ClassKindNotSupported(MonoTypeKind classKind)
    {
        return new($"Getting field count for class kind '{classKind}' is not supported.");
    }

    public static MonoOpError ClassNamespaceNull
        => new("Class namespace was null.");
}
