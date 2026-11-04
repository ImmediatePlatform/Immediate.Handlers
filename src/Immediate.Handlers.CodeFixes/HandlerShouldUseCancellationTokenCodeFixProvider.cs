using System.Collections.Immutable;
using Immediate.Handlers.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.Simplification;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Immediate.Handlers.CodeFixes;

[ExportCodeFixProvider(LanguageNames.CSharp)]
public sealed class HandlerShouldUseCancellationTokenCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds { get; } =
		ImmutableArray.Create([DiagnosticIds.IHR0012HandlerShouldUseCancellationToken]);

	public override FixAllProvider? GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public override async Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var (document, span, diagnostics, token) = context;
		token.ThrowIfCancellationRequested();

		var root = await document.GetRequiredSyntaxRootAsync(token);
		if (root.FindNode(span) is not MethodDeclarationSyntax method)
			return;

		context.RegisterCodeFix(
			CodeAction.Create(
				title: "Add CancellationToken parameter",
				createChangedDocument: cancellationToken => AddCancellationTokenAsync(document, root, method, cancellationToken),
				equivalenceKey: nameof(HandlerShouldUseCancellationTokenCodeFixProvider)
			),
			diagnostics[0]
		);
	}

	private static Task<Document> AddCancellationTokenAsync(
		Document document,
		SyntaxNode root,
		MethodDeclarationSyntax method,
		CancellationToken cancellationToken
	)
	{
		cancellationToken.ThrowIfCancellationRequested();

		var parameter = Parameter(Identifier("cancellationToken"))
			.WithType(
				ParseTypeName("global::System.Threading.CancellationToken")
					.WithAdditionalAnnotations(Simplifier.Annotation)
			)
			.WithAdditionalAnnotations(Formatter.Annotation);

		var newMethod = method.AddParameterListParameters(parameter);
		return Task.FromResult(document.WithSyntaxRoot(root.ReplaceNode(method, newMethod)));
	}
}
