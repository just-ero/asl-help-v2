using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;

namespace AslHelp.DocumentationGenerator.Commands;

internal sealed class SourceFileCommand : Command
{
    private readonly SourceFileInputArgument _input = new();
    private readonly OutputDirectoryOption _output = new();

    public SourceFileCommand()
        : base("src", "Generate documentation for a .NET source file.")
    {
        AddArgument(_input);
        AddOption(_output);

        this.SetHandler(Handle, _input, _output);
    }

    private void Handle(FileInfo input, DirectoryInfo output)
    {

    }
}

internal sealed class SourceFileInputArgument : Argument<FileInfo>
{
    public SourceFileInputArgument()
        : base("source", "The path to the .NET source file.")
    {
        Arity = ArgumentArity.ExactlyOne;

        AddValidator(Validate);
    }

    private static void Validate(ArgumentResult result)
    {
        if (result.GetValueOrDefault<FileInfo>() is not { Exists: true })
        {
            result.ErrorMessage = "The specified source file does not exist.";
        }
    }
}
