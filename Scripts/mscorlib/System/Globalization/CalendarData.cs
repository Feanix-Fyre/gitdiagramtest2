using System.Runtime.InteropServices;

namespace System.Globalization;

[StructLayout((LayoutKind)0)]
internal class CalendarData
{
	internal const int MAX_CALENDARS = 23;

	internal string sNativeName;

	internal string[] saShortDates;

	internal string[] saYearMonths;

	internal string[] saLongDates;

	internal string sMonthDay;

	internal string[] saEraNames;

	internal string[] saAbbrevEraNames;

	internal string[] saAbbrevEnglishEraNames;

	internal string[] saDayNames;

	internal string[] saAbbrevDayNames;

	internal string[] saSuperShortDayNames;

	internal string[] saMonthNames;

	internal string[] saAbbrevMonthNames;

	internal string[] saMonthGenitiveNames;

	internal string[] saAbbrevMonthGenitiveNames;

	internal string[] saLeapYearMonthNames;

	internal int iTwoDigitYearMax;

	internal int iCurrentEra;

	internal bool bUseUserOverrides;

	internal static CalendarData Invariant;

	private static string[] HEBREW_MONTH_NAMES;

	private static string[] HEBREW_LEAP_MONTH_NAMES;

	private CalendarData()
	{
	}

	static CalendarData()
	{
	}

	internal CalendarData(string localeName, int calendarId, bool bUseUserOverrides)
	{
	}

	private void InitializeEraNames(string localeName, int calendarId)
	{
	}

	private static string[] GetJapaneseEraNames()
	{
		return null;
	}

	private static string[] GetJapaneseEnglishEraNames()
	{
		return null;
	}

	private void InitializeAbbreviatedEraNames(string localeName, int calendarId)
	{
	}

	internal static CalendarData GetCalendarData(int calendarId)
	{
		return null;
	}

	private static string CalendarIdToCultureName(int calendarId)
	{
		return null;
	}

	public static int nativeGetTwoDigitYearMax(int calID)
	{
		return 0;
	}

	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId)
	{
		return false;
	}

	private bool fill_calendar_data(string localeName, int datetimeIndex)
	{
		return false;
	}
}
