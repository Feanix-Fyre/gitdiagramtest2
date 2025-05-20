using System.Runtime.CompilerServices;

namespace System;

public static class MemoryExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool EqualsOrdinal(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static bool EqualsOrdinalIgnoreCase(this ReadOnlySpan<char> span, ReadOnlySpan<char> value)
	{
		return false;
	}

	internal static bool Contains(this ReadOnlySpan<char> source, char value)
	{
		return false;
	}

	public static int ToUpperInvariant(this ReadOnlySpan<char> source, Span<char> destination)
	{
		return 0;
	}

	public static bool EndsWith(this ReadOnlySpan<char> span, ReadOnlySpan<char> value, StringComparison comparisonType)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Span<T> AsSpan<T>(this T[] array, int start)
	{
		return default(Span<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ReadOnlySpan<char> AsSpan(this string text)
	{
		return default(ReadOnlySpan<char>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ReadOnlySpan<char> AsSpan(this string text, int start)
	{
		return default(ReadOnlySpan<char>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ReadOnlySpan<char> AsSpan(this string text, int start, int length)
	{
		return default(ReadOnlySpan<char>);
	}

	public static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> span)
	{
		return default(ReadOnlySpan<char>);
	}

	public static ReadOnlySpan<char> TrimStart(this ReadOnlySpan<char> span)
	{
		return default(ReadOnlySpan<char>);
	}

	public static ReadOnlySpan<char> TrimEnd(this ReadOnlySpan<char> span)
	{
		return default(ReadOnlySpan<char>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int IndexOf<T>(this ReadOnlySpan<T> span, T value) where T : IEquatable<T>
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int IndexOfAny<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> values) where T : IEquatable<T>
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool SequenceEqual<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> other) where T : IEquatable<T>
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool StartsWith<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value) where T : IEquatable<T>
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool EndsWith<T>(this ReadOnlySpan<T> span, ReadOnlySpan<T> value) where T : IEquatable<T>
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Span<T> AsSpan<T>(this T[] array, int start, int length)
	{
		return default(Span<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void CopyTo<T>(this T[] source, Span<T> destination)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsTypeComparableAsBytes<T>(out ulong size)
	{
		size = default(ulong);
		return false;
	}
}
