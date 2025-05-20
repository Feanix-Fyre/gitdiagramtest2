using System.Globalization;
using System.Text;

namespace System.Numerics;

internal static class BigNumber
{
	private struct BigNumberBuffer
	{
		public StringBuilder digits;

		public int precision;

		public int scale;

		public bool sign;

		public static BigNumberBuffer Create()
		{
			return default(BigNumberBuffer);
		}
	}

	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e)
	{
		e = null;
		return false;
	}

	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result)
	{
		result = default(BigInteger);
		return false;
	}

	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info)
	{
		return default(BigInteger);
	}

	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info)
	{
		return default(BigInteger);
	}

	private static bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value)
	{
		return false;
	}

	private static bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value)
	{
		return false;
	}

	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
	{
		digits = default(int);
		return '\0';
	}

	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
	{
		charsWritten = default(int);
		spanSuccess = default(bool);
		return null;
	}

	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info)
	{
		return null;
	}

	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess)
	{
		charsWritten = default(int);
		spanSuccess = default(bool);
		return null;
	}
}
