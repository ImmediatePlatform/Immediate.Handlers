using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class HandlerClassAnalyzer : DiagnosticAnalyzer
{
	private static readonly DiagnosticDescriptor HandlerMethodMustExist =
		new(
			id: DiagnosticIds.IHR0001HandlerMethodMustExist,
			title: "Handler type should implement a Handle/HandleAsync method",
			messageFormat: "Handler type '{0}' should implement a Handle/HandleAsync method",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Classes annotated with a Handler attribute should implement a Handle/HandleAsync method."
		);

	private static readonly DiagnosticDescriptor HandlerMethodMustReturnTask =
		new(
			id: DiagnosticIds.IHR0002HandlerMethodMustReturnTask,
			title: "Handler method must return a ValueTask<T>",
			messageFormat: "Method '{0}' must return a ValueTask<T>",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Handler methods must return a ValueTask<T>."
		);

	private static readonly DiagnosticDescriptor HandlerMustNotBeNestedInAnotherClass =
		new(
			id: DiagnosticIds.IHR0005HandlerClassMustNotBeNested,
			title: "Handler nesting is not allowed",
			messageFormat: "Handler '{0}' must not be nested in another type",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Handler class must not be nested in another type."
		);

	private static readonly DiagnosticDescriptor HandlerMethodMustBeStatic =
		new(
			id: DiagnosticIds.IHR0009HandlerMethodMustBeStatic,
			title: "Handler method must be static",
			messageFormat: "Method '{0}' must be static",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Handler method must be static."
		);

	private static readonly DiagnosticDescriptor HandlerMethodMustBeUnique =
		new(
			id: DiagnosticIds.IHR0010HandlerMethodMustBeUnique,
			title: "Handler method must be unique",
			messageFormat: "Method '{0}' must not conflict with another static handler method",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Static handler method must be static."
		);

	private static readonly DiagnosticDescriptor HandlerMethodMustBePrivate =
		new(
			id: DiagnosticIds.IHR0011HandlerMethodMustBePrivate,
			title: "Handler method must be private",
			messageFormat: "Method '{0}' must be set to private",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Static handler method must be static."
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
		[
			HandlerMethodMustExist,
			HandlerMethodMustReturnTask,
			HandlerMustNotBeNestedInAnotherClass,
			HandlerMethodMustBeStatic,
			HandlerMethodMustBeUnique,
			HandlerMethodMustBePrivate,
		]);

	public override void Initialize(AnalysisContext context)
	{
		if (context == null)
			throw new ArgumentNullException(nameof(context));

		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterSymbolAction(AnalyzeSymbol, SymbolKind.NamedType);
	}

	private static void AnalyzeSymbol(SymbolAnalysisContext context)
	{
		var token = context.CancellationToken;
		token.ThrowIfCancellationRequested();

		if (context.Symbol is not INamedTypeSymbol namedTypeSymbol)
			return;

		if (!namedTypeSymbol
				.GetAttributes()
				.Any(x => x.AttributeClass?.ToString() == "Immediate.Handlers.Shared.HandlerAttribute")
		)
		{
			return;
		}

		token.ThrowIfCancellationRequested();
		if (namedTypeSymbol.ContainingType is not null)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMustNotBeNestedInAnotherClass,
					namedTypeSymbol.Locations[0],
					namedTypeSymbol.Name)
			);
		}

		if (namedTypeSymbol
				.GetMembers()
				.OfType<IMethodSymbol>()
				.Where(x => x.Name is "Handle" or "HandleAsync")
				.ToList()
			is not { Count: > 0 } methods)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMethodMustExist,
					namedTypeSymbol.Locations[0],
					namedTypeSymbol.Name)
			);

			return;
		}

		token.ThrowIfCancellationRequested();
		switch (methods.Where(m => m.IsStatic).ToList())
		{
			case { Count: var cnt and not 1 }:
			{
				token.ThrowIfCancellationRequested();

				var diagnostic = cnt == 0
					? HandlerMethodMustBeStatic
					: HandlerMethodMustBeUnique;

				foreach (var method in methods)
				{
					context.ReportDiagnostic(
						Diagnostic.Create(
							diagnostic,
							method.Locations[0],
							method.Name)
					);
				}

				break;
			}

			case [var methodSymbol]:
			{
				token.ThrowIfCancellationRequested();
				if (methodSymbol.ReturnType is INamedTypeSymbol returnTypeSymbol
					&& returnTypeSymbol.ConstructedFrom.ToString() is not (
						"System.Threading.Tasks.ValueTask<TResult>"
						or "System.Threading.Tasks.ValueTask")
				)
				{
					context.ReportDiagnostic(
						Diagnostic.Create(
							HandlerMethodMustReturnTask,
							methodSymbol.Locations[0],
							methodSymbol.Name
						)
					);
				}

				if (methodSymbol.DeclaredAccessibility is not Accessibility.Private)
				{
					context.ReportDiagnostic(
						Diagnostic.Create(
							HandlerMethodMustBePrivate,
							methodSymbol.Locations[0],
							methodSymbol.Name
						)
					);
				}

				break;
			}

			default:
				// should never happen - all count cases are covered above
				break;
		}
	}
}
