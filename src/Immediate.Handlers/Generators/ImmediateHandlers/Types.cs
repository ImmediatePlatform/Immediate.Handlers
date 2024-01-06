using Immediate.Handlers.Shared;

namespace Immediate.Handlers.Generators.ImmediateHandlers;

internal sealed record Behavior
{
	public required string RegistrationType { get; init; }
	public required string ConstructorType { get; init; }
	public required string NonGenericTypeName { get; init; }
	public required string? RequestType { get; init; }
	public required string? ResponseType { get; init; }
}

internal sealed record Parameter
{
	public required string Type { get; init; }
	public required string Name { get; init; }
}

internal sealed record GenericType
{
	public required string Name { get; init; }
	public required EquatableReadOnlyList<string> Implements { get; init; }
}

internal sealed record Handler
{
	public required string Namespace { get; init; }
	public required string ClassName { get; init; }
	public required string DisplayName { get; init; }

	public required GenericType RequestType { get; init; }
	public required GenericType ResponseType { get; init; }

	public required EquatableReadOnlyList<Parameter> Parameters { get; init; }

	public EquatableReadOnlyList<Behavior?>? OverrideBehaviors { get; init; }
	public RenderMode? OverrideRenderMode { get; init; }

}

internal struct ConstraintInfo
{
	public required string ConstructorType { get; set; }
	public string RequestType { get; set; }
	public string ResponseType { get; set; }
}