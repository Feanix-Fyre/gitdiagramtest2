using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System;

internal static class Number
{
	[StructLayout((LayoutKind)0, Pack = 1, Size = 122)]
	internal ref struct NumberBuffer
	{
		[StructLayout((LayoutKind)0, Size = 102)]
		private struct DigitsAndNullTerminator
		{
		}

		public int precision;

		public int scale;

		private int _sign;

		private DigitsAndNullTerminator _digits;

		private unsafe char* _allDigits;

		public bool sign
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public unsafe char* digits => null;
	}

	private static readonly string[] s_posCurrencyFormats;

	private static readonly string[] s_negCurrencyFormats;

	private static readonly string[] s_posPercentFormats;

	private static readonly string[] s_negPercentFormats;

	private static readonly string[] s_negNumberFormats;

	private static readonly int[] s_charToHexLookup;

	private static readonly ulong[] s_rgval64Power10;

	private static readonly sbyte[] s_rgexp64Power10;

	private static readonly ulong[] s_rgval64Power10By16;

	private static readonly short[] s_rgexp64Power10By16;

	public static string FormatDecimal(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info)
	{
		return null;
	}

	public static bool TryFormatDecimal(decimal value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	private static void DecimalToNumber(decimal value, ref NumberBuffer number)
	{
	}

	public static string FormatDouble(double value, string format, NumberFormatInfo info)
	{
		return null;
	}

	public static bool TryFormatDouble(double value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	private static string FormatDouble(ref ValueStringBuilder sb, double value, ReadOnlySpan<char> format, NumberFormatInfo info)
	{
		return null;
	}

	public static string FormatSingle(float value, string format, NumberFormatInfo info)
	{
		return null;
	}

	public static bool TryFormatSingle(float value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	private static string FormatSingle(ref ValueStringBuilder sb, float value, ReadOnlySpan<char> format, NumberFormatInfo info)
	{
		return null;
	}

	private static bool TryCopyTo(string source, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	public static string FormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		return null;
	}

	public static bool TryFormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	public static string FormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		return null;
	}

	public static bool TryFormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	public static string FormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		return null;
	}

	public static bool TryFormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	public static string FormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		return null;
	}

	public static bool TryFormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void Int32ToNumber(int value, ref NumberBuffer number)
	{
	}

	private static string NegativeInt32ToDecStr(int value, int digits, string sNegative)
	{
		return null;
	}

	private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	private static string Int32ToHexStr(int value, char hexBase, int digits)
	{
		return null;
	}

	private static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	private unsafe static char* Int32ToHexChars(char* buffer, uint value, int hexBase, int digits)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void UInt32ToNumber(uint value, ref NumberBuffer number)
	{
	}

	internal unsafe static char* UInt32ToDecChars(char* bufferEnd, uint value, int digits)
	{
		return null;
	}

	private static string UInt32ToDecStr(uint value, int digits)
	{
		return null;
	}

	private static bool TryUInt32ToDecStr(uint value, int digits, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	private static void Int64ToNumber(long input, ref NumberBuffer number)
	{
	}

	private static string NegativeInt64ToDecStr(long input, int digits, string sNegative)
	{
		return null;
	}

	private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	private static string Int64ToHexStr(long value, char hexBase, int digits)
	{
		return null;
	}

	private static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	private static void UInt64ToNumber(ulong value, ref NumberBuffer number)
	{
	}

	private static string UInt64ToDecStr(ulong value, int digits)
	{
		return null;
	}

	private static bool TryUInt64ToDecStr(ulong value, int digits, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
	{
		digits = default(int);
		return '\0';
	}

	internal static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
	{
	}

	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
	{
	}

	private static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
	{
	}

	private static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup)
	{
	}

	private static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
	{
	}

	private static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
	{
	}

	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
	{
	}

	private static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
	{
	}

	private static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
	{
	}

	private static void RoundNumber(ref NumberBuffer number, int pos)
	{
	}

	private static int FindSection(ReadOnlySpan<char> format, int section)
	{
		return 0;
	}

	private static uint Low32(ulong value)
	{
		return 0u;
	}

	private static uint High32(ulong value)
	{
		return 0u;
	}

	private static uint Int64DivMod1E9(ref ulong value)
	{
		return 0u;
	}

	private static bool NumberToInt32(ref NumberBuffer number, ref int value)
	{
		return false;
	}

	private static bool NumberToInt64(ref NumberBuffer number, ref long value)
	{
		return false;
	}

	private static bool NumberToUInt32(ref NumberBuffer number, ref uint value)
	{
		return false;
	}

	private static bool NumberToUInt64(ref NumberBuffer number, ref ulong value)
	{
		return false;
	}

	internal static int ParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		return 0;
	}

	internal static long ParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		return 0L;
	}

	internal static uint ParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		return 0u;
	}

	internal static ulong ParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		return 0uL;
	}

	private unsafe static bool ParseNumber(ref char* str, char* strEnd, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
	{
		return false;
	}

	internal static bool TryParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result)
	{
		result = default(int);
		return false;
	}

	private static bool TryParseInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result, ref bool failureIsOverflow)
	{
		result = default(int);
		return false;
	}

	private static bool TryParseInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result, ref bool failureIsOverflow)
	{
		result = default(long);
		return false;
	}

	internal static bool TryParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result)
	{
		result = default(long);
		return false;
	}

	internal static bool TryParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result)
	{
		result = default(uint);
		return false;
	}

	private static bool TryParseUInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
	{
		result = default(uint);
		return false;
	}

	private static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow)
	{
		result = default(uint);
		return false;
	}

	internal static bool TryParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result)
	{
		result = default(ulong);
		return false;
	}

	private static bool TryParseUInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
	{
		result = default(ulong);
		return false;
	}

	private static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow)
	{
		result = default(ulong);
		return false;
	}

	internal static decimal ParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		return default(decimal);
	}

	private static bool NumberBufferToDecimal(ref NumberBuffer number, ref decimal value)
	{
		return false;
	}

	internal static double ParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		return 0.0;
	}

	internal static float ParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info)
	{
		return 0f;
	}

	internal static bool TryParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out decimal result)
	{
		result = default(decimal);
		return false;
	}

	internal static bool TryParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out double result)
	{
		result = default(double);
		return false;
	}

	internal static bool TryParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out float result)
	{
		result = default(float);
		return false;
	}

	private static void StringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
	{
	}

	internal static bool TryStringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref NumberBuffer number, NumberFormatInfo info, bool parseDecimal)
	{
		return false;
	}

	private static bool TrailingZeros(ReadOnlySpan<char> value, int index)
	{
		return false;
	}

	private unsafe static char* MatchChars(char* p, char* pEnd, string value)
	{
		return null;
	}

	private static bool IsWhite(int ch)
	{
		return false;
	}

	private static bool IsDigit(int ch)
	{
		return false;
	}

	private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey)
	{
	}

	private static bool NumberBufferToDouble(ref NumberBuffer number, ref double value)
	{
		return false;
	}

	private unsafe static uint DigitsToInt(char* p, int count)
	{
		return 0u;
	}

	private static ulong Mul32x32To64(uint a, uint b)
	{
		return 0uL;
	}

	private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp)
	{
		return 0uL;
	}

	private static int abs(int value)
	{
		return 0;
	}

	private static double NumberToDouble(ref NumberBuffer number)
	{
		return 0.0;
	}

	private static void DoubleToNumber(double value, int precision, ref NumberBuffer number)
	{
	}
}
