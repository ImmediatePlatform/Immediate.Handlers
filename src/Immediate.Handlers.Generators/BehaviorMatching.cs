namespace Immediate.Handlers.Generators;

internal static class BehaviorMatching
{
	public static bool IsValid(
		this Behavior? behavior,
		GenericType requestType,
		GenericType responseType
	) =>
		behavior is null
		|| (
			IsValid(behavior.RequestType, requestType)
			&& IsValid(behavior.ResponseType, responseType)
		);

	public static bool IsValid(
		ConstraintInfo constraintInfo,
		GenericType type
	)
	{
		if (constraintInfo.ExactType is { } exactType)
			return string.Equals(type.Name, exactType, StringComparison.Ordinal);

		return constraintInfo.TypeConstraints
			.All(c => type.Implements.Contains(c, StringComparer.Ordinal));
	}
}
