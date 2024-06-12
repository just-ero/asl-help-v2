using AslHelp.Common.Results.Errors;

namespace AslHelp.IO.Errors;

internal sealed record IOError : ResultError
{
    private IOError(string message)
        : base(message) { }

    public static IOError Other(string message)
    {
        return new(message);
    }

    public static IOError EmbeddedResourceNotFound(string resource)
    {
        return new($"Unable to find the specified resource '{resource}'.");
    }
}
