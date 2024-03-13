using System.Collections.Generic;

using DotnetDoc.Graphing.Abstractions;

namespace DotnetDoc.Graphing;

internal record NamespaceNode(
    string Id,
    string Name,
    IReadOnlyList<NamespaceNode> Namespaces,
    IReadOnlyList<NamedTypeNode> Types) : INode;

