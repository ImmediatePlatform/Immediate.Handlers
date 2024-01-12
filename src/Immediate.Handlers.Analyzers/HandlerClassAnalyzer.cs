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
			title: "Handler method must return a Task<T>",
			messageFormat: "Method '{0}' must return a Task<T>",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Handler methods must return a Task<T>."
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

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
			[
				HandlerMethodMustExist,
				HandlerMethodMustReturnTask,
				HandlerMustNotBeNestedInAnotherClass,
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
		if (context.Symbol is not INamedTypeSymbol namedTypeSymbol)
			return;

		if (!namedTypeSymbol
				.GetAttributes()
				.Any(x => x.AttributeClass?.ToString() == "Immediate.Handlers.Shared.HandlerAttribute")
		)
		{
			return;
		}

		if (namedTypeSymbol.ContainingType is not null)
		{
			var mustNotBeWrappedInAnotherType = Diagnostic.Create(
				HandlerMustNotBeNestedInAnotherClass,
				namedTypeSymbol.Locations[0],
				namedTypeSymbol.Name
			);

			context.ReportDiagnostic(mustNotBeWrappedInAnotherType);
		}

		if (namedTypeSymbol
				.GetMembers()
				.OfType<IMethodSymbol>()
				.FirstOrDefault(x => x.Name is "Handle" or "HandleAsync")
			is not { } methodSymbol)
		{
			var doesNotExistDiagnostic = Diagnostic.Create(
				HandlerMethodMustExist,
				namedTypeSymbol.Locations[0],
				namedTypeSymbol.Name
			);

			context.ReportDiagnostic(doesNotExistDiagnostic);
			return;
		}

		if (methodSymbol.ReturnType is INamedTypeSymbol returnTypeSymbol
			&& returnTypeSymbol.ConstructedFrom.ToString() is not "System.Threading.Tasks.Task<TResult>")
		{
			var mustReturnTaskT = Diagnostic.Create(
				HandlerMethodMustReturnTask,
				methodSymbol.Locations[0],
				methodSymbol.Name
			);

			context.ReportDiagnostic(mustReturnTaskT);
		}
	}
}
