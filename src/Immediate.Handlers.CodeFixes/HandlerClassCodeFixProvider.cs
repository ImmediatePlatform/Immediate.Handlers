using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using SyntaxKind = Microsoft.CodeAnalysis.CSharp.SyntaxKind;

namespace Immediate.Handlers.CodeFixes;

[ExportCodeFixProvider(LanguageNames.CSharp)]
public class HandlerClassCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds { get; } = ImmutableArray.Create("IH0001");

	public override FixAllProvider? GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public sealed override async Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		// We link only one diagnostic and assume there is only one diagnostic in the context.
		var diagnostic = context.Diagnostics.Single();

		// 'SourceSpan' of 'Location' is the highlighted area. We're going to use this area to find the 'SyntaxNode' to rename.
		var diagnosticSpan = diagnostic.Location.SourceSpan;

		var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(false);

		if (root?.FindNode(diagnosticSpan) is ClassDeclarationSyntax classDeclarationSyntax)
		{
			context.RegisterCodeFix(
				CodeAction.Create(
					title: "Add HandleAsync method",
					createChangedDocument: _ => AddHandleAsyncMethodAsync(context.Document, root, classDeclarationSyntax),
					equivalenceKey: nameof(HandlerClassCodeFixProvider)
				),
				diagnostic);
		}
	}

	private static Task<Document> AddHandleAsyncMethodAsync(Document document,
		SyntaxNode root,
		ClassDeclarationSyntax classDeclarationSyntax)
	{
		var methodDeclaration = MethodDeclaration(
				GenericName(
						Identifier("Task"))
					.WithTypeArgumentList(
						TypeArgumentList(
							SingletonSeparatedList<TypeSyntax>(
								PredefinedType(
									Token(SyntaxKind.IntKeyword))))),
				Identifier("HandleAsync"))
			.WithModifiers(
				TokenList(
				[
					Token(SyntaxKind.PrivateKeyword),
					Token(SyntaxKind.StaticKeyword),
				]))
			.WithParameterList(
				ParameterList(
					SeparatedList<ParameterSyntax>(
						new SyntaxNodeOrToken[]
						{
							Parameter(
									Identifier(
										TriviaList(),
										SyntaxKind.UnderscoreToken,
										"_",
										"_",
										TriviaList()))
								.WithType(
									IdentifierName("Query")),
							Token(SyntaxKind.CommaToken),
							Parameter(
									Identifier("token"))
								.WithType(
									IdentifierName("CancellationToken")),
						})))
			.WithBody(
				Block(
					SingletonList<StatementSyntax>(
						ReturnStatement(
							LiteralExpression(
								SyntaxKind.NullLiteralExpression)))))
			.WithAdditionalAnnotations(Formatter.Annotation);

		var newClassDecl = classDeclarationSyntax.AddMembers(methodDeclaration);

		return Task.FromResult(document.WithSyntaxRoot(root.ReplaceNode(classDeclarationSyntax, newClassDecl)));
	}
}
