using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System;

[DebuggerTypeProxy(typeof(SpanDebugView<>))]
[DebuggerDisplay("{ToString(),raw}")]
[NonVersionable]
public readonly ref struct ReadOnlySpan<T>
{
	internal readonly ByReference<T> _pointer;

	private readonly int _length;

	public ref readonly T this[int index]
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

	public bool IsEmpty
	{
		[NonVersionable]
		get
		{
			return false;
		}
	}

	public static ReadOnlySpan<T> Empty => default(ReadOnlySpan<T>);

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadOnlySpan(T[] array)
	{
		_pointer = default(ByReference<T>);
		_length = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadOnlySpan(T[] array, int start, int length)
	{
		_pointer = default(ByReference<T>);
		_length = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[CLSCompliant(false)]
	public unsafe ReadOnlySpan(void* pointer, int length)
	{
		_pointer = default(ByReference<T>);
		_length = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ReadOnlySpan(ref T ptr, int length)
	{
		_pointer = default(ByReference<T>);
		_length = 0;
	}

	public void CopyTo(Span<T> destination)
	{
	}

	public bool TryCopyTo(Span<T> destination)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadOnlySpan<T> Slice(int start)
	{
		return default(ReadOnlySpan<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadOnlySpan<T> Slice(int start, int length)
	{
		return default(ReadOnlySpan<T>);
	}

	public T[] ToArray()
	{
		return null;
	}

	[Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
	public override bool Equals(object obj)
	{
		return false;
	}

	[Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
	public override int GetHashCode()
	{
		return 0;
	}

	public static implicit operator ReadOnlySpan<T>(T[] array)
	{
		return default(ReadOnlySpan<T>);
	}
}
