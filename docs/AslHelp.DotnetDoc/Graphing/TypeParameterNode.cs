using AslHelp.DotnetDoc.Graphing.Abstractions;

namespace AslHelp.DotnetDoc.Graphing;

internal record TypeParameterNode(
    string Id,
    string Name) : INode;
