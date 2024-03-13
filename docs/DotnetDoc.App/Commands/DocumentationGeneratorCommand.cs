using System.CommandLine;

namespace DotnetDoc.Commands;

internal sealed class DocumentationGeneratorCommand : RootCommand
{
    public DocumentationGeneratorCommand()
        : base("Generate documentation for .NET projects, source files, and assemblies.")
    {
        AddCommand(new SolutionCommand());
        AddCommand(new ProjectCommand());
        AddCommand(new SourceFileCommand());
        AddCommand(new AssemblyCommand());
    }
}

