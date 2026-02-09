using System.Diagnostics.CodeAnalysis;

// ReSharper disable UnusedAutoPropertyAccessor.Local

namespace Immediate.Handlers.Generators;

[ExcludeFromCodeCoverage]
public sealed record Behavior
{
	public required string RegistrationType { get; init; }
	public required string NonGenericTypeName { get; init; }
	public required string Name { get; init; }
	public required ConstraintInfo RequestType { get; init; }
	public required ConstraintInfo ResponseType { get; init; }
}

[ExcludeFromCodeCoverage]
public sealed record Parameter
{
	public required string? Attributes { get; init; }
	public required string Type { get; init; }
	public required string Name { get; init; }
}

[ExcludeFromCodeCoverage]
public sealed record GenericType
{
	public required string Name { get; init; }
	public required EquatableReadOnlyList<string> Implements { get; init; }
}

[ExcludeFromCodeCoverage]
public sealed record Handler
{
	public required string? Namespace { get; init; }
	public required string ClassName { get; init; }
	public required string DisplayName { get; init; }

	public required string MethodName { get; init; }
	public required EquatableReadOnlyList<Parameter> Parameters { get; init; }
	public required bool IsStatic { get; init; }
	public required bool UseToken { get; init; }

	public required GenericType RequestType { get; init; }
	public required GenericType? ResponseType { get; init; }

	public EquatableReadOnlyList<Behavior?>? OverrideBehaviors { get; init; }
}

public sealed record ConstraintInfo
{
	public required string? ExactType { get; init; }
	public required EquatableReadOnlyList<string> TypeConstraints { get; init; }

	public static ConstraintInfo Empty { get; } = new() { ExactType = null, TypeConstraints = [] };
}
