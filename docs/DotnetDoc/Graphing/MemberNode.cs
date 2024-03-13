using DotnetDoc.Graphing.Abstractions;

namespace DotnetDoc.Graphing;

internal abstract record MemberNode(
    string Id,
    string Name,
    NodeDeclaration Declaration) : IMemberNode;
