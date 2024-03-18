using System.Collections.Immutable;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace DotnetDoc;

internal static class CSharpSyntax
{
    // public static ImmutableArray<SymbolDisplayPart> TypedConstant(TypedConstant constant)
    // {
    //     switch (constant)
    //     {
    //         case { Kind: TypedConstantKind.Primitive, Value: object value }:
    //         {
    //             string primitive = SymbolDisplay.FormatPrimitive(value, quoteStrings: true, useHexadecimalNumbers: false);
    //             SymbolDisplayPartKind kind = value is string ? SymbolDisplayPartKind.StringLiteral : SymbolDisplayPartKind.NumericLiteral;

    //             return [
    //                 new(kind, null, primitive)
    //             ];
    //         }

    //         case { Kind: TypedConstantKind.Enum, Value: IFieldSymbol field }:
    //         {
    //             return [
    //                 new(SymbolDisplayPartKind.EnumMemberName, field, field.Name)
    //             ];
    //         }
    //     }
    // }
}
