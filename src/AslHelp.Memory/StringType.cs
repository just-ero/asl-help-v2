namespace AslHelp.Memory;

/// <summary>
///     Specifies the kind of string to read from memory.
/// </summary>
/// <remarks>
///     The <see cref="Ipc.IMemoryReader"/> interface uses this enumeration to determine how to read a string from memory.
/// </remarks>
public enum StringType
{
    /// <summary>
    ///     Attempt to automatically determine the string type.
    /// </summary>
    Auto,

    /// <summary>
    ///     Read the string as an ANSI string (8-bit characters).
    /// </summary>
    Ansi,

    /// <summary>
    ///     Read the string as a Unicode string (16-bit characters).
    /// </summary>
    Unicode
}
