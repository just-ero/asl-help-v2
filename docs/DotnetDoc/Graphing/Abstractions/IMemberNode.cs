namespace DotnetDoc.Graphing.Abstractions;

internal interface IMemberNode : INode
{
    NodeDeclaration Declaration { get; }
}
