using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace System;

internal static class DateTimeParse
{
	internal delegate bool MatchNumberDelegate(ref __DTString str, int digitLen, out int result);

	internal enum DTT
	{
		End = 0,
		NumEnd = 1,
		NumAmpm = 2,
		NumSpace = 3,
		NumDatesep = 4,
		NumTimesep = 5,
		MonthEnd = 6,
		MonthSpace = 7,
		MonthDatesep = 8,
		NumDatesuff = 9,
		NumTimesuff = 10,
		DayOfWeek = 11,
		YearSpace = 12,
		YearDateSep = 13,
		YearEnd = 14,
		TimeZone = 15,
		Era = 16,
		NumUTCTimeMark = 17,
		Unk = 18,
		NumLocalTimeMark = 19,
		Max = 20
	}

	internal enum TM
	{
		NotSet = -1,
		AM = 0,
		PM = 1
	}

	internal enum DS
	{
		BEGIN = 0,
		N = 1,
		NN = 2,
		D_Nd = 3,
		D_NN = 4,
		D_NNd = 5,
		D_M = 6,
		D_MN = 7,
		D_NM = 8,
		D_MNd = 9,
		D_NDS = 10,
		D_Y = 11,
		D_YN = 12,
		D_YNd = 13,
		D_YM = 14,
		D_YMd = 15,
		D_S = 16,
		T_S = 17,
		T_Nt = 18,
		T_NNt = 19,
		ERROR = 20,
		DX_NN = 21,
		DX_NNN = 22,
		DX_MN = 23,
		DX_NM = 24,
		DX_MNN = 25,
		DX_DS = 26,
		DX_DSN = 27,
		DX_NDS = 28,
		DX_NNDS = 29,
		DX_YNN = 30,
		DX_YMN = 31,
		DX_YN = 32,
		DX_YM = 33,
		TX_N = 34,
		TX_NN = 35,
		TX_NNN = 36,
		TX_TS = 37,
		DX_NNY = 38
	}

	internal static MatchNumberDelegate m_hebrewNumberParser;

	private static DS[][] dateParsingStates;

	internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style)
	{
		return default(DateTime);
	}

	internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset)
	{
		offset = default(TimeSpan);
		return default(DateTime);
	}

	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result)
	{
		result = default(DateTime);
		return false;
	}

	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset)
	{
		result = default(DateTime);
		offset = default(TimeSpan);
		return false;
	}

	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
	{
		return false;
	}

	internal static DateTime ParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style)
	{
		return default(DateTime);
	}

	internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset)
	{
		result = default(DateTime);
		offset = default(TimeSpan);
		return false;
	}

	internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result)
	{
		return false;
	}

	private static bool MatchWord(ref __DTString str, string target)
	{
		return false;
	}

	private static bool GetTimeZoneName(ref __DTString str)
	{
		return false;
	}

	internal static bool IsDigit(char ch)
	{
		return false;
	}

	private static bool ParseFraction(ref __DTString str, out double result)
	{
		result = default(double);
		return false;
	}

	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result)
	{
		return false;
	}

	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result)
	{
		return false;
	}

	private static bool Lex(DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles)
	{
		return false;
	}

	private static Calendar GetJapaneseCalendarDefaultInstance()
	{
		return null;
	}

	internal static Calendar GetTaiwanCalendarDefaultInstance()
	{
		return null;
	}

	private static bool VerifyValidPunctuation(ref __DTString str)
	{
		return false;
	}

	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order)
	{
		order = default(int);
		return false;
	}

	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
	{
		order = default(int);
		return false;
	}

	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order)
	{
		order = default(int);
		return false;
	}

	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear)
	{
		adjustedYear = default(int);
		return false;
	}

	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day)
	{
		return false;
	}

	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year)
	{
		return false;
	}

	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year)
	{
		return false;
	}

	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month)
	{
		return false;
	}

	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles)
	{
	}

	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		return false;
	}

	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		return false;
	}

	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		return false;
	}

	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw)
	{
	}

	private static bool AdjustHour(ref int hour, TM timeMark)
	{
		return false;
	}

	private static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		return false;
	}

	private static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		return false;
	}

	private static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		return false;
	}

	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		return false;
	}

	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw)
	{
		return false;
	}

	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok)
	{
		return false;
	}

	internal static bool ProcessHebrewTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	internal static bool ProcessTerminalState(DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles)
	{
		return default(DateTime);
	}

	internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset)
	{
		offset = default(TimeSpan);
		return default(DateTime);
	}

	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result)
	{
		result = default(DateTime);
		return false;
	}

	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset)
	{
		result = default(DateTime);
		offset = default(TimeSpan);
		return false;
	}

	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result)
	{
		return false;
	}

	private static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly)
	{
		return false;
	}

	private static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles)
	{
		return false;
	}

	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result)
	{
		return false;
	}

	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly)
	{
		return false;
	}

	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result)
	{
		return false;
	}

	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number)
	{
		number = default(int);
		return false;
	}

	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result)
	{
		result = default(int);
		return false;
	}

	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result)
	{
		result = default(int);
		return false;
	}

	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result)
	{
		return false;
	}

	private static bool ParseSign(ref __DTString str, ref bool result)
	{
		return false;
	}

	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result)
	{
		return false;
	}

	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		return false;
	}

	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		return false;
	}

	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		return false;
	}

	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		return false;
	}

	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result)
	{
		return false;
	}

	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result)
	{
		return false;
	}

	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref TM result)
	{
		return false;
	}

	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result)
	{
		return false;
	}

	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles)
	{
		return default(DateTime);
	}

	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles)
	{
		return false;
	}

	private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi)
	{
		return false;
	}

	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result)
	{
		return false;
	}

	internal static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result, out int returnValue)
	{
		returnValue = default(int);
		return false;
	}

	private static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result)
	{
		return false;
	}

	private static Exception GetDateTimeParseException(ref DateTimeResult result)
	{
		return null;
	}
}
