using System.Collections.Immutable;
using Immediate.Handlers.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Immediate.Handlers.CodeFixes;

[ExportCodeFixProvider(LanguageNames.CSharp)]
public sealed class StaticToSealedHandlerCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds { get; } =
		ImmutableArray.Create([DiagnosticIds.IHR0019StaticHandlerCouldBeSealed]);

	public override FixAllProvider? GetFixAllProvider() => WellKnownFixAllProviders.BatchFixer;

	public override async Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var (document, span, diagnostics, token) = context;
		token.ThrowIfCancellationRequested();

		if (await document.GetRequiredSyntaxRootAsync(token) is not CompilationUnitSyntax root)
			return;

		var model = await document.GetRequiredSemanticModelAsync(token);

		if (root.FindNode(span) is not ClassDeclarationSyntax cds)
			return;

		if (model.GetDeclaredSymbol(cds, token) is not INamedTypeSymbol { IsStatic: true } container)
			return;

		if (!container.GetAttributes().Any(a => a.AttributeClass.IsHandlerAttribute()))
			return;

		var method = container.GetMembers()
			.OfType<IMethodSymbol>()
			.FirstOrDefault(m => m is { IsStatic: true, Name: "Handle" or "HandleAsync" });

		if (method is null)
			return;

		var mds = (MethodDeclarationSyntax)await method
			.DeclaringSyntaxReferences[0]
			.GetSyntaxAsync(token);

		var service = new RefactoringService(
			document,
			model,
			root,
			cds,
			mds
		);

		context.RegisterCodeFix(
			CodeAction.Create(
				title: "Convert to instance handler",
				createChangedDocument: service.ConvertToInstanceHandler,
				equivalenceKey: nameof(StaticToSealedHandlerCodeFixProvider)
			),
			diagnostics[0]
		);
	}
}

file sealed class RefactoringService(
	Document document,
	SemanticModel model,
	CompilationUnitSyntax documentRoot,
	ClassDeclarationSyntax classDeclarationSyntax,
	MethodDeclarationSyntax methodDeclarationSyntax
)
{
	public Task<Document> ConvertToInstanceHandler(
		CancellationToken token
	)
	{
		var methodParameters = methodDeclarationSyntax.ParameterList.Parameters;

		var isLastParamCancellationToken = model.IsCancellationToken(methodParameters[^1].Type, token);

		var classParameters = methodParameters
			.Skip(1)
			.Take(methodParameters.Count - (isLastParamCancellationToken ? 2 : 1))
			.Select(p => p.WithTrailingTrivia(ElasticSpace))
			.ToList();

		var newMethodParameters = methodParameters.RemoveParametersUntilCount(isLastParamCancellationToken ? 2 : 1);

		var newMethodDeclarationSyntax = methodDeclarationSyntax
			.WithParameterList(
				methodDeclarationSyntax.ParameterList
					.WithParameters(newMethodParameters)
			)
			.WithModifiers(
				methodDeclarationSyntax.Modifiers
					.RemoveStaticModifier()
			);

		var newClassDeclarationSyntax = classDeclarationSyntax
			.ReplaceNode(methodDeclarationSyntax, newMethodDeclarationSyntax)
			.WithModifiers(
				classDeclarationSyntax.Modifiers
					.RemoveStaticModifier()
					.Insert(
						// valid case will have `partial` as final element; insert `sealed` before `partial`
						classDeclarationSyntax.Modifiers.Count - 2,
						Token(SyntaxKind.SealedKeyword).WithTrailingTrivia(ElasticSpace)
					)
			);

		if (classParameters.Count > 0)
		{
			newClassDeclarationSyntax = newClassDeclarationSyntax
				.WithParameterList(
					ParameterList(SeparatedList(classParameters))
				)
				.WithIdentifier(classDeclarationSyntax.Identifier.WithoutTrivia());
		}

		return Task.FromResult(document.WithSyntaxRoot(documentRoot.ReplaceNode(classDeclarationSyntax, newClassDeclarationSyntax)));
	}
}

file static class SyntaxExtensions
{
	public static SeparatedSyntaxList<ParameterSyntax> RemoveParametersUntilCount(
		this SeparatedSyntaxList<ParameterSyntax> nodes,
		int count
	)
	{
		while (nodes.Count > count)
			nodes = nodes.RemoveAt(1);
		return nodes;
	}

	public static SyntaxTokenList RemoveStaticModifier(
		this SyntaxTokenList list
	) => new(list.Where(static token => !token.IsKind(SyntaxKind.StaticKeyword)));
}
