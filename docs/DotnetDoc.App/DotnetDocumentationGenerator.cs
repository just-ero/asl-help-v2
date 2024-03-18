using System.IO;
using System.Threading.Tasks;

using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace DotnetDoc;

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

        foreach (Project project in solution.Projects)
        {
            var compilation = await project.GetCompilationAsync();
            if (await project.GetCompilationAsync() is { Assembly: { } assembly })
            {
                // var node = assembly.GlobalNamespace.AsNode();

                // System.Console.WriteLine(JsonSerializer.Serialize(node, new JsonSerializerOptions()
                // {
                //     WriteIndented = true
                // }));
            }
        }
    }
}
