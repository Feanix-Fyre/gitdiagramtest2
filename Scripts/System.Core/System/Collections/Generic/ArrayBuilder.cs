using System.Reflection;

namespace System.Collections.Generic;

[DefaultMember("Item")]
internal struct ArrayBuilder<T>
{
	private T[] _array;

	private int _count;

	public ArrayBuilder(int capacity)
	{
		_array = null;
		_count = 0;
	}

	public T[] ToArray()
	{
		return null;
	}

	public void UncheckedAdd(T item)
	{
	}
}
