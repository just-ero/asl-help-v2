using System;
using System.Linq;

using Microsoft.CodeAnalysis;

using static DotnetDoc.CSharp.SymbolDisplayHelper;

namespace DotnetDoc.CSharp;

public static class SymbolDisplay
{
    public static string TypedConstant(TypedConstant constant)
    {
        return constant.Kind switch
        {
            TypedConstantKind.Primitive => PrimitiveConstant(constant),
            TypedConstantKind.Enum => EnumConstant(constant),
            TypedConstantKind.Type => TypeConstant(constant),
            TypedConstantKind.Array => ArrayConstant(constant),
            _ => "null",
        };
    }

    private static string PrimitiveConstant(TypedConstant constant)
    {
        if (constant.Kind != TypedConstantKind.Primitive)
        {
            throw new ArgumentException("The constant is not a primitive constant.", nameof(constant));
        }

        if (constant.Value is not object value)
        {
            return "null";
        }

        if (value is string)
        {
            return $"\"{value}\"";
        }
        else
        {
            return $"{value}";
        }
    }

    private static string EnumConstant(TypedConstant constant)
    {
        if (constant.Kind != TypedConstantKind.Enum)
        {
            throw new ArgumentException("The constant is not an enum constant.", nameof(constant));
        }

        if (constant.Value is not IFieldSymbol field)
        {
            return "null";
        }

        string typeName = field.Type.Name;
        string fieldName = field.Name;

        return $"{typeName}.{fieldName}";
    }

    private static string TypeConstant(TypedConstant constant)
    {
        if (constant.Kind != TypedConstantKind.Type)
        {
            throw new ArgumentException("The constant is not a type constant.", nameof(constant));
        }

        if (constant.Value is not ITypeSymbol type)
        {
            return "null";
        }

        return $"typeof({type.Name})";
    }

    private static string ArrayConstant(TypedConstant constant)
    {
        if (constant.Kind != TypedConstantKind.Array)
        {
            throw new ArgumentException("The constant is not an array constant.", nameof(constant));
        }

        if (constant is not { IsNull: false, Type: { } type, Values: [_, ..] values })
        {
            return "null";
        }

        string typeName = TypeName(type);
        string arguments = string.Join(", ", values.Select(TypedConstant));

        return $"new {typeName}[] {{ {arguments} }}";
    }
}
