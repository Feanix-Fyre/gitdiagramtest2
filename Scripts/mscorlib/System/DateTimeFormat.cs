using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace System;

internal static class DateTimeFormat
{
	internal static readonly TimeSpan NullOffset;

	internal static char[] allStandardFormats;

	internal static readonly DateTimeFormatInfo InvariantFormatInfo;

	internal static readonly string[] InvariantAbbreviatedMonthNames;

	internal static readonly string[] InvariantAbbreviatedDayNames;

	internal static string[] fixedNumberFormats;

	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len)
	{
	}

	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit)
	{
	}

	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits)
	{
	}

	internal static int ParseRepeatPattern(ReadOnlySpan<char> format, int pos, char patternChar)
	{
		return 0;
	}

	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi)
	{
		return null;
	}

	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi)
	{
		return null;
	}

	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi)
	{
		return null;
	}

	internal static int ParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result)
	{
		return 0;
	}

	internal static int ParseNextChar(ReadOnlySpan<char> format, int pos)
	{
		return 0;
	}

	private static bool IsUseGenitiveForm(ReadOnlySpan<char> format, int index, int tokenLen, char patternToMatch)
	{
		return false;
	}

	private static StringBuilder FormatCustomized(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset, StringBuilder result)
	{
		return null;
	}

	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, ReadOnlySpan<char> format, int tokenLen, bool timeOnly, StringBuilder result)
	{
	}

	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result)
	{
	}

	private static void Append2DigitNumber(StringBuilder result, int val)
	{
	}

	internal static string GetRealFormat(ReadOnlySpan<char> format, DateTimeFormatInfo dtfi)
	{
		return null;
	}

	private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset)
	{
		return null;
	}

	internal static string Format(DateTime dateTime, string format, IFormatProvider provider)
	{
		return null;
	}

	internal static string Format(DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset)
	{
		return null;
	}

	internal static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		charsWritten = default(int);
		return false;
	}

	internal static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, TimeSpan offset)
	{
		charsWritten = default(int);
		return false;
	}

	private static StringBuilder FormatStringBuilder(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset)
	{
		return null;
	}

	private static bool TryFormatO(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	private static bool TryFormatR(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten)
	{
		charsWritten = default(int);
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void WriteTwoDecimalDigits(uint value, Span<char> destination, int offset)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void WriteFourDecimalDigits(uint value, Span<char> buffer, int startingIndex = 0)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void WriteDigits(ulong value, Span<char> buffer)
	{
	}

	internal static void InvalidFormatForLocal(ReadOnlySpan<char> format, DateTime dateTime)
	{
	}
}
