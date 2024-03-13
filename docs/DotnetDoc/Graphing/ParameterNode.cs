using DotnetDoc.Graphing.Abstractions;

namespace DotnetDoc.Graphing;

internal record ParameterNode(
    string Id,
    string Name,
    NamedTypeNode Type) : INode;
