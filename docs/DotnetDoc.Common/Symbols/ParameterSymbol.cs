using System;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Threading;

using Microsoft.CodeAnalysis;

namespace DotnetDoc.Common.Symbols;

#pragma warning disable RS1009
public sealed class ParameterSymbol : IParameterSymbol
#pragma warning restore RS1009
{
    public required ITypeSymbol Type { get; init; }
    public bool HasExplicitDefaultValue { get; init; } = false;
    public object? ExplicitDefaultValue { get; init; } = null;

    public Accessibility DeclaredAccessibility { get; } = Accessibility.NotApplicable;

    public bool IsParams { get; } = false;
    public bool IsOptional { get; } = false;
    public bool IsThis { get; } = false;
    public bool IsDiscard { get; } = false;

    public bool IsDefinition { get; } = false;
    public bool IsStatic { get; } = false;
    public bool IsVirtual { get; } = false;
    public bool IsOverride { get; } = false;
    public bool IsAbstract { get; } = false;
    public bool IsSealed { get; } = false;
    public bool IsExtern { get; } = false;

    public bool IsImplicitlyDeclared { get; } = false;
    public bool CanBeReferencedByName { get; } = false;

    public bool HasUnsupportedMetadata { get; } = false;

    public int Ordinal { get; } = 0;

    public SymbolKind Kind { get; } = SymbolKind.Parameter;

    public string Language { get; } = "C#";
    public string Name => throw new NotImplementedException();

    public string MetadataName => throw new NotImplementedException();
    public int MetadataToken => throw new NotImplementedException();

    public NullableAnnotation NullableAnnotation { get; } = NullableAnnotation.None;

    public RefKind RefKind { get; } = RefKind.None;
    public ScopedKind ScopedKind { get; } = ScopedKind.None;

    public ImmutableArray<CustomModifier> CustomModifiers { get; } = [];
    public ImmutableArray<CustomModifier> RefCustomModifiers { get; } = [];

    public ImmutableArray<Location> Locations { get; } = [];
    public ImmutableArray<SyntaxReference> DeclaringSyntaxReferences { get; } = [];

    public IParameterSymbol OriginalDefinition => throw new NotImplementedException();
    ISymbol ISymbol.OriginalDefinition => throw new NotImplementedException();

    public ISymbol ContainingSymbol => throw new NotImplementedException();
    public IAssemblySymbol ContainingAssembly => throw new NotImplementedException();
    public IModuleSymbol ContainingModule => throw new NotImplementedException();
    public INamedTypeSymbol ContainingType => throw new NotImplementedException();
    public INamespaceSymbol ContainingNamespace => throw new NotImplementedException();

    public void Accept(SymbolVisitor visitor)
    {
        throw new NotImplementedException();
    }

    public TResult? Accept<TResult>(SymbolVisitor<TResult> visitor)
    {
        return visitor.VisitParameter(this);
    }

    public TResult Accept<TArgument, TResult>(SymbolVisitor<TArgument, TResult> visitor, TArgument argument)
    {
        return visitor.VisitParameter(this, argument);
    }

    public bool Equals([NotNullWhen(true)] ISymbol? other, SymbolEqualityComparer equalityComparer)
    {
        throw new NotImplementedException();
    }

    public bool Equals(ISymbol? other)
    {
        throw new NotImplementedException();
    }

    public ImmutableArray<AttributeData> GetAttributes()
    {
        throw new NotImplementedException();
    }

    public string? GetDocumentationCommentId()
    {
        throw new NotImplementedException();
    }

    public string? GetDocumentationCommentXml(CultureInfo? preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ImmutableArray<SymbolDisplayPart> ToDisplayParts(SymbolDisplayFormat? format = null)
    {
        throw new NotImplementedException();
    }

    public string ToDisplayString(SymbolDisplayFormat? format = null)
    {
        throw new NotImplementedException();
    }

    public ImmutableArray<SymbolDisplayPart> ToMinimalDisplayParts(SemanticModel semanticModel, int position, SymbolDisplayFormat? format = null)
    {
        throw new NotImplementedException();
    }

    public string ToMinimalDisplayString(SemanticModel semanticModel, int position, SymbolDisplayFormat? format = null)
    {
        throw new NotImplementedException();
    }
}
