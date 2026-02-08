using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class BehaviorsClassAnalyzer : DiagnosticAnalyzer
{
	public static readonly DiagnosticDescriptor BehaviorClassUsesInvalidConstraints =
		new(
			id: DiagnosticIds.IHR0021BehaviorClassUsesInvalidConstraints,
			title: "Behavior has invalid constraints",
			messageFormat: "Behavior type '{0}' has type constraints that are invalid",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "IH only supports type constraints that constraint to a known interface, class, or record."
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
		[
			BehaviorClassUsesInvalidConstraints,
		]);

	public override void Initialize(AnalysisContext context)
	{
		if (context == null)
			throw new ArgumentNullException(nameof(context));

		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterSymbolAction(AnalyzeSymbol, SymbolKind.NamedType);
	}

	private void AnalyzeSymbol(SymbolAnalysisContext context)
	{
		var token = context.CancellationToken;
		token.ThrowIfCancellationRequested();

		var containerSymbol = (INamedTypeSymbol)context.Symbol;

		if (!containerSymbol.ImplementsBehavior())
			return;

		if (!containerSymbol.IsGenericType)
			return;

		foreach (var typeParameter in containerSymbol.TypeParameters)
		{
			token.ThrowIfCancellationRequested();

			if (typeParameter.HasConstructorConstraint
				|| typeParameter.HasUnmanagedTypeConstraint
				|| typeParameter.HasReferenceTypeConstraint
				|| typeParameter.HasValueTypeConstraint
				|| typeParameter.HasNotNullConstraint)
			{
				context.ReportDiagnostic(
					Diagnostic.Create(
						BehaviorClassUsesInvalidConstraints,
						typeParameter.Locations.FirstOrDefault(),
						containerSymbol.ToDisplayString(SymbolDisplayFormat.CSharpShortErrorMessageFormat)
					)
				);
			}
		}
	}
}
