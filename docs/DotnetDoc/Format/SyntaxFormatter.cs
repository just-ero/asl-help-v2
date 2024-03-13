using System.Collections.Immutable;

using Microsoft.CodeAnalysis;

namespace DotnetDoc.Format;

internal abstract partial class SyntaxFormatter
{
    protected SyntaxFormatter(SyntaxLanguage language)
    {
        Language = language;
    }

    public SyntaxLanguage Language { get; }

    public abstract ImmutableArray<SymbolDisplayPart> GetSyntax(ISymbol symbol);
}
