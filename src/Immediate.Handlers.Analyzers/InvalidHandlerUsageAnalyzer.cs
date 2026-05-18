using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class InvalidHandlerUsageAnalyzer : DiagnosticAnalyzer
{
	public static readonly DiagnosticDescriptor SealedHandlerShouldUsedCorrectly =
		new(
			id: DiagnosticIds.IHR0022SealedHandlerShouldUsedCorrectly,
			title: "Non-static handler should not be used directly",
			messageFormat: "Handler type '{0}' should not be used directly; use '{0}.Handler' instead",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Warning,
			isEnabledByDefault: true,
			description: "Non-static handler classes can be used, but usage is probably incorrect. The generated `.Handler` class is probably the intended use."
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
		[
			SealedHandlerShouldUsedCorrectly,
		]);

	public override void Initialize(AnalysisContext context)
	{
		if (context == null)
			throw new ArgumentNullException(nameof(context));

		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterSymbolAction(
			AnalyzeSymbol,
			SymbolKind.NamedType,
			SymbolKind.Parameter,
			SymbolKind.Property,
			SymbolKind.Field,
			SymbolKind.Method
		);
	}

	private void AnalyzeSymbol(SymbolAnalysisContext context)
	{
		if (!IsTargetInvalid(context.Symbol))
			return;

		var location = GetLocation(context.Symbol, context.CancellationToken);

		context.ReportDiagnostic(
			Diagnostic.Create(
				SealedHandlerShouldUsedCorrectly,
				location,
				GetTargetType(context.Symbol)?.ToDisplayString(SymbolDisplayFormat.CSharpShortErrorMessageFormat)
			)
		);
	}

	private static bool IsTargetInvalid(ISymbol symbol)
	{
		return symbol switch
		{
			INamedTypeSymbol
			{
				BaseType: var baseType,
				AllInterfaces: var interfaces,
			} => Enumerable.Any([baseType, .. interfaces], IsInvalid),

			IParameterSymbol { Type: INamedTypeSymbol type } => IsInvalid(type),
			IFieldSymbol { Type: INamedTypeSymbol type } => IsInvalid(type),
			IPropertySymbol { Type: INamedTypeSymbol type } => IsInvalid(type),

			IMethodSymbol
			{
				ReturnType: INamedTypeSymbol type,
				MethodKind: not (MethodKind.PropertyGet or MethodKind.PropertySet),
			} => IsInvalid(type),

			_ => false,
		};
	}

	private static bool IsInvalid(ISymbol? symbol)
	{
		if (symbol is not INamedTypeSymbol { SpecialType: SpecialType.None } typeSymbol)
			return false;

		if (typeSymbol is { IsHandler: true })
			return true;

		if (!typeSymbol.IsGenericType)
			return false;

		if (IsInvalid(typeSymbol.BaseType))
			return true;

		foreach (var argument in typeSymbol.TypeArguments)
		{
			if (IsInvalid(argument))
				return true;
		}

		foreach (var @interface in typeSymbol.Interfaces
			.Where(i => !SymbolEqualityComparer.Default.Equals(i, typeSymbol))
			.Where(i => i is not { TypeArguments: [{ } t] } || !SymbolEqualityComparer.Default.Equals(t, typeSymbol))
		)
		{
			if (IsInvalid(@interface))
				return true;
		}

		return false;
	}

	private static Location? GetLocation(ISymbol symbol, CancellationToken token)
	{
		var syntax = symbol
			.DeclaringSyntaxReferences
			.FirstOrDefault()
			?.GetSyntax(token);

		return (symbol, syntax) switch
		{
			(INamedTypeSymbol, TypeDeclarationSyntax { BaseList: { } baseList }) =>
				baseList.GetLocation(),

			(IFieldSymbol, VariableDeclaratorSyntax { Parent: VariableDeclarationSyntax { Type: { } type } }) =>
				type.GetLocation(),

			(IPropertySymbol, PropertyDeclarationSyntax { Type: { } type }) =>
				type.GetLocation(),

			(IParameterSymbol, ParameterSyntax { Type: { } type }) =>
				type.GetLocation(),

			(IMethodSymbol, MethodDeclarationSyntax { ReturnType: { } type }) =>
				type.GetLocation(),

			_ => syntax?.GetLocation(),
		};
	}

	private static INamedTypeSymbol? GetTargetType(ISymbol symbol)
	{
		return symbol switch
		{
			INamedTypeSymbol ints => ints,
			IParameterSymbol { Type: INamedTypeSymbol type } => type,
			IFieldSymbol { Type: INamedTypeSymbol type } => type,
			IPropertySymbol { Type: INamedTypeSymbol type } => type,

			IMethodSymbol
			{
				ReturnType: INamedTypeSymbol type,
				MethodKind: not (MethodKind.PropertyGet or MethodKind.PropertySet),
			} => type,

			_ => null,
		};
	}
}
