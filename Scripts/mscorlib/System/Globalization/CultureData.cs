using System.Runtime.InteropServices;

namespace System.Globalization;

[StructLayout((LayoutKind)0)]
internal class CultureData
{
	internal struct NumberFormatEntryManaged
	{
		internal int currency_decimal_digits;

		internal int currency_decimal_separator;

		internal int currency_group_separator;

		internal int currency_group_sizes0;

		internal int currency_group_sizes1;

		internal int currency_negative_pattern;

		internal int currency_positive_pattern;

		internal int currency_symbol;

		internal int nan_symbol;

		internal int negative_infinity_symbol;

		internal int negative_sign;

		internal int number_decimal_digits;

		internal int number_decimal_separator;

		internal int number_group_separator;

		internal int number_group_sizes0;

		internal int number_group_sizes1;

		internal int number_negative_pattern;

		internal int per_mille_symbol;

		internal int percent_negative_pattern;

		internal int percent_positive_pattern;

		internal int percent_symbol;

		internal int positive_infinity_symbol;

		internal int positive_sign;
	}

	private string sAM1159;

	private string sPM2359;

	private string sTimeSeparator;

	private string[] saLongTimes;

	private string[] saShortTimes;

	private int iFirstDayOfWeek;

	private int iFirstWeekOfYear;

	private int[] waCalendars;

	private CalendarData[] calendars;

	private string sISO639Language;

	private readonly string sRealName;

	private bool bUseOverrides;

	private int calendarId;

	private int numberIndex;

	private int iDefaultAnsiCodePage;

	private int iDefaultOemCodePage;

	private int iDefaultMacCodePage;

	private int iDefaultEbcdicCodePage;

	private bool isRightToLeft;

	private string sListSeparator;

	private static CultureData s_Invariant;

	public static CultureData Invariant => null;

	internal string[] LongTimes => null;

	internal string[] ShortTimes => null;

	internal string SISO639LANGNAME => null;

	internal int IFIRSTDAYOFWEEK => 0;

	internal int IFIRSTWEEKOFYEAR => 0;

	internal string SAM1159 => null;

	internal string SPM2359 => null;

	internal string TimeSeparator => null;

	internal int[] CalendarIds => null;

	internal bool IsInvariantCulture => false;

	internal string CultureName => null;

	internal string SCOMPAREINFO => null;

	internal string STEXTINFO => null;

	internal int IDEFAULTANSICODEPAGE => 0;

	internal bool IsRightToLeft => false;

	internal string SLIST => null;

	internal bool UseUserOverride => false;

	private CultureData(string name)
	{
	}

	public static CultureData GetCultureData(string cultureName, bool useUserOverride)
	{
		return null;
	}

	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator)
	{
		return null;
	}

	private void fill_culture_data(int datetimeIndex)
	{
	}

	public CalendarData GetCalendar(int calendarId)
	{
		return null;
	}

	internal CalendarId[] GetCalendarIds()
	{
		return null;
	}

	internal string[] EraNames(int calendarId)
	{
		return null;
	}

	internal string[] AbbrevEraNames(int calendarId)
	{
		return null;
	}

	internal string[] AbbreviatedEnglishEraNames(int calendarId)
	{
		return null;
	}

	internal string[] ShortDates(int calendarId)
	{
		return null;
	}

	internal string[] LongDates(int calendarId)
	{
		return null;
	}

	internal string[] YearMonths(int calendarId)
	{
		return null;
	}

	internal string[] DayNames(int calendarId)
	{
		return null;
	}

	internal string[] AbbreviatedDayNames(int calendarId)
	{
		return null;
	}

	internal string[] MonthNames(int calendarId)
	{
		return null;
	}

	internal string[] GenitiveMonthNames(int calendarId)
	{
		return null;
	}

	internal string[] AbbreviatedMonthNames(int calendarId)
	{
		return null;
	}

	internal string[] AbbreviatedGenitiveMonthNames(int calendarId)
	{
		return null;
	}

	internal string[] LeapYearMonthNames(int calendarId)
	{
		return null;
	}

	internal string MonthDay(int calendarId)
	{
		return null;
	}

	internal string DateSeparator(int calendarId)
	{
		return null;
	}

	private static string GetDateSeparator(string format)
	{
		return null;
	}

	private static string GetSeparator(string format, string timeParts)
	{
		return null;
	}

	private static int IndexOfTimePart(string format, int startIndex, string timeParts)
	{
		return 0;
	}

	private static string UnescapeNlsString(string str, int start, int end)
	{
		return null;
	}

	internal static string[] ReescapeWin32Strings(string[] array)
	{
		return null;
	}

	internal static string ReescapeWin32String(string str)
	{
		return null;
	}

	private unsafe static int strlen(byte* s)
	{
		return 0;
	}

	private unsafe static string idx2string(byte* data, int idx)
	{
		return null;
	}

	private int[] create_group_sizes_array(int gs0, int gs1)
	{
		return null;
	}

	internal void GetNFIValues(NumberFormatInfo nfi)
	{
	}

	private unsafe static byte* fill_number_data(int index, ref NumberFormatEntryManaged nfe)
	{
		return null;
	}
}
