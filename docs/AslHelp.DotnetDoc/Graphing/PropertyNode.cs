namespace AslHelp.DotnetDoc.Graphing;

internal record PropertyNode(
    string Id,
    string Name,
    NodeDeclaration Declaration,
    NamedTypeNode ReturnType,
    MethodNode? Get,
    MethodNode? Set) : MemberNode(Id, Name, Declaration);
