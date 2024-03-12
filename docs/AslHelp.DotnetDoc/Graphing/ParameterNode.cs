using AslHelp.DotnetDoc.Graphing.Abstractions;

namespace AslHelp.DotnetDoc.Graphing;

internal record ParameterNode(
    string Id,
    string Name,
    NamedTypeNode Type) : INode;
