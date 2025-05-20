using System.Runtime.CompilerServices;

namespace System;

internal static class ParseNumbers
{
	public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags)
	{
		return 0L;
	}

	public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
	{
		return 0L;
	}

	public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags)
	{
		return 0;
	}

	public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags, ref int currPos)
	{
		return 0;
	}

	public static string IntToString(int n, int radix, int width, char paddingChar, int flags)
	{
		return null;
	}

	public static string LongToString(long n, int radix, int width, char paddingChar, int flags)
	{
		return null;
	}

	private static void EatWhiteSpace(ReadOnlySpan<char> s, ref int i)
	{
	}

	private static long GrabLongs(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
	{
		return 0L;
	}

	private static int GrabInts(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned)
	{
		return 0;
	}

	private static void ThrowOverflowInt32Exception()
	{
	}

	private static void ThrowOverflowInt64Exception()
	{
	}

	private static void ThrowOverflowUInt32Exception()
	{
	}

	private static void ThrowOverflowUInt64Exception()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool IsDigit(char c, int radix, out int result)
	{
		result = default(int);
		return false;
	}
}
