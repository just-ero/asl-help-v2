using System.Collections.Generic;

namespace AslHelp.DotnetDoc.Graphing;

internal record NamedTypeNodeDeclaration(
    IReadOnlyList<DeclarationLocation> Locations,
    string Syntax,
    IReadOnlyList<NamedTypeNode> Extends,
    IReadOnlyList<NamedTypeNode> Derived,
    IReadOnlyList<NamedTypeNode> Implemented) : NodeDeclaration(Locations, Syntax);
