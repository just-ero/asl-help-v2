using AslHelp.Common.Results.Errors;

namespace AslHelp.Unity.Runtime.Interop;

internal sealed record MonoInitError : ResultError
{
    private MonoInitError(string message)
        : base(message) { }

    public static MonoInitError Other(string message)
    {
        return new(message);
    }

    public static MonoInitError Runtime_IsNot_Supported
        => new("Unsupported runtime version.");

    // Mono
    public static MonoInitError Symbol_MonoGetCorlib_NotFound
        => new("Symbol 'mono_get_corlib' could not be found in the target process.");

    public static MonoInitError MonoDefaults_FailedResolve
        => new("'mono_get_corlib' was found, but 'mono_defaults' instance could not be resolved.");

    public static MonoInitError MonoDefaults_FailedRead
        => new("Failed to read 'mono_defaults' struct.");

    public static MonoInitError Symbol_MonoAssemblyForeach_NotFound
        => new("Symbol 'mono_assembly_foreach' could not be found in the target process.");

    public static MonoInitError LoadedAssemblies_FailedResolve
        => new("'mono_assembly_foreach' was found, but 'loaded_assemblies' instance could not be resolved.");

    // Il2Cpp
    public static MonoInitError Symbol_Il2CppGetCorlib_NotFound
        => new("Symbol 'il2cpp_get_corlib' could not be found in the target process.");

    public static MonoInitError Il2CppDefaults_FailedResolve
        => new("'il2cpp_get_corlib' was found, but 'il2cpp_defaults' instance could not be resolved.");

    public static MonoInitError Il2CppDefaults_FailedRead
        => new("Failed to read 'il2cpp_defaults' struct.");

    public static MonoInitError Symbol_Il2CppDomainGetAssemblies_NotFound
        => new("Symbol 'il2cpp_domain_get_assemblies' could not be found in the target process.");

    public static MonoInitError SAssemblies_FailedResolve
        => new("'il2cpp_domain_get_assemblies' was found, but 's_Assemblies' instance could not be resolved.");

    public static MonoInitError STypeInfoDefinitionTable_FailedResolve
        => new("'s_TypeInfoDefinitionTable' instance could not be resolved.");
}
