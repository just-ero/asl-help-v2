using System.Collections.Generic;

namespace AslHelp.DotnetDoc.Graphing;

internal record NodeDeclaration(
    IReadOnlyList<DeclarationLocation> Locations,
    string Syntax);
