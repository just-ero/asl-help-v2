using System.CommandLine;
using System.Threading.Tasks;

using AslHelp.DocumentationGenerator.Commands;

namespace AslHelp.DocumentationGenerator;

public static class Program
{
    private static async Task Main(string[] args)
    {
        await new DocumentationGeneratorCommand().InvokeAsync(args);
    }
}
