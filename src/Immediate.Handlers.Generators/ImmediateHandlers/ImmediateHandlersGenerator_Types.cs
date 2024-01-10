using System.Diagnostics.CodeAnalysis;
using Immediate.Handlers.Shared;

// ReSharper disable UnusedAutoPropertyAccessor.Local

namespace Immediate.Handlers.Generators.ImmediateHandlers;

public partial class ImmediateHandlersGenerator
{
	[ExcludeFromCodeCoverage]
	private sealed record Behavior
	{
		public required string RegistrationType { get; init; }
		public required string NonGenericTypeName { get; init; }
		public required string? RequestType { get; init; }
		public required string? ResponseType { get; init; }
	}

	[ExcludeFromCodeCoverage]
	private sealed record Parameter
	{
		public required string Type { get; init; }
		public required string Name { get; init; }
	}

	[ExcludeFromCodeCoverage]
	private sealed record GenericType
	{
		public required string Name { get; init; }
		public required EquatableReadOnlyList<string> Implements { get; init; }
	}

	[ExcludeFromCodeCoverage]
	private sealed record Handler
	{
		public required string? Namespace { get; init; }
		public required string ClassName { get; init; }
		public required string DisplayName { get; init; }

		public required string MethodName { get; init; }
		public required EquatableReadOnlyList<Parameter> Parameters { get; init; }

		public required GenericType RequestType { get; init; }
		public required GenericType ResponseType { get; init; }

		public EquatableReadOnlyList<Behavior?>? OverrideBehaviors { get; init; }
		public RenderMode? OverrideRenderMode { get; init; }
	}

	[ExcludeFromCodeCoverage]
	private sealed record ConstraintInfo
	{
		public required string? RequestType { get; init; }
		public required string? ResponseType { get; init; }
	}
}
