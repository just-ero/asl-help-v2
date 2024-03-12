using System.Collections.Immutable;

using Microsoft.CodeAnalysis;

namespace AslHelp.DotnetDoc.Formatting;

internal sealed class SyntaxFormatter
{
    private static readonly SymbolDisplayFormat _format = new(
        typeQualificationStyle:
            SymbolDisplayTypeQualificationStyle.NameAndContainingTypes,
        genericsOptions:
            SymbolDisplayGenericsOptions.IncludeTypeParameters |
            SymbolDisplayGenericsOptions.IncludeTypeConstraints |
            SymbolDisplayGenericsOptions.IncludeVariance,
        memberOptions:
            SymbolDisplayMemberOptions.IncludeType |
            SymbolDisplayMemberOptions.IncludeModifiers |
            SymbolDisplayMemberOptions.IncludeExplicitInterface |
            SymbolDisplayMemberOptions.IncludeParameters |
            SymbolDisplayMemberOptions.IncludeConstantValue |
            SymbolDisplayMemberOptions.IncludeRef,
        delegateStyle:
            SymbolDisplayDelegateStyle.NameAndSignature,
        extensionMethodStyle:
            SymbolDisplayExtensionMethodStyle.StaticMethod,
        parameterOptions:
            SymbolDisplayParameterOptions.IncludeExtensionThis |
            SymbolDisplayParameterOptions.IncludeParamsRefOut |
            SymbolDisplayParameterOptions.IncludeType |
            SymbolDisplayParameterOptions.IncludeName |
            SymbolDisplayParameterOptions.IncludeDefaultValue,
        propertyStyle:
            SymbolDisplayPropertyStyle.ShowReadWriteDescriptor,
        localOptions:
            SymbolDisplayLocalOptions.IncludeType,
        kindOptions:
            SymbolDisplayKindOptions.IncludeNamespaceKeyword |
            SymbolDisplayKindOptions.IncludeTypeKeyword |
            SymbolDisplayKindOptions.IncludeMemberKeyword,
        miscellaneousOptions:
            SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
            SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
            SymbolDisplayMiscellaneousOptions.RemoveAttributeSuffix |
            SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier |
            SymbolDisplayMiscellaneousOptions.AllowDefaultLiteral);

    private static readonly SymbolDisplayFormat _syntaxTypeNameFormat = new(
        genericsOptions:
            SymbolDisplayGenericsOptions.IncludeTypeParameters,
        miscellaneousOptions:
            SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
            SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier,
        typeQualificationStyle:
            SymbolDisplayTypeQualificationStyle.NameAndContainingTypes);

    private static readonly SymbolDisplayFormat _syntaxEnumConstantFormat = _format
        .WithMemberOptions(_format.MemberOptions | SymbolDisplayMemberOptions.IncludeContainingType);

    public SyntaxLanguage Language { get; }
    public SymbolFilter Filter { get; }

    public ImmutableArray<SymbolDisplayPart> GetSyntax(ISymbol symbol)
    {

    }
}
