using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using AslHelp.DocumentationGenerator.Extensions;

using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace AslHelp.DocumentationGenerator;

public static class Program
{
    private static async Task Main(string[] args)
    {
        MSBuildLocator.RegisterDefaults();

        using var workspace = MSBuildWorkspace.Create();
        workspace.WorkspaceFailed += (o, e) => Console.WriteLine(e.Diagnostic.Message);

        var solution = await workspace.OpenSolutionAsync(args[0]);

        var projectCompilations = new HashSet<Compilation>();
        var assemblies = new List<(IAssemblySymbol Symbol, Compilation Compilation)>();

        foreach (var project in solution.Projects)
        {
            var compilation = await project.GetCompilationAsync();
            if (compilation is not null)
            {
                if (projectCompilations.Add(compilation))
                {
                    var assembly = compilation.Assembly;
                    assemblies.Add((assembly, compilation));
                }
            }
        }

        var nodes = new List<Node>();

        foreach (var (assembly, compilation) in assemblies)
        {
            var symbol = assembly.GlobalNamespace;

            switch (symbol)
            {
                case INamespaceSymbol ns when ns.IsGlobalNamespace:
                {
                    foreach (var child in ns.GetNamespaceMembers())
                    {
                        foreach (var item in )
                    }
                }
            }
        }
    }

    private static IEnumerable<Node> CreateNodes(ISymbol sym, Compilation compilation)
    {
        switch (sym)
        {
            case INamespaceSymbol ns when ns.IsGlobalNamespace:
                foreach (var child in ns.GetNamespaceMembers())
                {
                    foreach (var item in CreateNodes(child, compilation))
                    {
                        yield return item;
                    }
                }

                break;

            case INamespaceSymbol ns:
                foreach (var item in CreateNamespaceNode(ns))
                {
                    yield return item;
                }

                break;
        }
    }

    private static IEnumerable<Node> CreateNamespaceNode(INamespaceSymbol ns)
    {
        var idExists = true;
        var
    }
}

internal record Node(
    string Name,
    string? Href,
    List<Node>? Items,
    NodeType Type,
    string? Id,
    bool ContainsLeafNodes,
    List<(ISymbol Symbol, Compilation Compilation)>? Symbols);

internal enum NodeType
{
    None,
    Namespace,
    Class,
    Struct,
    Interface,
    Enum,
    Delegate,
    Constructor,
    Field,
    Property,
    Method,
    Event,
    Operator
}
