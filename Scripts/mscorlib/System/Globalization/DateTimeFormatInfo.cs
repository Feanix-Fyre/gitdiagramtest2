using System.Runtime.CompilerServices;

namespace System.Globalization;

/// <summary>Provides culture-specific information about the format of date and time values.</summary>
[Serializable]
public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable
{
	internal class TokenHashValue
	{
		internal string tokenString;

		internal TokenType tokenType;

		internal int tokenValue;

		internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
		{
		}
	}

	private static DateTimeFormatInfo s_invariantInfo;

	[NonSerialized]
	private CultureData _cultureData;

	private string _name;

	[NonSerialized]
	private string _langName;

	[NonSerialized]
	private CompareInfo _compareInfo;

	[NonSerialized]
	private CultureInfo _cultureInfo;

	private string amDesignator;

	private string pmDesignator;

	private string dateSeparator;

	private string generalShortTimePattern;

	private string generalLongTimePattern;

	private string timeSeparator;

	private string monthDayPattern;

	private string dateTimeOffsetPattern;

	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";

	private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";

	private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";

	private Calendar calendar;

	private int firstDayOfWeek;

	private int calendarWeekRule;

	private string fullDateTimePattern;

	private string[] abbreviatedDayNames;

	private string[] m_superShortDayNames;

	private string[] dayNames;

	private string[] abbreviatedMonthNames;

	private string[] monthNames;

	private string[] genitiveMonthNames;

	private string[] m_genitiveAbbreviatedMonthNames;

	private string[] leapYearMonthNames;

	private string longDatePattern;

	private string shortDatePattern;

	private string yearMonthPattern;

	private string longTimePattern;

	private string shortTimePattern;

	private string[] allYearMonthPatterns;

	private string[] allShortDatePatterns;

	private string[] allLongDatePatterns;

	private string[] allShortTimePatterns;

	private string[] allLongTimePatterns;

	private string[] m_eraNames;

	private string[] m_abbrevEraNames;

	private string[] m_abbrevEnglishEraNames;

	private CalendarId[] optionalCalendars;

	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;

	internal bool _isReadOnly;

	private DateTimeFormatFlags formatFlags;

	private static readonly char[] s_monthSpaces;

	internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";

	internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";

	private string _fullTimeSpanPositivePattern;

	private string _fullTimeSpanNegativePattern;

	internal const DateTimeStyles InvalidDateTimeStyles = ~(DateTimeStyles.AllowWhiteSpaces | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind);

	[NonSerialized]
	private TokenHashValue[] _dtfiTokenHash;

	private const int TOKEN_HASH_SIZE = 199;

	private const int SECOND_PRIME = 197;

	private const string dateSeparatorOrTimeZoneOffset = "-";

	private const string invariantDateSeparator = "/";

	private const string invariantTimeSeparator = ":";

	internal const string IgnorablePeriod = ".";

	internal const string IgnorableComma = ",";

	internal const string CJKYearSuff = "年";

	internal const string CJKMonthSuff = "月";

	internal const string CJKDaySuff = "日";

	internal const string KoreanYearSuff = "년";

	internal const string KoreanMonthSuff = "월";

	internal const string KoreanDaySuff = "일";

	internal const string KoreanHourSuff = "시";

	internal const string KoreanMinuteSuff = "분";

	internal const string KoreanSecondSuff = "초";

	internal const string CJKHourSuff = "時";

	internal const string ChineseHourSuff = "时";

	internal const string CJKMinuteSuff = "分";

	internal const string CJKSecondSuff = "秒";

	internal const string JapaneseEraStart = "元";

	internal const string LocalTimeMark = "T";

	internal const string GMTName = "GMT";

	internal const string ZuluName = "Z";

	internal const string KoreanLangName = "ko";

	internal const string JapaneseLangName = "ja";

	internal const string EnglishLangName = "en";

	private static DateTimeFormatInfo s_jajpDTFI;

	private static DateTimeFormatInfo s_zhtwDTFI;

	private string CultureName => null;

	private CultureInfo Culture => null;

	private string LanguageName => null;

	/// <summary>Gets the default read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object that is culture-independent (invariant).</summary>
	/// <returns>A read-only object that is culture-independent (invariant).</returns>
	public static DateTimeFormatInfo InvariantInfo => null;

	/// <summary>Gets a read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object that formats values based on the current culture.</summary>
	/// <returns>A read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object based on the <see cref="T:System.Globalization.CultureInfo" /> object for the current thread.</returns>
	public static DateTimeFormatInfo CurrentInfo => null;

	/// <summary>Gets or sets the string designator for hours that are "ante meridiem" (before noon).</summary>
	/// <returns>The string designator for hours that are ante meridiem. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "AM".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string AMDesignator => null;

	/// <summary>Gets or sets the calendar to use for the current culture.</summary>
	/// <returns>The calendar to use for the current culture. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is a <see cref="T:System.Globalization.GregorianCalendar" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is being set to a <see cref="T:System.Globalization.Calendar" /> object that is not valid for the current culture.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public Calendar Calendar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private CalendarId[] OptionalCalendars => null;

	internal string[] EraNames => null;

	internal string[] AbbreviatedEraNames => null;

	internal string[] AbbreviatedEnglishEraNames => null;

	/// <summary>Gets or sets the string that separates the components of a date, that is, the year, month, and day.</summary>
	/// <returns>The string that separates the components of a date, that is, the year, month, and day. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "/".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string DateSeparator => null;

	/// <summary>Gets or sets the custom format string for a long date and long time value.</summary>
	/// <returns>The custom format string for a long date and long time value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string FullDateTimePattern => null;

	/// <summary>Gets or sets the custom format string for a long date value.</summary>
	/// <returns>The custom format string for a long date value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string LongDatePattern => null;

	/// <summary>Gets or sets the custom format string for a long time value.</summary>
	/// <returns>The format pattern for a long time value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string LongTimePattern => null;

	/// <summary>Gets or sets the custom format string for a month and day value.</summary>
	/// <returns>The custom format string for a month and day value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string MonthDayPattern => null;

	/// <summary>Gets or sets the string designator for hours that are "post meridiem" (after noon).</summary>
	/// <returns>The string designator for hours that are "post meridiem" (after noon). The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "PM".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string PMDesignator => null;

	/// <summary>Gets the custom format string for a time value that is based on the Internet Engineering Task Force (IETF) Request for Comments (RFC) 1123 specification.</summary>
	/// <returns>The custom format string for a time value that is based on the IETF RFC 1123 specification.</returns>
	public string RFC1123Pattern => null;

	/// <summary>Gets or sets the custom format string for a short date value.</summary>
	/// <returns>The custom format string for a short date value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string ShortDatePattern => null;

	/// <summary>Gets or sets the custom format string for a short time value.</summary>
	/// <returns>The custom format string for a short time value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string ShortTimePattern => null;

	/// <summary>Gets the custom format string for a sortable date and time value.</summary>
	/// <returns>The custom format string for a sortable date and time value.</returns>
	public string SortableDateTimePattern => null;

	internal string GeneralShortTimePattern => null;

	internal string GeneralLongTimePattern => null;

	internal string DateTimeOffsetPattern => null;

	/// <summary>Gets or sets the string that separates the components of time, that is, the hour, minutes, and seconds.</summary>
	/// <returns>The string that separates the components of time. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is ":".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string TimeSeparator => null;

	/// <summary>Gets the custom format string for a universal, sortable date and time string.</summary>
	/// <returns>The custom format string for a universal, sortable date and time string.</returns>
	public string UniversalSortableDateTimePattern => null;

	/// <summary>Gets or sets the custom format string for a year and month value.</summary>
	/// <returns>The custom format string for a year and month value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string YearMonthPattern => null;

	/// <summary>Gets or sets a one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific abbreviated names of the days of the week.</summary>
	/// <returns>A one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific abbreviated names of the days of the week. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", and "Sat".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 7.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string[] AbbreviatedDayNames => null;

	/// <summary>Gets or sets a one-dimensional string array that contains the culture-specific full names of the days of the week.</summary>
	/// <returns>A one-dimensional string array that contains the culture-specific full names of the days of the week. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", and "Saturday".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 7.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string[] DayNames => null;

	/// <summary>Gets or sets a one-dimensional string array that contains the culture-specific abbreviated names of the months.</summary>
	/// <returns>A one-dimensional string array with 13 elements that contains the culture-specific abbreviated names of the months. For 12-month calendars, the 13th element of the array is an empty string. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", and "".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 13.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string[] AbbreviatedMonthNames => null;

	/// <summary>Gets or sets a one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific full names of the months.</summary>
	/// <returns>A one-dimensional array of type <see cref="T:System.String" /> containing the culture-specific full names of the months. In a 12-month calendar, the 13th element of the array is an empty string. The array for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> contains "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", and "".</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is being set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The property is being set to an array that is multidimensional or that has a length that is not exactly 13.</exception>
	/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string[] MonthNames => null;

	internal bool HasSpacesInMonthNames => false;

	internal bool HasSpacesInDayNames => false;

	private string[] AllYearMonthPatterns => null;

	private string[] AllShortDatePatterns => null;

	private string[] AllShortTimePatterns => null;

	private string[] AllLongDatePatterns => null;

	private string[] AllLongTimePatterns => null;

	private string[] UnclonedYearMonthPatterns => null;

	private string[] UnclonedShortDatePatterns => null;

	private string[] UnclonedLongDatePatterns => null;

	private string[] UnclonedShortTimePatterns => null;

	private string[] UnclonedLongTimePatterns => null;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only; otherwise, <see langword="false" />.</returns>
	public bool IsReadOnly => false;

	/// <summary>Gets or sets a string array of month names associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
	/// <returns>A string array of month names.</returns>
	/// <exception cref="T:System.ArgumentException">In a set operation, the array is multidimensional or has a length that is not exactly 13.</exception>
	/// <exception cref="T:System.ArgumentNullException">In a set operation, the array or one of its elements is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</exception>
	public string[] MonthGenitiveNames => null;

	internal string FullTimeSpanPositivePattern => null;

	internal string FullTimeSpanNegativePattern => null;

	internal CompareInfo CompareInfo => null;

	internal DateTimeFormatFlags FormatFlags => default(DateTimeFormatFlags);

	internal bool HasForceTwoDigitYears => false;

	internal bool HasYearMonthAdjustment => false;

	private string[] internalGetAbbreviatedDayOfWeekNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] internalGetAbbreviatedDayOfWeekNamesCore()
	{
		return null;
	}

	private string[] internalGetDayOfWeekNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] internalGetDayOfWeekNamesCore()
	{
		return null;
	}

	private string[] internalGetAbbreviatedMonthNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] internalGetAbbreviatedMonthNamesCore()
	{
		return null;
	}

	private string[] internalGetMonthNames()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] internalGetMonthNamesCore()
	{
		return null;
	}

	/// <summary>Initializes a new writable instance of the <see cref="T:System.Globalization.DateTimeFormatInfo" /> class that is culture-independent (invariant).</summary>
	public DateTimeFormatInfo()
	{
	}

	internal DateTimeFormatInfo(CultureData cultureData, Calendar cal)
	{
	}

	private void InitializeOverridableProperties(CultureData cultureData, int calendarId)
	{
	}

	/// <summary>Returns the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object associated with the specified <see cref="T:System.IFormatProvider" />.</summary>
	/// <param name="provider">The <see cref="T:System.IFormatProvider" /> that gets the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.  
	///  -or-  
	///  <see langword="null" /> to get <see cref="P:System.Globalization.DateTimeFormatInfo.CurrentInfo" />.</param>
	/// <returns>A <see cref="T:System.Globalization.DateTimeFormatInfo" /> object associated with <see cref="T:System.IFormatProvider" />.</returns>
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Returns an object of the specified type that provides a date and time  formatting service.</summary>
	/// <param name="formatType">The type of the required formatting service.</param>
	/// <returns>The current  object, if <paramref name="formatType" /> is the same as the type of the current <see cref="T:System.Globalization.DateTimeFormatInfo" />; otherwise, <see langword="null" />.</returns>
	public object GetFormat(Type formatType)
	{
		return null;
	}

	/// <summary>Creates a shallow copy of the <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
	/// <returns>A new <see cref="T:System.Globalization.DateTimeFormatInfo" /> object copied from the original <see cref="T:System.Globalization.DateTimeFormatInfo" />.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Returns the string containing the name of the specified era.</summary>
	/// <param name="era">The integer representing the era.</param>
	/// <returns>A string containing the name of the era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="era" /> does not represent a valid era in the calendar specified in the <see cref="P:System.Globalization.DateTimeFormatInfo.Calendar" /> property.</exception>
	public string GetEraName(int era)
	{
		return null;
	}

	/// <summary>Returns the string containing the abbreviated name of the specified era, if an abbreviation exists.</summary>
	/// <param name="era">The integer representing the era.</param>
	/// <returns>A string containing the abbreviated name of the specified era, if an abbreviation exists.  
	///  -or-  
	///  A string containing the full name of the era, if an abbreviation does not exist.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="era" /> does not represent a valid era in the calendar specified in the <see cref="P:System.Globalization.DateTimeFormatInfo.Calendar" /> property.</exception>
	public string GetAbbreviatedEraName(int era)
	{
		return null;
	}

	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
	{
		return null;
	}

	private string[] internalGetGenitiveMonthNames(bool abbreviated)
	{
		return null;
	}

	internal string[] internalGetLeapYearMonthNames()
	{
		return null;
	}

	/// <summary>Returns the culture-specific abbreviated name of the specified day of the week based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
	/// <param name="dayofweek">A <see cref="T:System.DayOfWeek" /> value.</param>
	/// <returns>The culture-specific abbreviated name of the day of the week represented by <paramref name="dayofweek" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="dayofweek" /> is not a valid <see cref="T:System.DayOfWeek" /> value.</exception>
	public string GetAbbreviatedDayName(DayOfWeek dayofweek)
	{
		return null;
	}

	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString)
	{
		return null;
	}

	/// <summary>Returns all the patterns in which date and time values can be formatted using the specified standard format string.</summary>
	/// <param name="format">A standard format string.</param>
	/// <returns>An array containing the standard patterns in which date and time values can be formatted using the specified format string.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="format" /> is not a valid standard format string.</exception>
	public string[] GetAllDateTimePatterns(char format)
	{
		return null;
	}

	/// <summary>Returns the culture-specific full name of the specified day of the week based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
	/// <param name="dayofweek">A <see cref="T:System.DayOfWeek" /> value.</param>
	/// <returns>The culture-specific full name of the day of the week represented by <paramref name="dayofweek" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="dayofweek" /> is not a valid <see cref="T:System.DayOfWeek" /> value.</exception>
	public string GetDayName(DayOfWeek dayofweek)
	{
		return null;
	}

	/// <summary>Returns the culture-specific abbreviated name of the specified month based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
	/// <param name="month">An integer from 1 through 13 representing the name of the month to retrieve.</param>
	/// <returns>The culture-specific abbreviated name of the month represented by <paramref name="month" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="month" /> is less than 1 or greater than 13.</exception>
	public string GetAbbreviatedMonthName(int month)
	{
		return null;
	}

	/// <summary>Returns the culture-specific full name of the specified month based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
	/// <param name="month">An integer from 1 through 13 representing the name of the month to retrieve.</param>
	/// <returns>The culture-specific full name of the month represented by <paramref name="month" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="month" /> is less than 1 or greater than 13.</exception>
	public string GetMonthName(int month)
	{
		return null;
	}

	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern)
	{
		return null;
	}

	internal static void ValidateStyles(DateTimeStyles style, string parameterName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private DateTimeFormatFlags InitializeFormatFlags()
	{
		return default(DateTimeFormatFlags);
	}

	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
	{
		return false;
	}

	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI()
	{
		return null;
	}

	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI()
	{
		return null;
	}

	private void ClearTokenHashTable()
	{
	}

	internal TokenHashValue[] CreateTokenHashTable()
	{
		return null;
	}

	private void PopulateSpecialTokenHashTable(TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol)
	{
	}

	private static bool IsJapaneseCalendar(Calendar calendar)
	{
		return false;
	}

	private void AddMonthNames(TokenHashValue[] temp, string monthPostfix)
	{
	}

	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
	{
		badFormat = default(bool);
		number = default(int);
		return false;
	}

	private static bool IsHebrewChar(char ch)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
	{
		return false;
	}

	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
	{
		tokenType = default(TokenType);
		tokenValue = default(int);
		return false;
	}

	private void InsertAtCurrentHashNode(TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
	{
	}

	private void InsertHash(TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue)
	{
	}

	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
	{
		return false;
	}
}
