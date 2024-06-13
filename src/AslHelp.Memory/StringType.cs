namespace AslHelp.Memory;

/// <summary>
///     Specifies the kind of string to read from memory.
/// </summary>
public enum StringType
{
    /// <summary>
    ///     Automatically detect the string type.
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
