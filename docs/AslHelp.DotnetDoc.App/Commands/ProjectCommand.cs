using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;

namespace AslHelp.DotnetDoc.Commands;

internal sealed class ProjectCommand : Command
{
    private readonly ProjectInputArgument _input = new();
    private readonly OutputDirectoryOption _output = new();

    public ProjectCommand()
        : base("proj", "Generate documentation for a .NET project.")
    {
        AddArgument(_input);
        AddOption(_output);

        this.SetHandler(Handle, _input, _output);
    }

    private void Handle(FileInfo input, DirectoryInfo output)
    {

    }
}

internal sealed class ProjectInputArgument : Argument<FileInfo>
{
    public ProjectInputArgument()
        : base("project", "The path to the .NET project file.")
    {
        Arity = ArgumentArity.ExactlyOne;

        AddValidator(Validate);
    }

    private static void Validate(ArgumentResult result)
    {
        if (result.GetValueOrDefault<FileInfo>() is not { Exists: true })
        {
            result.ErrorMessage = "The specified project file does not exist.";
        }
    }
}
