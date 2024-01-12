using System.IO;
using System.Reflection;

using AslHelp.Common;

namespace AslHelp.IO;

internal static class EmbeddedResource
{
    public static void Unpack(string resource, string targetFile)
    {
        using Stream source = GetResourceStream(resource);
        using FileStream destination = File.OpenWrite(targetFile);

        source.CopyTo(destination);
    }

    public static Stream GetResourceStream(string resource)
    {
        return GetResourceStreamFromAssembly(Assembly.GetCallingAssembly(), resource);
    }

    public static Stream GetResourceStreamFromAssembly(Assembly assembly, string resource)
    {
        Stream? resourceStream = assembly.GetManifestResourceStream(resource);

        if (resourceStream is null)
        {
            string msg = $"Unable to find the specified resource '{resource}'.";
            ThrowHelper.ThrowFileNotFoundException(msg);
        }

        return resourceStream;
    }
}
