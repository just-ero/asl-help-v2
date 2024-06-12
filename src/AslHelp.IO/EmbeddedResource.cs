using System.IO;
using System.Reflection;

using AslHelp.Common.Results;
using AslHelp.IO.Errors;

namespace AslHelp.IO;

public static class EmbeddedResource
{
    public static Result<Stream> GetResourceStream(string resource)
    {
        return GetResourceStreamFromAssembly(Assembly.GetCallingAssembly(), resource);
    }

    public static Result<Stream> GetResourceStreamFromAssembly(Assembly assembly, string resource)
    {
        Stream? resourceStream = assembly.GetManifestResourceStream(resource);

        if (resourceStream is null)
        {
            return IOError.EmbeddedResourceNotFound(resource);
        }

        return resourceStream;
    }
}
