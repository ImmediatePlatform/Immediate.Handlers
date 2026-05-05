using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace Immediate.Handlers.Analyzers;

[DiagnosticAnalyzer(LanguageNames.CSharp)]
public sealed class MarkHandleMethodAsStaticSuppressor : DiagnosticSuppressor
{
	public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions =>
		ImmutableArray.Create<SuppressionDescriptor>([
			new(
				id: "MarkMembersAsStaticSuppression",
				suppressedDiagnosticId: "CA1822",
				justification: "Handler methods should not be triggered to be static."
			),
		]);

	public override void ReportSuppressions(SuppressionAnalysisContext context)
	{
		foreach (var diagnostic in context.ReportedDiagnostics)
		{
			context.CancellationToken.ThrowIfCancellationRequested();

			if (diagnostic.Location.SourceTree?.GetRoot().FindNode(diagnostic.Location.SourceSpan) is not MethodDeclarationSyntax node)
				continue;

			var model = context.GetSemanticModel(diagnostic.Location.SourceTree);
			var method = (IMethodSymbol?)model.GetDeclaredSymbol(node, context.CancellationToken);

			if (
				method is not
				{
					MethodKind: MethodKind.Ordinary,
					Name: "Handle" or "HandleAsync",
					ReturnType.IsValidHandlerReturn: true,
				}
				|| !method.ContainingSymbol.GetAttributes().Any(ad => ad.AttributeClass.IsHandlerAttribute)
			)
			{
				continue;
			}

			if (!context.Options.GetConfigurationValue(
				method,
				HandlerClassAnalyzer.DiagnosticOptionIhr0019EnableNoDependencies,
				defaultValue: false
			))
			{
				continue;
			}

			context.ReportSuppression(
				Suppression.Create(
					SupportedSuppressions[0],
					diagnostic
				)
			);
		}
	}
}
