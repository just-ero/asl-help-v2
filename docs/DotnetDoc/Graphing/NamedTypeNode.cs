using System.Collections.Generic;

using DotnetDoc.Graphing.Abstractions;

namespace DotnetDoc.Graphing;

internal record NamedTypeNode(
    string Id,
    string Name,
    NamedTypeNodeDeclaration Declaration,
    IReadOnlyList<TypeParameterNode> TypeParameters,
    IReadOnlyList<MemberNode> Members,
    IReadOnlyList<NamedTypeNode> NestedTypes) : INamedTypeNode;
