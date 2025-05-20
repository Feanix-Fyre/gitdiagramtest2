namespace System.Globalization;

internal static class TimeSpanParse
{
	private enum ParseFailureKind : byte
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		Overflow = 4
	}

	[Flags]
	private enum TimeSpanStandardStyles : byte
	{
		None = 0,
		Invariant = 1,
		Localized = 2,
		RequireFull = 4,
		Any = 3
	}

	private enum TTT : byte
	{
		None = 0,
		End = 1,
		Num = 2,
		Sep = 3,
		NumOverflow = 4
	}

	private ref struct TimeSpanToken
	{
		internal TTT _ttt;

		internal int _num;

		internal int _zeroes;

		internal ReadOnlySpan<char> _sep;

		public TimeSpanToken(TTT type)
		{
			_ttt = default(TTT);
			_num = 0;
			_zeroes = 0;
			_sep = default(ReadOnlySpan<char>);
		}

		public TimeSpanToken(int number)
		{
			_ttt = default(TTT);
			_num = 0;
			_zeroes = 0;
			_sep = default(ReadOnlySpan<char>);
		}

		public TimeSpanToken(TTT type, int number, int leadingZeroes, ReadOnlySpan<char> separator)
		{
			_ttt = default(TTT);
			_num = 0;
			_zeroes = 0;
			_sep = default(ReadOnlySpan<char>);
		}

		public bool IsInvalidFraction()
		{
			return false;
		}
	}

	private ref struct TimeSpanTokenizer
	{
		private ReadOnlySpan<char> _value;

		private int _pos;

		internal TimeSpanTokenizer(ReadOnlySpan<char> input)
		{
			_value = default(ReadOnlySpan<char>);
			_pos = 0;
		}

		internal TimeSpanTokenizer(ReadOnlySpan<char> input, int startPosition)
		{
			_value = default(ReadOnlySpan<char>);
			_pos = 0;
		}

		internal TimeSpanToken GetNextToken()
		{
			return default(TimeSpanToken);
		}
	}

	private ref struct TimeSpanRawInfo
	{
		internal TTT _lastSeenTTT;

		internal int _tokenCount;

		internal int _sepCount;

		internal int _numCount;

		private TimeSpanFormat.FormatLiterals _posLoc;

		private TimeSpanFormat.FormatLiterals _negLoc;

		private bool _posLocInit;

		private bool _negLocInit;

		private string _fullPosPattern;

		private string _fullNegPattern;

		internal TimeSpanToken _numbers0;

		internal TimeSpanToken _numbers1;

		internal TimeSpanToken _numbers2;

		internal TimeSpanToken _numbers3;

		internal TimeSpanToken _numbers4;

		internal ReadOnlySpan<char> _literals0;

		internal ReadOnlySpan<char> _literals1;

		internal ReadOnlySpan<char> _literals2;

		internal ReadOnlySpan<char> _literals3;

		internal ReadOnlySpan<char> _literals4;

		internal ReadOnlySpan<char> _literals5;

		internal TimeSpanFormat.FormatLiterals PositiveInvariant => default(TimeSpanFormat.FormatLiterals);

		internal TimeSpanFormat.FormatLiterals NegativeInvariant => default(TimeSpanFormat.FormatLiterals);

		internal TimeSpanFormat.FormatLiterals PositiveLocalized => default(TimeSpanFormat.FormatLiterals);

		internal TimeSpanFormat.FormatLiterals NegativeLocalized => default(TimeSpanFormat.FormatLiterals);

		internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern)
		{
			return false;
		}

		internal void Init(DateTimeFormatInfo dtfi)
		{
		}

		internal bool ProcessToken(ref TimeSpanToken tok, ref TimeSpanResult result)
		{
			return false;
		}

		private bool AddSep(ReadOnlySpan<char> sep, ref TimeSpanResult result)
		{
			return false;
		}

		private bool AddNum(TimeSpanToken num, ref TimeSpanResult result)
		{
			return false;
		}
	}

	private struct TimeSpanResult
	{
		internal TimeSpan parsedTimeSpan;

		private readonly bool _throwOnFailure;

		internal TimeSpanResult(bool throwOnFailure)
		{
			parsedTimeSpan = default(TimeSpan);
			_throwOnFailure = false;
		}

		internal bool SetFailure(ParseFailureKind kind, string resourceKey, object messageArgument = null, string argumentName = null)
		{
			return false;
		}
	}

	internal static long Pow10(int pow)
	{
		return 0L;
	}

	private static bool TryTimeToTicks(bool positive, TimeSpanToken days, TimeSpanToken hours, TimeSpanToken minutes, TimeSpanToken seconds, TimeSpanToken fraction, out long result)
	{
		result = default(long);
		return false;
	}

	internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider)
	{
		return default(TimeSpan);
	}

	private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminalState(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_DHMSF(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_HM_S_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_HM(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}

	private static bool ProcessTerminal_D(ref TimeSpanRawInfo raw, TimeSpanStandardStyles style, ref TimeSpanResult result)
	{
		return false;
	}
}
