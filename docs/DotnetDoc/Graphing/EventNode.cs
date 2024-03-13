namespace DotnetDoc.Graphing;

internal record EventNode(
    string Id,
    string Name,
    NodeDeclaration Declaration,
    NamedTypeNode ReturnType,
    MethodNode? Add,
    MethodNode? Remove) : MemberNode(Id, Name, Declaration);
