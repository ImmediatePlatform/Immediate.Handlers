using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class HandlerClassAnalyzer : DiagnosticAnalyzer
{
	public static readonly DiagnosticDescriptor HandlerMethodMustExist =
		new(
			id: DiagnosticIds.IHR0001HandlerMethodMustExist,
			title: "Handler type should implement a Handle/HandleAsync method",
			messageFormat: "Handler type '{0}' should implement a Handle/HandleAsync method",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Classes annotated with a Handler attribute should implement a Handle/HandleAsync method."
		);

	public static readonly DiagnosticDescriptor HandlerMethodMustReturnTask =
		new(
			id: DiagnosticIds.IHR0002HandlerMethodMustReturnTask,
			title: "Handler method must return a ValueTask or ValueTask<T>",
			messageFormat: "Method '{0}' must return a ValueTask or ValueTask<T>",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Handler methods must return a ValueTask<T>."
		);

	public static readonly DiagnosticDescriptor HandlerMustNotBeNestedInAnotherClass =
		new(
			id: DiagnosticIds.IHR0005HandlerClassMustNotBeNested,
			title: "Handler nesting is not allowed",
			messageFormat: "Handler '{0}' must not be nested in another type",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Handler class must not be nested in another type."
		);

	public static readonly DiagnosticDescriptor HandlerMethodMustBeUnique =
		new(
			id: DiagnosticIds.IHR0010HandlerMethodMustBeUnique,
			title: "Handler method must be unique",
			messageFormat: "Method '{0}' must not conflict with another static handler method",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Static handler method must be static."
		);

	public static readonly DiagnosticDescriptor HandlerMethodMustBePrivate =
		new(
			id: DiagnosticIds.IHR0011HandlerMethodMustBePrivate,
			title: "Handler method must be private",
			messageFormat: "Method '{0}' must be set to private",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Static handler method must be static."
		);

	public static readonly DiagnosticDescriptor HandlerShouldUseCancellationToken =
		new(
			id: DiagnosticIds.IHR0012HandlerShouldUseCancellationToken,
			title: "Handler method should use CancellationToken",
			messageFormat: "Method '{0}' should receive a `CancellationToken`",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Warning,
			isEnabledByDefault: true,
			description: "Handlers should use CancellationToken to properly support cancellation."
		);

	public static readonly DiagnosticDescriptor HandlerMethodMissingRequest =
		new(
			id: DiagnosticIds.IHR0014HandlerMethodMissingRequest,
			title: "Handler method is missing request parameter",
			messageFormat: "Method '{0}' should receive a request parameter",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Handlers must have a request parameter."
		);

	public static readonly DiagnosticDescriptor HandlerMethodHasTooManyParameters =
		new(
			id: DiagnosticIds.IHR0015HandlerMethodHasTooManyParameters,
			title: "Handler method has too many parameters",
			messageFormat: "Method '{0}' should have a request parameter and, optionally, a cancellation token parameter only",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Handlers must have only one or two parameters."
		);

	public static readonly DiagnosticDescriptor ContainingClassMustBeSealed =
		new(
			id: DiagnosticIds.IHR0016ContainingClassMustBeSealed,
			title: "Handler type must be `sealed`",
			messageFormat: "Class '{0}' must be `sealed`",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Containing classes must be sealed to prevent incorrect usage."
		);

	public static readonly DiagnosticDescriptor ContainingClassInstanceMembersMustBePrivate =
		new(
			id: DiagnosticIds.IHR0017ContainingClassInstanceMembersMustBePrivate,
			title: "Instances members of handler types must be `private`",
			messageFormat: "Member '{0}' must be `private`",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "All members of handler classes must be private to prevent incorrect usage."
		);

	public static readonly DiagnosticDescriptor ContainingClassMustBeStatic =
		new(
			id: DiagnosticIds.IHR0018ContainingClassMustBeStatic,
			title: "Handler types must be `static`",
			messageFormat: "Class '{0}' must be `static`",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "Containing classes must be static to prevent incorrect usage."
		);

	public static readonly DiagnosticDescriptor StaticHandlerCouldBeSealed =
		new(
			id: DiagnosticIds.IHR0019StaticHandlerCouldBeSealed,
			title: "Static handler may be converted to a sealed handler",
			messageFormat: "Class '{0}' can be converted to be a `sealed` handler",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Hidden,
			isEnabledByDefault: true,
			description: "Static handler may be converted to a sealed handler.",
			customTags: [WellKnownDiagnosticTags.NotConfigurable]
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
		[
			HandlerMethodMustExist,
			HandlerMethodMustReturnTask,
			HandlerMustNotBeNestedInAnotherClass,
			HandlerMethodMustBeUnique,
			HandlerMethodMustBePrivate,
			HandlerShouldUseCancellationToken,
			HandlerMethodMissingRequest,
			HandlerMethodHasTooManyParameters,
			ContainingClassMustBeSealed,
			ContainingClassInstanceMembersMustBePrivate,
			ContainingClassMustBeStatic,
			StaticHandlerCouldBeSealed,
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

		var containerSymbol = (INamedTypeSymbol)context.Symbol;

		if (!containerSymbol
				.GetAttributes()
				.Any(x => x.AttributeClass.IsHandlerAttribute())
		)
		{
			return;
		}

		token.ThrowIfCancellationRequested();
		if (containerSymbol.ContainingType is not null)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMustNotBeNestedInAnotherClass,
					containerSymbol.Locations[0],
					containerSymbol.Name)
			);
		}

		if (containerSymbol
				.GetMembers()
				.OfType<IMethodSymbol>()
				.Where(x => x.Name is "Handle" or "HandleAsync")
				.ToList()
			is not { Count: > 0 } methods)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMethodMustExist,
					containerSymbol.Locations[0],
					containerSymbol.Name)
			);

			return;
		}

		token.ThrowIfCancellationRequested();

		if (methods is [{ } method])
		{
			if (method.IsStatic)
				AnalyzeStaticHandler(context, containerSymbol, method);
			else
				AnalyzeInstanceMethod(context, containerSymbol, method);

			return;
		}

		foreach (var m in methods)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMethodMustBeUnique,
					m.Locations[0],
					m.Name)
			);
		}
	}

	private static void AnalyzeInstanceMethod(SymbolAnalysisContext context, INamedTypeSymbol containerSymbol, IMethodSymbol method)
	{
		AnalyzeAccessibility(context, method);
		AnalyzeReturnType(context, method);
		AnalyzeCancellationToken(context, method);

		if (method.Parameters is [] or [{ Type.IsCancellationToken: true }])
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMethodMissingRequest,
					method.Locations[0],
					method.Name
				)
			);
		}
		else if (method.Parameters.Length > 2
			|| (method.Parameters.Length > 1 && !method.Parameters[^1].Type.IsCancellationToken))
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMethodHasTooManyParameters,
					method.Locations[0],
					method.Name
				)
			);
		}

		if (!containerSymbol.IsSealed)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					ContainingClassMustBeSealed,
					containerSymbol.Locations[0],
					containerSymbol.Name
				)
			);
		}

		foreach (var member in containerSymbol.GetMembers())
		{
			if (ReferenceEquals(member, method)
				|| member
					// static members are fine
					is { IsStatic: true }
					// private members are fine
					or { DeclaredAccessibility: Accessibility.Private or Accessibility.NotApplicable }
					// nested types are fine
					or INamedTypeSymbol
					// constructors and property implementations are fine
					or IMethodSymbol { MethodKind: MethodKind.Constructor or MethodKind.PropertyGet or MethodKind.PropertySet }
			)
			{
				continue;
			}

			context.ReportDiagnostic(
				Diagnostic.Create(
					ContainingClassInstanceMembersMustBePrivate,
					member.Locations[0],
					member.Name
				)
			);
		}
	}

	private static void AnalyzeStaticHandler(SymbolAnalysisContext context, INamedTypeSymbol containerSymbol, IMethodSymbol method)
	{
		AnalyzeAccessibility(context, method);
		AnalyzeReturnType(context, method);
		AnalyzeCancellationToken(context, method);

		context.ReportDiagnostic(
			Diagnostic.Create(
				StaticHandlerCouldBeSealed,
				containerSymbol.Locations[0],
				containerSymbol.Name
			)
		);

		if (method.Parameters is [] or [{ Type.IsCancellationToken: true }])
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMethodMissingRequest,
					method.Locations[0],
					method.Name
				)
			);
		}

		if (!containerSymbol.IsStatic)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					ContainingClassMustBeStatic,
					containerSymbol.Locations[0],
					containerSymbol.Name
				)
			);
		}
	}

	private static void AnalyzeAccessibility(SymbolAnalysisContext context, IMethodSymbol method)
	{
		if (method.DeclaredAccessibility is not Accessibility.Private)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMethodMustBePrivate,
					method.Locations[0],
					method.Name
				)
			);
		}
	}

	private static void AnalyzeReturnType(SymbolAnalysisContext context, IMethodSymbol method)
	{
		if (method is not
			{
				ReturnType: INamedTypeSymbol
				{
					OriginalDefinition:
					{
						Arity: 0 or 1,
						Name: "ValueTask",
						ContainingNamespace.IsSystemThreadingTasks: true,
					}
				}
			}
		)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerMethodMustReturnTask,
					method.Locations[0],
					method.Name
				)
			);
		}
	}

	private static void AnalyzeCancellationToken(SymbolAnalysisContext context, IMethodSymbol method)
	{
		if (method.Parameters.Length == 0)
			return;

		if (!method.Parameters[^1].Type.IsCancellationToken)
		{
			context.ReportDiagnostic(
				Diagnostic.Create(
					HandlerShouldUseCancellationToken,
					method.Locations[0],
					method.Name
				)
			);
		}
	}
}
