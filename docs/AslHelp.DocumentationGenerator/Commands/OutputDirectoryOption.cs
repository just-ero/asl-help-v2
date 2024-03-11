using System.CommandLine;
using System.IO;

namespace AslHelp.DocumentationGenerator.Commands;

internal sealed class OutputDirectoryOption : Option<DirectoryInfo>
{
    public OutputDirectoryOption()
        : base(["--output", "-o"], "The directory to output the generated documentation to.")
    {
        Arity = ArgumentArity.ExactlyOne;
        IsRequired = true;
    }
}
