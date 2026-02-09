using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;

namespace Immediate.Handlers;

[ExcludeFromCodeCoverage]
public sealed record BehaviorConstraintInfo
{
	public required ConstraintInfo? RequestConstraints { get; init; }
	public required ConstraintInfo? ResponseConstraints { get; init; }
}

public sealed record ConstraintInfo
{
	public required ITypeSymbol? ExactType { get; init; }
	public required IReadOnlyList<ITypeSymbol> TypeConstraints { get; init; }

	public static ConstraintInfo Empty { get; } = new() { ExactType = null, TypeConstraints = [] };
}
