using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CodeFixes;

namespace Immediate.Handlers.CodeFixes;

public class HandlerClassCodeFixProvider : CodeFixProvider
{
	public override ImmutableArray<string> FixableDiagnosticIds { get; } = ImmutableArray.Create("IH0001");

	public override FixAllProvider? GetFixAllProvider() => null;

	public override Task RegisterCodeFixesAsync(CodeFixContext context)
	{
		throw new NotImplementedException();
	}
}
