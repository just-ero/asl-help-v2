using System.Collections.Immutable;

using Microsoft.CodeAnalysis;

namespace DotnetDoc.Format.Abstractions;

internal interface ISymbolFormatter<in TSymbol>
{
    static abstract ImmutableArray<SymbolDisplayPart> GetSyntax(TSymbol symbol);
}

