using System.Text;

namespace System.Globalization;

internal class FormatProvider
{
	private class Number
	{
		internal struct NumberBuffer
		{
			public int precision;

			public int scale;

			public bool sign;

			public unsafe char* overrideDigits;

			public unsafe char* digits => null;
		}

		private static string[] s_posCurrencyFormats;

		private static string[] s_negCurrencyFormats;

		private static string[] s_posPercentFormats;

		private static string[] s_negPercentFormats;

		private static string[] s_negNumberFormats;

		private static string s_posNumberFormat;

		private static bool IsWhite(char ch)
		{
			return false;
		}

		private unsafe static char* MatchChars(char* p, char* pEnd, string str)
		{
			return null;
		}

		private unsafe static char* MatchChars(char* p, char* pEnd, char* str)
		{
			return null;
		}

		private unsafe static bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
		{
			return false;
		}

		private static bool TrailingZeros(ReadOnlySpan<char> s, int index)
		{
			return false;
		}

		internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal)
		{
			return false;
		}

		internal unsafe static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits)
		{
		}

		internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
		{
			digits = default(int);
			return '\0';
		}

		internal static void NumberToString(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
		{
		}

		private static void FormatCurrency(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
		}

		private unsafe static int wcslen(char* s)
		{
			return 0;
		}

		private static void FormatFixed(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup)
		{
		}

		private static void FormatNumber(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
		}

		private static void FormatScientific(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
		{
		}

		private static void FormatExponent(ref System.Text.ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
		{
		}

		private static void FormatGeneral(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
		{
		}

		private static void FormatPercent(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
		}

		private static void RoundNumber(ref NumberBuffer number, int pos)
		{
		}

		private static int FindSection(ReadOnlySpan<char> format, int section)
		{
			return 0;
		}

		internal static void NumberToStringFormat(ref System.Text.ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
		{
		}
	}

	internal static void FormatBigInteger(ref System.Text.ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex)
	{
	}

	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign)
	{
		precision = default(int);
		scale = default(int);
		sign = default(bool);
		return false;
	}
}
