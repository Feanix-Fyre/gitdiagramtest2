namespace System.Collections.Generic;

[Serializable]
internal class GenericComparer<T> : Comparer<T> where T : IComparable<T>
{
	public override int Compare(T x, T y)
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
