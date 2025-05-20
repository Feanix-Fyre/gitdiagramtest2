namespace System.Collections.Generic;

internal struct ArrayBuilder<T>
{
	private T[] _array;

	private int _count;

	public int Capacity => 0;

	public int Count => 0;

	public T this[int index] => default(T);

	public void Add(T item)
	{
	}

	public void UncheckedAdd(T item)
	{
	}

	private void EnsureCapacity(int minimum)
	{
	}
}
