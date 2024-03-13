using System.Collections;
using System.Collections.Immutable;

using DotnetDoc.Format.Abstractions;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace DotnetDoc.Format.CSharp;

internal sealed class AttributeFormatter : ISymbolFormatter<AttributeData>
{
    public static ImmutableArray<SymbolDisplayPart> GetSyntax(AttributeData attribute)
    {
        if (attribute is not { AttributeClass: { } attrClass })
        {
            return [];
        }

        return [
            Syntax.Keyword("["),
            .. SymbolDisplay.ToDisplayParts(attrClass, Syntax.TypeNameFormat), // TODO: Remove `Attribute`?
        ];
    }

    private static IEnumerable GetAttributeArguments(AttributeData attribute)
    {
        if (attribute.ConstructorArguments.Length == 0
            && attribute.NamedArguments.Length == 0)
        {
            yield break;
        }

        yield return Syntax.Keyword("(");

        foreach (var (key, arg) in attribute.NamedArguments)
        {
            yield return Syntax.Keyword(key);
            yield return Syntax.Keyword(",");
            yield return Syntax.Keyword(arg);
        }
    }
}
