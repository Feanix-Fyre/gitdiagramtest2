namespace System.Collections.Generic;

[Serializable]
internal class GenericEqualityComparer<T> : EqualityComparer<T> where T : IEquatable<T>
{
	public override bool Equals(T x, T y)
	{
		return false;
	}

	public override int GetHashCode(T obj)
	{
		return 0;
	}

	internal override int IndexOf(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	internal override int LastIndexOf(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
