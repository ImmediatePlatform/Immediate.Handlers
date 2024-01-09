using System.Collections.Immutable;
using Immediate.Handlers.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Formatting;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using SyntaxKind = Microsoft.CodeAnalysis.CSharp.SyntaxKind;

namespace Immediate.Handlers.CodeFixes;

[ExportCodeFixProvider(LanguageNames.CSharp)]
public class HandlerClassShouldDefineCommandOrQueryCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds { get; } =
		ImmutableArray.Create([DiagnosticIds.IHR0009HandlerClassShouldDefineCommandOrQuery]);

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
					title: "Add Query record",
					createChangedDocument: _ => AddCommandOrQueryRecordAsync(context.Document, root, classDeclarationSyntax, "Query"),
					equivalenceKey: nameof(HandlerClassShouldDefineCommandOrQueryCodeFixProvider) + "Query"
				),
				diagnostic);

			context.RegisterCodeFix(
				CodeAction.Create(
					title: "Add Command record",
					createChangedDocument: _ => AddCommandOrQueryRecordAsync(context.Document, root, classDeclarationSyntax, "Command"),
					equivalenceKey: nameof(HandlerClassShouldDefineCommandOrQueryCodeFixProvider) + "Command"
				),
				diagnostic);
		}
	}

	private static Task<Document> AddCommandOrQueryRecordAsync(Document document,
		SyntaxNode root,
		ClassDeclarationSyntax classDeclarationSyntax,
		string recordName)
	{
		var recordDeclaration = RecordDeclaration(
					SyntaxKind.RecordDeclaration,
					Token(SyntaxKind.RecordKeyword),
					Identifier(recordName))
				.WithModifiers(
					TokenList(
						Token(SyntaxKind.PublicKeyword)))
				.WithSemicolonToken(
					Token(SyntaxKind.SemicolonToken))
				.NormalizeWhitespace()
			.WithAdditionalAnnotations(Formatter.Annotation);

		var newMembers = new SyntaxList<MemberDeclarationSyntax>()
			.Add(recordDeclaration)
			.AddRange(classDeclarationSyntax.Members);

		var newClassDecl = classDeclarationSyntax.WithMembers(newMembers);

		return Task.FromResult(document.WithSyntaxRoot(root.ReplaceNode(classDeclarationSyntax, newClassDecl)));
	}
}
