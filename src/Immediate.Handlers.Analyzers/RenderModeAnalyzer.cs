using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class RenderModeAnalyzer : DiagnosticAnalyzer
{
	private static readonly DiagnosticDescriptor InvalidRenderMode =
		new(
			id: DiagnosticIds.IHR0004InvalidRenderMode,
			title: "RenderMode attribute must be set to a valid RenderMode",
			messageFormat: "RenderMode attribute is set to an invalid RenderMode",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "RenderMode attribute must be set to a valid RenderMode: `RenderMode.Normal`."
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
			[
				InvalidRenderMode,
			]);

	public override void Initialize(AnalysisContext context)
	{
		if (context == null)
			throw new ArgumentNullException(nameof(context));

		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterOperationAction(AnalyzeOperation, OperationKind.Attribute);
	}

	private void AnalyzeOperation(OperationAnalysisContext context)
	{
		var token = context.CancellationToken;
		token.ThrowIfCancellationRequested();

		if (context.Operation is not IAttributeOperation { Operation: IObjectCreationOperation attribute })
			return;

		var renderModeAttributeSymbol = context.Compilation.GetTypeByMetadataName("Immediate.Handlers.Shared.RenderModeAttribute");

		token.ThrowIfCancellationRequested();
		if (!SymbolEqualityComparer.Default.Equals(attribute.Type?.OriginalDefinition, renderModeAttributeSymbol))
			return;

		token.ThrowIfCancellationRequested();
		var renderModeSymbol = context.Compilation.GetTypeByMetadataName("Immediate.Handlers.Shared.RenderMode");

		if (attribute.Arguments.Length != 1
			|| attribute.Arguments[0].Value is not IFieldReferenceOperation value
			|| !SymbolEqualityComparer.Default.Equals(value.Type?.OriginalDefinition, renderModeSymbol)
			|| value.Member.Name is "None")
		{
			context.ReportDiagnostic(Diagnostic.Create(
				InvalidRenderMode,
				attribute.Syntax.GetLocation(),
				""
			));
		}
	}
}
