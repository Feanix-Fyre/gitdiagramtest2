using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System;

internal static class SpanHelpers
{
	public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength)
	{
		return 0;
	}

	public static int IndexOf(ref byte searchSpace, byte value, int length)
	{
		return 0;
	}

	public static bool SequenceEqual(ref byte first, ref byte second, ulong length)
	{
		return false;
	}

	public static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength)
	{
		return 0;
	}

	public static int IndexOf(ref char searchSpace, char value, int length)
	{
		return 0;
	}

	public static int LastIndexOf(ref char searchSpace, char value, int length)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int LocateFirstFoundChar(Vector<ushort> match)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int LocateFirstFoundChar(ulong match)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int LocateLastFoundChar(Vector<ushort> match)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int LocateLastFoundChar(ulong match)
	{
		return 0;
	}

	public static int IndexOf<T>(ref T searchSpace, T value, int length) where T : IEquatable<T>
	{
		return 0;
	}

	public static int IndexOfAny<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) where T : IEquatable<T>
	{
		return 0;
	}

	public static bool SequenceEqual<T>(ref T first, ref T second, int length) where T : IEquatable<T>
	{
		return false;
	}

	public static bool EndsWithCultureHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
	{
		return false;
	}

	public static bool EndsWithCultureIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value, CompareInfo compareInfo)
	{
		return false;
	}

	public static bool EndsWithOrdinalIgnoreCaseHelper(ReadOnlySpan<char> span, ReadOnlySpan<char> value)
	{
		return false;
	}

	public static void ClearWithoutReferences(ref byte b, ulong byteLength)
	{
	}

	public static void ClearWithReferences(ref IntPtr ip, ulong pointerSizeLength)
	{
	}
}
