using AslHelp.Common.Results.Errors;

namespace AslHelp.Unity;

internal sealed record UnityInitError : ResultError
{
    private UnityInitError(string message)
        : base(message) { }

    public static UnityInitError Other(string message)
    {
        return new(message);
    }

    public static UnityInitError MonoModule_NotFound
        => new("The mono module could not be found.");

    public static UnityInitError VersionMetadata_NotFound
        => new("No version metadata file (globalgamemanagers, mainData, or data.unity3d) could found.");

    public static UnityInitError VersionMetadata_Invalid
        => new("The metadata was in an unexpected format.");

    public static UnityInitError VersionString_Invalid
        => new("The version string could not be parsed.");

    public static UnityInitError Il2CppMetadata_NotFound
        => new("The Il2Cpp metadata could not be found.");
}
