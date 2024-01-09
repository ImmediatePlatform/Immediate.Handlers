using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Immediate.Handlers.Generators;

[ExcludeFromCodeCoverage]
public static class EquatableReadOnlyList
{
	public static EquatableReadOnlyList<T> ToEquatableReadOnlyList<T>(this IEnumerable<T> enumerable)
		=> new(enumerable.ToArray());
}

/// <summary>
///     A wrapper for IReadOnlyList that provides value equality support for the wrapped list.
/// </summary>
[ExcludeFromCodeCoverage]
public readonly struct EquatableReadOnlyList<T>(
	IReadOnlyList<T>? collection
) : IEquatable<EquatableReadOnlyList<T>>, IReadOnlyList<T>
{
	private IReadOnlyList<T> Collection => collection ?? [];

	public bool Equals(EquatableReadOnlyList<T> other)
		=> this.SequenceEqual(other);

	public override bool Equals(object? obj)
		=> obj is EquatableReadOnlyList<T> other && Equals(other);

	public override int GetHashCode()
	{
		var hashCode = new HashCode();

		foreach (var item in Collection)
			hashCode.Add(item);

		return hashCode.ToHashCode();
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
		=> Collection.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator()
		=> Collection.GetEnumerator();

	public int Count => Collection.Count;
	public T this[int index] => Collection[index];

	public static bool operator ==(EquatableReadOnlyList<T> left, EquatableReadOnlyList<T> right)
		=> left.Equals(right);

	public static bool operator !=(EquatableReadOnlyList<T> left, EquatableReadOnlyList<T> right)
		=> !left.Equals(right);
}
