using System.Collections.Immutable;
using System.Text;

using Microsoft.CodeAnalysis;

namespace DotnetDoc.CSharp;

public static partial class SymbolDisplay
{
    private static StringBuilder AppendName(this StringBuilder builder, ISymbol symbol)
    {
        if (symbol.ContainingNamespace.Name.Length > 0)
        {
            builder
                .Append(symbol.ContainingNamespace.Name)
                .Append('.');
        }

        builder.Append(symbol.Name);

        if (symbol is ITypeSymbol type)
        {
            if (type is INamedTypeSymbol namedType)
            {
                builder.AppendTypeArguments(namedType.TypeArguments);
            }

            builder.AppendNullableAnnotation(type);
        }

        return builder;
    }

    private static StringBuilder AppendTypeArguments(this StringBuilder builder, ImmutableArray<ITypeSymbol> typeArguments)
    {
        if (typeArguments.Length == 0)
        {
            return builder;
        }

        builder.Append('<');

        for (int i = 0; i < typeArguments.Length; i++)
        {
            if (i > 0)
            {
                builder.Append(", ");
            }

            builder.AppendName(typeArguments[i]);
        }

        return builder.Append('>');
    }

    private static StringBuilder AppendNullableAnnotation(this StringBuilder builder, ITypeSymbol type)
    {
        if (type.NullableAnnotation == NullableAnnotation.Annotated)
        {
            builder.Append('?');
        }

        return builder;
    }

    private static string? SpecialTypeName(SpecialType specialType)
    {
        return specialType switch
        {
            SpecialType.System_Object => "object",
            SpecialType.System_Boolean => "bool",
            SpecialType.System_Char => "char",
            SpecialType.System_SByte => "sbyte",
            SpecialType.System_Byte => "byte",
            SpecialType.System_Int16 => "short",
            SpecialType.System_UInt16 => "ushort",
            SpecialType.System_Int32 => "int",
            SpecialType.System_UInt32 => "uint",
            SpecialType.System_Int64 => "long",
            SpecialType.System_UInt64 => "ulong",
            SpecialType.System_Single => "float",
            SpecialType.System_Double => "double",
            SpecialType.System_String => "string",
            SpecialType.System_IntPtr => "nint",
            SpecialType.System_UIntPtr => "nuint",
            _ => null
        };
    }
}
