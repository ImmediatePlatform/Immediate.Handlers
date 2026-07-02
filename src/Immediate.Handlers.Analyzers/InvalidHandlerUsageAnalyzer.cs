using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class InvalidHandlerUsageAnalyzer : DiagnosticAnalyzer
{
	public static readonly DiagnosticDescriptor SealedHandlerShouldBeUsedCorrectly =
		new(
			id: DiagnosticIds.IHR0022SealedHandlerShouldBeUsedCorrectly,
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
			SealedHandlerShouldBeUsedCorrectly,
		]);

	public override void Initialize(AnalysisContext context)
	{
		ArgumentNullException.ThrowIfNull(context);

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
		if (GetTargetInvalidSymbol(context.Symbol, context.CancellationToken) is not { } symbol)
			return;

		context.ReportDiagnostic(
			Diagnostic.Create(
				SealedHandlerShouldBeUsedCorrectly,
				symbol.Location,
				symbol.NamedTypeSymbol.ToDisplayString(SymbolDisplayFormat.CSharpShortErrorMessageFormat)
			)
		);
	}

	private record struct InvalidSymbolLocation(Location Location, INamedTypeSymbol NamedTypeSymbol);

	private static InvalidSymbolLocation? GetTargetInvalidSymbol(ISymbol symbol, CancellationToken token)
	{
		token.ThrowIfCancellationRequested();

		return symbol switch
		{
			INamedTypeSymbol
			{
				BaseType: var baseType,
				AllInterfaces: var interfaces,
			} ints when
				Enumerable
					.Select([baseType, .. interfaces], t => GetInvalidSymbol(t, new(SymbolEqualityComparer.Default), token))
					.FirstOrDefault(x => x is { }) is { } invalidSymbol =>
				new(GetTypeIdentifierLocation(ints, token), invalidSymbol),

			IParameterSymbol { Type: INamedTypeSymbol type } ips
				when GetInvalidSymbol(type, new(SymbolEqualityComparer.Default), token) is { } invalidSymbol =>
				new(GetTypeLocation(ips, token), invalidSymbol),

			IFieldSymbol { Type: INamedTypeSymbol type } ifs
				when GetInvalidSymbol(type, new(SymbolEqualityComparer.Default), token) is { } invalidSymbol =>
				new(GetTypeLocation(ifs, token), invalidSymbol),

			IPropertySymbol { Type: INamedTypeSymbol type } ips
				when GetInvalidSymbol(type, new(SymbolEqualityComparer.Default), token) is { } invalidSymbol =>
				new(GetTypeLocation(ips, token), invalidSymbol),

			IMethodSymbol
			{
				ReturnType: INamedTypeSymbol type,
				MethodKind: not (MethodKind.PropertyGet or MethodKind.PropertySet),
			} ims when GetInvalidSymbol(type, new(SymbolEqualityComparer.Default), token) is { } invalidSymbol =>
				new(GetTypeLocation(ims, token), invalidSymbol),

			_ => null,
		};
	}

	private static INamedTypeSymbol? GetInvalidSymbol(ISymbol? symbol, HashSet<INamedTypeSymbol> seen, CancellationToken token)
	{
		token.ThrowIfCancellationRequested();

		if (symbol is not INamedTypeSymbol { SpecialType: SpecialType.None } typeSymbol)
			return null;

		if (!seen.Add(typeSymbol))
			return null;

		if (typeSymbol.IsIEquatable1 || typeSymbol.IsILogger1)
			return null;

		if (typeSymbol is { IsHandler: true })
			return typeSymbol;

		if (!typeSymbol.IsGenericType)
			return null;

		if (GetInvalidSymbol(typeSymbol.BaseType, seen, token) is { } invalidBase)
			return invalidBase;

		foreach (var argument in typeSymbol.TypeArguments)
		{
			if (GetInvalidSymbol(argument, seen, token) is { } invalidArgument)
				return invalidArgument;
		}

		foreach (var @interface in typeSymbol.Interfaces)
		{
			if (GetInvalidSymbol(@interface, seen, token) is { } invalidInterface)
				return invalidInterface;
		}

		return null;
	}

	private static Location GetTypeLocation(ISymbol symbol, CancellationToken token)
	{
		return symbol.DeclaringSyntaxReferences[0].GetSyntax(token) switch
		{
			PropertyDeclarationSyntax { Type: { } type } => type.GetLocation(),

			VariableDeclaratorSyntax { Parent: VariableDeclarationSyntax { Type: { } type } } => type.GetLocation(),

			ParameterSyntax { Type: { } type } => type.GetLocation(),

			MethodDeclarationSyntax { ReturnType: { } type } => type.GetLocation(),

			_ => Location.None,
		};
	}

	private static Location GetTypeIdentifierLocation(INamedTypeSymbol namedTypeSymbol, CancellationToken token)
	{
		foreach (var syntax in namedTypeSymbol.DeclaringSyntaxReferences)
		{
			if (syntax.GetSyntax(token) is not TypeDeclarationSyntax { BaseList: { } } tds)
				continue;

			return tds.Identifier.GetLocation();
		}

		return Location.None;
	}
}
