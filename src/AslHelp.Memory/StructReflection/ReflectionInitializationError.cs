using AslHelp.Common.Results.Errors;

namespace AslHelp.Memory.StructReflection;

internal sealed record ReflectionInitializationError : ResultError
{
    private ReflectionInitializationError(string message)
        : base(message) { }

    public static ReflectionInitializationError Other(string message)
    {
        return new(message);
    }

    // CollectedInput.GetFromEmbeddedResource
    public static ReflectionInitializationError EmbeddedResourceNotFound(string resourceName)
    {
        return new($"Embedded resource '{resourceName}' could not be found.");
    }

    public static ReflectionInitializationError JsonContentsInvalid
        => new("The provided JSON input was not valid.");

    public static ReflectionInitializationError InheritanceOrStructsMustBeProvided
        => new("At least one of 'inheritance' or 'structs' must be provided.");

    // GetTypeSize
    public static ReflectionInitializationError BitfieldTypeMustBeInteger(string type)
    {
        return new($"Bitfield must be an integer type (was '{type}').");
    }

    public static ReflectionInitializationError BitfieldSizeMustBeUnsignedInteger(string type, string size)
    {
        return new($"'{type}': Bitfield size must be an integer between {uint.MinValue} and {uint.MaxValue} (was '{size}').");
    }

    public static ReflectionInitializationError ArrayLengthMustBeUnsignedInteger(string type, string length)
    {
        return new($"'{type}': Array length must be an integer between {uint.MinValue} and {uint.MaxValue} (was '{length}').");
    }

    public static ReflectionInitializationError GenericDefinitionNotFound(string name)
    {
        return new($"Generic definition '{name}' not found. Make sure it is listed before any of its uses in the definition.");
    }
}
