namespace AslHelp.Unity.Runtime.Interop;

internal enum MonoTypeKind : uint
{
    INVALID,

    DEF,
    GTD,
    GINST,
    GPARAM,
    ARRAY,
    POINTER
}
