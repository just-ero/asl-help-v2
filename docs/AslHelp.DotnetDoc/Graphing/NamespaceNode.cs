using System.Collections.Generic;

using AslHelp.DotnetDoc.Graphing.Abstractions;

namespace AslHelp.DotnetDoc.Graphing;

internal record NamespaceNode(
    string Id,
    string Name,
    IReadOnlyList<NamespaceNode> Namespaces,
    IReadOnlyList<NamedTypeNode> Types) : INode;

