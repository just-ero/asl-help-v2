namespace AslHelp.DotnetDoc.Graphing.Abstractions;

internal interface INamedTypeNode : INode
{
    NamedTypeNodeDeclaration Declaration { get; }
}
