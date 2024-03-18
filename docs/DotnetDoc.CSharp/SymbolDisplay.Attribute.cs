using System.Text;

using DotnetDoc.Common;

using Microsoft.CodeAnalysis;

namespace DotnetDoc.CSharp;

public static partial class SymbolDisplay
{
    public static StringBuilder AppendAttribute(this StringBuilder builder, AttributeData attribute)
    {
        if (attribute.AttributeClass is not INamedTypeSymbol attributeClass)
        {
            const string Msg = "The attribute does not have a class.";
            ThrowHelper.ThrowArgumentException(nameof(attribute), Msg);

            return null;
        }

        return builder
            .Append('[')
            .AppendName(attributeClass)
            .AppendAttributeArguments(attribute)
            .Append(']');
    }

    private static StringBuilder AppendAttributeArguments(this StringBuilder builder, AttributeData attribute)
    {
        if (attribute.ConstructorArguments.Length == 0
            && attribute.NamedArguments.Length == 0)
        {
            return builder;
        }

        builder.Append('(');

        foreach (TypedConstant argument in attribute.ConstructorArguments)
        {
            builder
                .AppendAttributeConstructorArgument(argument)
                .Append(", ");
        }

        foreach ((string propertyName, TypedConstant argument) in attribute.NamedArguments)
        {
            builder
                .AppendAttributeNamedArgument(propertyName, argument)
                .Append(", ");
        }

        builder.Length -= 2;

        return builder.Append(')');
    }

    private static StringBuilder AppendAttributeConstructorArgument(this StringBuilder builder, TypedConstant argument)
    {
        return builder.AppendTypedConstant(argument);
    }

    private static StringBuilder AppendAttributeNamedArgument(this StringBuilder builder, string propertyName, TypedConstant argument)
    {
        return builder
            .Append(propertyName)
            .Append(" = ")
            .AppendTypedConstant(argument);
    }
}
