using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class InvalidIHandlerAnalyzer : DiagnosticAnalyzer
{
	public static readonly DiagnosticDescriptor IHandlerMissingImplementation =
		new(
			id: DiagnosticIds.IHR0013IHandlerMissingImplementation,
			title: "`IHandler<,>` is missing a concrete implementation",
			messageFormat: "`IHandler<{0},{1}>` is missing a concrete implementation",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Warning,
			isEnabledByDefault: true,
			description: "`IHandler<,>` should only be used in reference to concrete handlers for the parameters."
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
		[
			IHandlerMissingImplementation,
		]);

	public override void Initialize(AnalysisContext context)
	{
		if (context == null)
			throw new ArgumentNullException(nameof(context));

		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterSymbolAction(AnalyzeMethod, SymbolKind.Method);
	}

	private void AnalyzeMethod(SymbolAnalysisContext context)
	{
		if (context.Symbol is not IMethodSymbol methodSymbol)
			return;

		foreach (var parameter in methodSymbol.Parameters)
		{
			var type = parameter.Type as INamedTypeSymbol;
			if (!type.IsIHandler())
				continue;

			if (type.TypeArguments[0].TypeKind is TypeKind.TypeParameter
				|| type.TypeArguments[1].TypeKind is TypeKind.TypeParameter)
			{
				continue;
			}

			var hasConcrete = context.Compilation
				.GetSymbolsWithName("Handler", SymbolFilter.Type, context.CancellationToken)
				.Any(h =>
					h is INamedTypeSymbol handler
					&& SymbolEqualityComparer.Default.Equals(handler.Interfaces.FirstOrDefault(), type)
				);

			if (hasConcrete)
				continue;

			context.ReportDiagnostic(
				Diagnostic.Create(
					IHandlerMissingImplementation,
					parameter.Locations[0],
					type.TypeArguments[0].ToDisplayString(),
					type.TypeArguments[1].ToDisplayString()
				)
			);
		}
	}
}
