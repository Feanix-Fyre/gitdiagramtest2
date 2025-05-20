using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

internal ref struct ValueListBuilder<T>
{
	private Span<T> _span;

	private T[] _arrayFromPool;

	private int _pos;

	public int Length => 0;

	public ref T this[int index]
	{
		get
		{
			throw null;
		}
	}

	public ValueListBuilder(Span<T> initialSpan)
	{
		_span = default(Span<T>);
		_arrayFromPool = null;
		_pos = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Append(T item)
	{
	}

	public ReadOnlySpan<T> AsSpan()
	{
		return default(ReadOnlySpan<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Dispose()
	{
	}

	private void Grow()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public T Pop()
	{
		return default(T);
	}
}
