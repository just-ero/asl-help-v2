namespace AslHelp.DotnetDoc.Graphing;

internal record FieldNode(
    string Id,
    string Name,
    NodeDeclaration Declaration,
    NamedTypeNode ReturnType) : MemberNode(Id, Name, Declaration);
