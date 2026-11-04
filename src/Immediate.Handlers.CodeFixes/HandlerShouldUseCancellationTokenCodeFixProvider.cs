using System.Collections.Immutable;
using System.Globalization;
using Immediate.Handlers.Analyzers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
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

	/// <summary>Registers a fix when a cancellation token can be appended to the diagnosed handler.</summary>
	public override async Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		var (document, span, diagnostics, token) = context;
		token.ThrowIfCancellationRequested();

		var root = await document.GetRequiredSyntaxRootAsync(token);
		if (root.FindNode(span) is not MethodDeclarationSyntax method
			|| method.ParameterList.Parameters.Any(p => p.Modifiers.Any(SyntaxKind.ParamsKeyword)))
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

	/// <summary>Appends an optional token without conflicting with existing names or breaking existing calls.</summary>
	private static Task<Document> AddCancellationTokenAsync(
		Document document,
		SyntaxNode root,
		MethodDeclarationSyntax method,
		CancellationToken cancellationToken
	)
	{
		cancellationToken.ThrowIfCancellationRequested();

		var parameter = Parameter(Identifier(GetParameterName(method)))
			.WithType(
				ParseTypeName("global::System.Threading.CancellationToken")
					.WithAdditionalAnnotations(Simplifier.Annotation)
			)
			.WithDefault(EqualsValueClause(LiteralExpression(SyntaxKind.DefaultLiteralExpression)))
			.WithAdditionalAnnotations(Formatter.Annotation);

		var newMethod = method.AddParameterListParameters(parameter);
		return Task.FromResult(document.WithSyntaxRoot(root.ReplaceNode(method, newMethod)));
	}

	/// <summary>Chooses a name that cannot shadow identifiers or conflict with declarations in the method.</summary>
	private static string GetParameterName(MethodDeclarationSyntax method)
	{
		var names = new HashSet<string>(
			method.DescendantTokens()
				.Where(static token => token.IsKind(SyntaxKind.IdentifierToken))
				.Select(static token => token.ValueText),
			StringComparer.Ordinal
		);

		var parameterName = "cancellationToken";
		for (var suffix = 1; names.Contains(parameterName); suffix++)
			parameterName = "cancellationToken" + suffix.ToString(CultureInfo.InvariantCulture);

		return parameterName;
	}
}
