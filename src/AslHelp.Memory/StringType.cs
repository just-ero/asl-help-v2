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
    ///     Read the string as a UTF-8 string.
    /// </summary>
    Utf8,

    /// <summary>
    ///     Read the string as a UTF-16 string.
    /// </summary>
    Utf16
}
