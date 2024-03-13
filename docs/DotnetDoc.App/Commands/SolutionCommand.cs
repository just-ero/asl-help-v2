using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;
using System.Threading.Tasks;

namespace DotnetDoc.Commands;

internal sealed class SolutionCommand : Command
{
    private readonly SolutionInputArgument _input = new();
    private readonly OutputDirectoryOption _output = new();

    public SolutionCommand()
        : base("sln", "Generate documentation for all .NET projects in a provided solution.")
    {
        AddArgument(_input);
        AddOption(_output);

        this.SetHandler(Handle, _input, _output);
    }

    private async Task Handle(FileInfo input, DirectoryInfo output)
    {
        await DotnetDocumentationGenerator.GenerateFromSolutionAsync(input, output);
    }
}

internal sealed class SolutionInputArgument : Argument<FileInfo>
{
    public SolutionInputArgument()
        : base("solution", "The path to the .NET solution file.")
    {
        Arity = ArgumentArity.ExactlyOne;

        AddValidator(Validate);
    }

    private static void Validate(ArgumentResult result)
    {
        if (result.GetValueOrDefault<FileInfo>() is not { Exists: true })
        {
            result.ErrorMessage = "The specified solution file does not exist.";
        }
    }
}
