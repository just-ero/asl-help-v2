using AslHelp.DotnetDoc.Graphing.Abstractions;

namespace AslHelp.DotnetDoc.Graphing;

internal abstract record MemberNode(
    string Id,
    string Name,
    NodeDeclaration Declaration) : IMemberNode;
