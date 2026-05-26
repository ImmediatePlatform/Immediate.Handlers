using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.Operations;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class InvalidImmediatePrefixAnalyzer : DiagnosticAnalyzer
{
	public static readonly DiagnosticDescriptor InvalidImmediatePrefix =
		new(
			id: DiagnosticIds.IHR0023InvalidImmediatePrefix,
			title: "Invalid Immediate prefix",
			messageFormat: "Immediate prefix '{0}' is not a valid identifier",
			category: "ImmediateHandler",
			defaultSeverity: DiagnosticSeverity.Error,
			isEnabledByDefault: true,
			description: "The prefix supplied to [assembly: ImmediatePrefix] must be a valid C# identifier (start with a letter or underscore, followed by letters, digits, or underscores).",
			customTags: [WellKnownDiagnosticTags.NotConfigurable]
		);

	public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; } =
		ImmutableArray.Create(
		[
			InvalidImmediatePrefix,
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
				Type.IsImmediatePrefixAttribute: true,
				Arguments: [{ Value.ConstantValue: { HasValue: true, Value: string prefix } }],
			})
		{
			return;
		}

		token.ThrowIfCancellationRequested();

		if (Utility.IsValidIdentifier(prefix))
			return;

		context.ReportDiagnostic(
			Diagnostic.Create(
				InvalidImmediatePrefix,
				attribute.Syntax.GetLocation(),
				prefix
			)
		);
	}
}
