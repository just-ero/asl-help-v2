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

    public static MonoInitError RuntimeNotSupported
        => new("Unsupported runtime version.");

    // Mono
    public static MonoInitError SymbolMonoGetCorlibNotFound
        => new("Symbol 'mono_get_corlib' could not be found in the target process.");

    public static MonoInitError MonoDefaultsNotResolved
        => new("'mono_get_corlib' was found, but 'mono_defaults' instance could not be resolved.");

    public static MonoInitError MonoDefaultsReadFailed
        => new("Failed to read 'mono_defaults' struct.");

    public static MonoInitError SymbolMonoAssemblyForeachNotFound
        => new("Symbol 'mono_assembly_foreach' could not be found in the target process.");

    public static MonoInitError LoadedAssembliesNotResolved
        => new("'mono_assembly_foreach' was found, but 'loaded_assemblies' instance could not be resolved.");

    // Il2Cpp
    public static MonoInitError SymbolIl2CppGetCorlibNotFound
        => new("Symbol 'il2cpp_get_corlib' could not be found in the target process.");

    public static MonoInitError Il2CppDefaultsNotResolved
        => new("'il2cpp_get_corlib' was found, but 'il2cpp_defaults' instance could not be resolved.");

    public static MonoInitError Il2CppDefaultsReadFailed
        => new("Failed to read 'il2cpp_defaults' struct.");

    public static MonoInitError SymbolIl2CppDomainGetAssembliesNotFound
        => new("Symbol 'il2cpp_domain_get_assemblies' could not be found in the target process.");

    public static MonoInitError SAssembliesNotResolved
        => new("'il2cpp_domain_get_assemblies' was found, but 's_Assemblies' instance could not be resolved.");

    public static MonoInitError STypeInfoDefinitionTableNotResolved
        => new("'s_TypeInfoDefinitionTable' instance could not be resolved.");
}
