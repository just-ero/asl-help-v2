using System;
using System.Threading.Tasks;

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

        Solution solution = await workspace.OpenSolutionAsync(args[0]);
        foreach (var proj in solution.Projects)
        {
            if (await proj.GetCompilationAsync() is { Assembly.GlobalNamespace: { } ns })
            {
                foreach (var sym in ns.GetMembers())
                {
                    if (sym.DeclaredAccessibility == Accessibility.Public)
                    {
                        Console.WriteLine(sym);
                    }
                }
            }
        }
    }
}
