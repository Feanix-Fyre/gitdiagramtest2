using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

internal struct LargeArrayBuilder<T>
{
	private readonly int _maxCapacity;

	private T[] _first;

	private ArrayBuilder<T[]> _buffers;

	private T[] _current;

	private int _index;

	private int _count;

	public LargeArrayBuilder(bool initialize)
	{
		_maxCapacity = 0;
		_first = null;
		_buffers = default(ArrayBuilder<T[]>);
		_current = null;
		_index = 0;
		_count = 0;
	}

	public LargeArrayBuilder(int maxCapacity)
	{
		_maxCapacity = 0;
		_first = null;
		_buffers = default(ArrayBuilder<T[]>);
		_current = null;
		_index = 0;
		_count = 0;
	}

	public void AddRange(IEnumerable<T> items)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddWithBufferAllocation(T item, ref T[] destination, ref int index)
	{
	}

	public void CopyTo(T[] array, int arrayIndex, int count)
	{
	}

	public T[] GetBuffer(int index)
	{
		return null;
	}

	public T[] ToArray()
	{
		return null;
	}

	public bool TryMove(out T[] array)
	{
		array = null;
		return false;
	}

	private void AllocateBuffer()
	{
	}
}
