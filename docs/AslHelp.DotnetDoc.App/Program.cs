using System.CommandLine;
using System.Threading.Tasks;

using AslHelp.DotnetDoc.Commands;

namespace AslHelp.DotnetDoc;

public static class Program
{
    private static async Task Main(string[] args)
    {
        await new DocumentationGeneratorCommand().InvokeAsync(args);
    }
}
