using System.Collections.Generic;

using AslHelp.DotnetDoc.Graphing.Abstractions;

namespace AslHelp.DotnetDoc.Graphing;

internal record NamedTypeNode(
    string Id,
    string Name,
    NamedTypeNodeDeclaration Declaration,
    IReadOnlyList<TypeParameterNode> TypeParameters,
    IReadOnlyList<MemberNode> Members,
    IReadOnlyList<NamedTypeNode> NestedTypes) : INamedTypeNode;
