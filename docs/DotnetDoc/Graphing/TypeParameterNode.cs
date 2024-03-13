using DotnetDoc.Graphing.Abstractions;

namespace DotnetDoc.Graphing;

internal record TypeParameterNode(
    string Id,
    string Name) : INode;
