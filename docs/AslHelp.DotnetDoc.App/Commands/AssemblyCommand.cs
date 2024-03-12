using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;

namespace AslHelp.DotnetDoc.Commands;

internal sealed class AssemblyCommand : Command
{
    private readonly AssemblyInputArgument _input = new();
    private readonly OutputDirectoryOption _output = new();

    public AssemblyCommand()
        : base("asm", "Generate documentation for a .NET assembly.")
    {
        AddArgument(_input);
        AddOption(_output);

        this.SetHandler(Handle, _input, _output);
    }

    private void Handle(FileInfo input, DirectoryInfo output)
    {

    }
}

internal sealed class AssemblyInputArgument : Argument<FileInfo>
{
    public AssemblyInputArgument()
        : base("assembly", "The path to the .NET assembly file.")
    {
        Arity = ArgumentArity.ExactlyOne;

        AddValidator(Validate);
    }

    private static void Validate(ArgumentResult result)
    {
        if (result.GetValueOrDefault<FileInfo>() is not { Exists: true })
        {
            result.ErrorMessage = "The specified assembly file does not exist.";
        }
    }
}
