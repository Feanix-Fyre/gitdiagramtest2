using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(SpanDebugView<>))]
[NonVersionable]
public readonly ref struct Span<T>
{
	internal readonly ByReference<T> _pointer;

	private readonly int _length;

	public ref T this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[NonVersionable]
		[Intrinsic]
		get
		{
			throw null;
		}
	}

	public int Length
	{
		[NonVersionable]
		get
		{
			return 0;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span(T[] array)
	{
		_pointer = default(ByReference<T>);
		_length = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span(T[] array, int start, int length)
	{
		_pointer = default(ByReference<T>);
		_length = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[CLSCompliant(false)]
	public unsafe Span(void* pointer, int length)
	{
		_pointer = default(ByReference<T>);
		_length = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal Span(ref T ptr, int length)
	{
		_pointer = default(ByReference<T>);
		_length = 0;
	}

	public ref T GetPinnableReference()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Clear()
	{
	}

	public void Fill(T value)
	{
	}

	public void CopyTo(Span<T> destination)
	{
	}

	public bool TryCopyTo(Span<T> destination)
	{
		return false;
	}

	public static implicit operator ReadOnlySpan<T>(Span<T> span)
	{
		return default(ReadOnlySpan<T>);
	}

	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span<T> Slice(int start)
	{
		return default(Span<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Span<T> Slice(int start, int length)
	{
		return default(Span<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public T[] ToArray()
	{
		return null;
	}

	[Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
	public override bool Equals(object obj)
	{
		return false;
	}

	[Obsolete("GetHashCode() on Span will always throw an exception.")]
	public override int GetHashCode()
	{
		return 0;
	}

	public static implicit operator Span<T>(T[] array)
	{
		return default(Span<T>);
	}
}
