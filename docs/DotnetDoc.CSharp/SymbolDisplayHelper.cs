using System.Text;

using Microsoft.CodeAnalysis;

namespace DotnetDoc.CSharp;

internal static class SymbolDisplayHelper
{
    public static string TypeName(ITypeSymbol type)
    {
        if (SpecialTypeName(type.SpecialType) is string specialTypeName)
        {
            return specialTypeName;
        }

        StringBuilder typeName = new();

        typeName.Append(type.ContainingNamespace.Name);
        typeName.Append('.');
        typeName.Append(type.Name);

        if (type is INamedTypeSymbol { TypeArguments: [_, ..] arguments })
        {
            typeName.Append('<');

            for (int i = 0; i < arguments.Length; i++)
            {
                if (i > 0)
                {
                    typeName.Append(", ");
                }

                typeName.Append(TypeName(arguments[i]));
            }

            typeName.Append('>');
        }

        if (type.NullableAnnotation == NullableAnnotation.Annotated)
        {
            typeName.Append('?');
        }

        return typeName.ToString();
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
