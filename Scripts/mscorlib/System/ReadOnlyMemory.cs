using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System;

[DebuggerTypeProxy(typeof(MemoryDebugView<>))]
[DebuggerDisplay("{ToString(),raw}")]
public readonly struct ReadOnlyMemory<T> : IEquatable<ReadOnlyMemory<T>>
{
	private readonly object _object;

	private readonly int _index;

	private readonly int _length;

	public int Length => 0;

	public ReadOnlySpan<T> Span
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(ReadOnlySpan<T>);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadOnlyMemory(T[] array)
	{
		_object = null;
		_index = 0;
		_length = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ReadOnlyMemory(T[] array, int start, int length)
	{
		_object = null;
		_index = 0;
		_length = 0;
	}

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(ReadOnlyMemory<T> other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	private static int CombineHashCodes(int left, int right)
	{
		return 0;
	}

	private static int CombineHashCodes(int h1, int h2, int h3)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal object GetObjectStartLength(out int start, out int length)
	{
		start = default(int);
		length = default(int);
		return null;
	}
}
