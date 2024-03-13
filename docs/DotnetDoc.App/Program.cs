using System.CommandLine;
using System.Threading.Tasks;

using DotnetDoc.Commands;

namespace DotnetDoc;

public static class Program
{
    private static async Task Main(string[] args)
    {
        await new DocumentationGeneratorCommand().InvokeAsync(args);
    }
}
