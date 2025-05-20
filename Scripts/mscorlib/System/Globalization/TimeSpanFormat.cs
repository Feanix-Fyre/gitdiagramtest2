using System.Text;

namespace System.Globalization;

internal static class TimeSpanFormat
{
	internal enum Pattern
	{
		None = 0,
		Minimum = 1,
		Full = 2
	}

	internal struct FormatLiterals
	{
		internal string AppCompatLiteral;

		internal int dd;

		internal int hh;

		internal int mm;

		internal int ss;

		internal int ff;

		private string[] _literals;

		internal string Start => null;

		internal string DayHourSep => null;

		internal string HourMinuteSep => null;

		internal string MinuteSecondSep => null;

		internal string SecondFractionSep => null;

		internal string End => null;

		internal static FormatLiterals InitInvariant(bool isNegative)
		{
			return default(FormatLiterals);
		}

		internal void Init(ReadOnlySpan<char> format, bool useInvariantFieldLengths)
		{
		}
	}

	internal static readonly FormatLiterals PositiveInvariantFormatLiterals;

	internal static readonly FormatLiterals NegativeInvariantFormatLiterals;

	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits)
	{
	}

	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider)
	{
		return null;
	}

	internal static bool TryFormat(TimeSpan value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider)
	{
		charsWritten = default(int);
		return false;
	}

	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<char> format, IFormatProvider formatProvider)
	{
		return null;
	}

	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<char> format, Pattern pattern)
	{
		return null;
	}

	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, StringBuilder result)
	{
		return null;
	}
}
