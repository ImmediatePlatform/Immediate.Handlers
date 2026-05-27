using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class InvalidImmediateAssemblyIdentifierAnalyzer : DiagnosticAnalyzer
{
	public static readonly DiagnosticDescriptor InvalidImmediateAssemblyIdentifier =
		new(
			id: DiagnosticIds.IHR0023InvalidImmediateAssemblyIdentifier,
			title: "Invalid assembly identifier",
			messageFormat: "Assembly identifier '{0}' is not a valid C# identifier",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "The value supplied to [assembly: ImmediateAssemblyIdentifier] must be a valid C# identifier.",
			customTags: [WellKnownDiagnosticTags.NotConfigurable]
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
		[
			InvalidImmediateAssemblyIdentifier,
		]);

	public override void Initialize(AnalysisContext context)
	{
		if (context == null)
			throw new ArgumentNullException(nameof(context));

		context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);
		context.EnableConcurrentExecution();

		context.RegisterOperationAction(AnalyzeOperation, OperationKind.Attribute);
	}

	private static void AnalyzeOperation(OperationAnalysisContext context)
	{
		var token = context.CancellationToken;
		token.ThrowIfCancellationRequested();

		if (context.Operation is not IAttributeOperation { Operation: IObjectCreationOperation attribute })
			return;

		if (attribute is not
			{
				Type.IsImmediateAssemblyIdentifierAttribute: true,
				Arguments: [{ Value.ConstantValue: { HasValue: true, Value: var identifier } }],
			})
		{
			return;
		}

		if (identifier is string { Length: >= 1 } id
			&& id[0] != '@'
			&& SyntaxFacts.IsValidIdentifier(id))
		{
			return;
		}

		context.ReportDiagnostic(
			Diagnostic.Create(
				InvalidImmediateAssemblyIdentifier,
				attribute.Syntax.GetLocation(),
				identifier
			)
		);
	}
}
