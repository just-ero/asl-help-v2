using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace AslHelp.DocumentationGenerator;

public sealed class DotnetDocumentationGenerator
{
    private static MSBuildWorkspace CreateWorkspace()
    {
        MSBuildLocator.RegisterDefaults();
        return MSBuildWorkspace.Create();
    }

    public static async Task GenerateFromSolutionAsync(FileInfo slnInput, DirectoryInfo output)
    {
        MSBuildWorkspace workspace = CreateWorkspace();
        Solution solution = await workspace.OpenSolutionAsync(slnInput.FullName);

        List<AssemblyNode> assemblies = [];

        foreach (Project project in solution.Projects)
        {
            var compilation = await project.GetCompilationAsync();
            if (await project.GetCompilationAsync() is { Assembly: { } assembly })
            {
                var node = CreateAssemblyNode(assembly);
                assemblies.Add(node);
            }
        }

        foreach (var assembly in assemblies)
        {
            System.Console.WriteLine(assembly);
        }
    }

    private static AssemblyNode CreateAssemblyNode(IAssemblySymbol assembly)
    {
        return new(assembly)
        {
            Namespaces = assembly.GlobalNamespace.GetNamespaceMembers().Select(CreateNamespaceNode).ToList(),
            Types = assembly.GlobalNamespace.GetTypeMembers().Select(CreateTypeNode).ToList()
        };
    }

    private static NamespaceNode CreateNamespaceNode(INamespaceSymbol @namespace)
    {
        return new(@namespace)
        {
            Namespaces = @namespace.GetNamespaceMembers().Select(CreateNamespaceNode).ToList(),
            Types = @namespace.GetTypeMembers().Select(CreateTypeNode).ToList()
        };
    }

    private static TypeNode CreateTypeNode(INamedTypeSymbol type)
    {
        return new TypeNode(type);
    }
}

internal sealed class AssemblyNode
{
    public AssemblyNode(IAssemblySymbol assembly)
    {
        Symbol = assembly;
    }

    public IAssemblySymbol Symbol { get; }

    public required IEnumerable<TypeNode> Types { get; init; }
    public required IEnumerable<NamespaceNode> Namespaces { get; init; }

    public string Name => Symbol.MetadataName;

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine($"# {Name}");
        sb.AppendLine();

        foreach (var ns in Namespaces)
        {
            sb.AppendLine(ns.ToString());
        }

        foreach (var type in Types)
        {
            sb.AppendLine(type.ToString());
        }

        return sb.ToString();
    }
}

internal sealed class NamespaceNode
{
    public NamespaceNode(INamespaceSymbol @namespace)
    {
        Symbol = @namespace;
    }

    public INamespaceSymbol Symbol { get; }

    public required IEnumerable<TypeNode> Types { get; init; }
    public required IEnumerable<NamespaceNode> Namespaces { get; init; }

    public string Id => Symbol.MetadataName;
    public string FullName => Symbol.ToDisplayString();

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine($"## {FullName}");
        sb.AppendLine();

        foreach (var ns in Namespaces)
        {
            sb.AppendLine(ns.ToString());
        }

        foreach (var type in Types)
        {
            sb.AppendLine(type.ToString());
        }

        return sb.ToString();
    }
}

internal sealed class TypeNode
{
    public TypeNode(INamedTypeSymbol type)
    {
        Symbol = type;
    }

    public INamedTypeSymbol Symbol { get; }

    public string Name => Symbol.MetadataName;
    public string FullName => Symbol.ToDisplayString();

    public override string ToString()
    {
        StringBuilder sb = new();

        sb.AppendLine($"### {FullName}");
        sb.AppendLine();

        return sb.ToString();
    }
}
