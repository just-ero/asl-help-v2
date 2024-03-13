using System;

using Microsoft.CodeAnalysis;

namespace DotnetDoc.Syntax;

internal static class DotnetSyntax
{
    public static readonly SymbolDisplayFormat TypeNameFormat = new(
        genericsOptions:
            SymbolDisplayGenericsOptions.IncludeTypeParameters,
        miscellaneousOptions:
            SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
            SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier,
        typeQualificationStyle:
            SymbolDisplayTypeQualificationStyle.NameAndContainingTypes);

    public static SymbolDisplayPart Keyword(string text)
    {
        return new(SymbolDisplayPartKind.Keyword, null, text);
    }

    public static SymbolDisplayPart Punctuation(string text)
    {
        return new(SymbolDisplayPartKind.Punctuation, null, text);
    }

    public static SymbolDisplayPart Space()
    {
        return new(SymbolDisplayPartKind.Space, null, " ");
    }

    public static SymbolDisplayPart LineBreak()
    {
        return new(SymbolDisplayPartKind.LineBreak, null, Environment.NewLine);
    }
}

