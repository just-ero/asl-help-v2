using System.Collections.Generic;

namespace DotnetDoc.Graphing;

internal record NodeDeclaration(
    IReadOnlyList<DeclarationLocation> Locations,
    string Syntax);
