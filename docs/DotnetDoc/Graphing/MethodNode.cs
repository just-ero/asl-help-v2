using System.Collections.Generic;

namespace DotnetDoc.Graphing;

internal record MethodNode(
    string Id,
    string Name,
    NodeDeclaration Declaration,
    IReadOnlyList<TypeParameterNode> TypeParameters,
    IReadOnlyList<ParameterNode> Parameters,
    NamedTypeNode ReturnType) : MemberNode(Id, Name, Declaration);
