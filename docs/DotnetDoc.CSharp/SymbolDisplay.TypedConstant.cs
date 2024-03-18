using System;
using System.Collections.Immutable;
using System.Text;

using DotnetDoc.Common;

using Microsoft.CodeAnalysis;

namespace DotnetDoc.CSharp;

public static partial class SymbolDisplay
{
    public static StringBuilder AppendTypedConstant(this StringBuilder builder, TypedConstant constant)
    {
        return constant.Kind switch
        {
            TypedConstantKind.Primitive => builder.AppendPrimitiveConstant(constant),
            TypedConstantKind.Enum => builder.AppendEnumConstant(constant),
            TypedConstantKind.Type => builder.AppendTypeConstant(constant),
            TypedConstantKind.Array => builder.AppendArrayConstant(constant),
            _ => throw new ArgumentOutOfRangeException(nameof(constant), constant, "The constant kind is not supported.")
        };
    }

    public static StringBuilder AppendPrimitiveConstant(this StringBuilder builder, TypedConstant constant)
    {
        if (constant.Kind != TypedConstantKind.Primitive)
        {
            const string Msg = "The constant is not a primitive constant.";
            ThrowHelper.ThrowArgumentException(nameof(constant), Msg);
        }

        if (constant.Value is not object value)
        {
            return builder.Append("null");
        }

        if (value is string)
        {
            return builder
                .Append('"')
                .Append(value)
                .Append('"');
        }
        else
        {
            return builder.Append(value);
        }
    }

    public static StringBuilder AppendEnumConstant(this StringBuilder builder, TypedConstant constant)
    {
        if (constant.Kind != TypedConstantKind.Enum)
        {
            const string Msg = "The constant is not an enum constant.";
            ThrowHelper.ThrowArgumentException(nameof(constant), Msg);
        }

        if (constant.Value is not IFieldSymbol field)
        {
            return builder.Append("null");
        }

        return builder
            .AppendName(field.Type)
            .Append('.')
            .Append(field.Name);
    }

    public static StringBuilder AppendTypeConstant(this StringBuilder builder, TypedConstant constant)
    {
        if (constant.Kind != TypedConstantKind.Type)
        {
            const string Msg = "The constant is not a type constant.";
            ThrowHelper.ThrowArgumentException(nameof(constant), Msg);
        }

        if (constant.Value is not ITypeSymbol type)
        {
            return builder.Append("null");
        }

        return builder
            .Append("typeof(")
            .AppendName(type)
            .Append(')');
    }

    public static StringBuilder AppendArrayConstant(this StringBuilder builder, TypedConstant constant)
    {
        if (constant.Kind != TypedConstantKind.Array)
        {
            throw new ArgumentException("The constant is not an array constant.", nameof(constant));
        }

        if (constant is not { IsNull: false, Type: { } type, Values: [_, ..] values })
        {
            return builder.Append("null");
        }

        return builder
            .Append("new ")
            .AppendName(type)
            .Append("[] { ")
            .AppendArrayConstantArguments(values)
            .Append(" }");
    }

    private static StringBuilder AppendArrayConstantArguments(this StringBuilder builder, ImmutableArray<TypedConstant> values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            if (i > 0)
            {
                builder.Append(", ");
            }

            builder.AppendTypedConstant(values[i]);
        }

        return builder;
    }
}
