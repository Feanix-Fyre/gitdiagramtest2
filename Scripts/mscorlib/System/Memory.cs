using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System;

[DebuggerDisplay("{ToString(),raw}")]
[DebuggerTypeProxy(typeof(MemoryDebugView<>))]
public readonly struct Memory<T> : IEquatable<Memory<T>>
{
	private readonly object _object;

	private readonly int _index;

	private readonly int _length;

	private const int RemoveFlagsBitMask = int.MaxValue;

	public int Length => 0;

	public Span<T> Span
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return default(Span<T>);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Memory(T[] array)
	{
		_object = null;
		_index = 0;
		_length = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Memory(T[] array, int start, int length)
	{
		_object = null;
		_index = 0;
		_length = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal Memory(object obj, int start, int length)
	{
		_object = null;
		_index = 0;
		_length = 0;
	}

	public static implicit operator Memory<T>(T[] array)
	{
		return default(Memory<T>);
	}

	public static implicit operator ReadOnlyMemory<T>(Memory<T> memory)
	{
		return default(ReadOnlyMemory<T>);
	}

	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Memory<T> Slice(int start, int length)
	{
		return default(Memory<T>);
	}

	public MemoryHandle Pin()
	{
		return default(MemoryHandle);
	}

	public T[] ToArray()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Memory<T> other)
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
}
