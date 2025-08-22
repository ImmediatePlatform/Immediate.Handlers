using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeRefactorings;
using Microsoft.CodeAnalysis.Text;

namespace Immediate.Handlers.CodeFixes;

[ExcludeFromCodeCoverage]
internal static class RefactoringExtensions
{
	internal static void Deconstruct(this CodeRefactoringContext context, out Document document, out TextSpan span, out CancellationToken cancellationToken)
	{
		document = context.Document;
		span = context.Span;
		cancellationToken = context.CancellationToken;
	}

	public static async ValueTask<SyntaxNode> GetRequiredSyntaxRootAsync(this Document document, CancellationToken cancellationToken)
	{
		if (document.TryGetSyntaxRoot(out var root))
			return root;

		return await document.GetSyntaxRootAsync(cancellationToken)
			?? throw new InvalidOperationException($"Failed to retrieve the syntax root for document '{document.Name ?? document.FilePath ?? "unknown"}'.");
	}

	public static async ValueTask<SemanticModel> GetRequiredSemanticModelAsync(this Document document, CancellationToken cancellationToken)
	{
		if (document.TryGetSemanticModel(out var semanticModel))
			return semanticModel;

		return await document.GetSemanticModelAsync(cancellationToken)
			?? throw new InvalidOperationException();
	}
}
