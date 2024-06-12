using System.IO;
using System.Reflection;

using AslHelp.Common;

namespace AslHelp.IO;

public static class EmbeddedResource
{
    public static Stream GetResourceStream(string resource)
    {
        return GetResourceStreamFromAssembly(Assembly.GetCallingAssembly(), resource);
    }

    public static Stream GetResourceStreamFromAssembly(Assembly assembly, string resource)
    {
        Stream? resourceStream = assembly.GetManifestResourceStream(resource);
        if (resourceStream is null)
        {
            string msg = $"Could not locate embedded resource '{resource}' in assembly '{assembly.FullName}'.";
            ThrowHelper.ThrowFileNotFoundException(msg);
        }

        return resourceStream;
    }
}
