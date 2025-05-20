namespace System.Globalization;

/// <summary>Represents the Saudi Hijri (Um Al Qura) calendar.</summary>
[Serializable]
public class UmAlQuraCalendar : Calendar
{
	internal struct DateMapping
	{
		internal int HijriMonthsLengthFlags;

		internal DateTime GregorianDate;

		internal DateMapping(int MonthsLengthFlags, int GYear, int GMonth, int GDay)
		{
			HijriMonthsLengthFlags = 0;
			GregorianDate = default(DateTime);
		}
	}

	private static readonly DateMapping[] HijriYearInfo;

	internal static DateTime minDate;

	internal static DateTime maxDate;

	/// <summary>Gets the earliest date and time supported by this calendar.</summary>
	/// <returns>The earliest date and time supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class, which is equivalent to the first moment of April 30, 1900 C.E. in the Gregorian calendar.</returns>
	public override DateTime MinSupportedDateTime => default(DateTime);

	/// <summary>Gets the latest date and time supported by this calendar.</summary>
	/// <returns>The latest date and time supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class, which is equivalent to the last moment of November 16, 2077 C.E. in the Gregorian calendar.</returns>
	public override DateTime MaxSupportedDateTime => default(DateTime);

	internal override int BaseCalendarID => 0;

	internal override int ID => 0;

	/// <summary>Gets a list of the eras that are supported by the current <see cref="T:System.Globalization.UmAlQuraCalendar" />.</summary>
	/// <returns>An array that consists of a single element having a value that is <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</returns>
	public override int[] Eras => null;

	/// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary>
	/// <returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns>
	/// <exception cref="T:System.InvalidOperationException">This calendar is read-only.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the Um Al Qura calendar year value is less than 1318 but not 99, or is greater than 1450.</exception>
	public override int TwoDigitYearMax
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private static DateMapping[] InitDateMapping()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class.</summary>
	public UmAlQuraCalendar()
	{
	}

	private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg)
	{
	}

	private static long GetAbsoluteDateUmAlQura(int year, int month, int day)
	{
		return 0L;
	}

	internal static void CheckTicksRange(long ticks)
	{
	}

	internal static void CheckEraRange(int era)
	{
	}

	internal static void CheckYearRange(int year, int era)
	{
	}

	internal static void CheckYearMonthRange(int year, int month, int era)
	{
	}

	private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay)
	{
	}

	internal virtual int GetDatePart(DateTime time, int part)
	{
		return 0;
	}

	/// <summary>Calculates the day of the month on which a specified date occurs.</summary>
	/// <param name="time">The date value to read. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 11/16/2077 23:59:59 (Gregorian date).</param>
	/// <returns>An integer from 1 through 30 that represents the day of the month specified by the <paramref name="time" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="time" /> is outside the range supported by this calendar.</exception>
	public override int GetDayOfMonth(DateTime time)
	{
		return 0;
	}

	/// <summary>Calculates the day of the week on which a specified date occurs.</summary>
	/// <param name="time">The date value to read. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 11/16/2077 23:59:59 (Gregorian date).</param>
	/// <returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week specified by the <paramref name="time" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="time" /> is outside the range supported by this calendar.</exception>
	public override DayOfWeek GetDayOfWeek(DateTime time)
	{
		return default(DayOfWeek);
	}

	/// <summary>Calculates the number of days in the specified month of the specified year and era.</summary>
	/// <param name="year">A year.</param>
	/// <param name="month">An integer from 1 through 12 that represents a month.</param>
	/// <param name="era">An era. Specify <see langword="UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra]" /> or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param>
	/// <returns>The number of days in the specified month in the specified year and era. The return value is 29 in a common year and 30 in a leap year.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" />, <paramref name="month" />, or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class.</exception>
	public override int GetDaysInMonth(int year, int month, int era)
	{
		return 0;
	}

	internal static int RealGetDaysInYear(int year)
	{
		return 0;
	}

	/// <summary>Calculates the number of days in the specified year of the specified era.</summary>
	/// <param name="year">A year.</param>
	/// <param name="era">An era. Specify <see langword="UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra]" /> or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param>
	/// <returns>The number of days in the specified year and era. The number of days is 354 in a common year or 355 in a leap year.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class.</exception>
	public override int GetDaysInYear(int year, int era)
	{
		return 0;
	}

	/// <summary>Calculates the era in which a specified date occurs.</summary>
	/// <param name="time">The date value to read.</param>
	/// <returns>Always returns the <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" /> value.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="time" /> is outside the range supported by this calendar.</exception>
	public override int GetEra(DateTime time)
	{
		return 0;
	}

	/// <summary>Calculates the month in which a specified date occurs.</summary>
	/// <param name="time">The date value to read. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 11/16/2077 23:59:59 (Gregorian date).</param>
	/// <returns>An integer from 1 through 12 that represents the month in the date specified by the <paramref name="time" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="time" /> is outside the range supported by this calendar.</exception>
	public override int GetMonth(DateTime time)
	{
		return 0;
	}

	/// <summary>Calculates the number of months in the specified year of the specified era.</summary>
	/// <param name="year">A year.</param>
	/// <param name="era">An era. Specify <see langword="UmAlQuaraCalendar.Eras[UmAlQuraCalendar.CurrentEra]" /> or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param>
	/// <returns>Always 12.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by this calendar.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="era" /> is outside the range supported by this calendar.</exception>
	public override int GetMonthsInYear(int year, int era)
	{
		return 0;
	}

	/// <summary>Calculates the year of a date represented by a specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The date value to read. The <see cref="T:System.Globalization.UmAlQuraCalendar" /> class supports only dates from 04/30/1900 00.00.00 (Gregorian date) through 11/16/2077 23:59:59 (Gregorian date).</param>
	/// <returns>An integer that represents the year specified by the <paramref name="time" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="time" /> is outside the range supported by this calendar.</exception>
	public override int GetYear(DateTime time)
	{
		return 0;
	}

	/// <summary>Determines whether the specified year in the specified era is a leap year.</summary>
	/// <param name="year">A year.</param>
	/// <param name="era">An era. Specify <see langword="UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra]" /> or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param>
	/// <returns>
	///   <see langword="true" /> if the specified year is a leap year; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class.</exception>
	public override bool IsLeapYear(int year, int era)
	{
		return false;
	}

	/// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date, time, and era.</summary>
	/// <param name="year">A year.</param>
	/// <param name="month">An integer from 1 through 12 that represents a month.</param>
	/// <param name="day">An integer from 1 through 29 that represents a day.</param>
	/// <param name="hour">An integer from 0 through 23 that represents an hour.</param>
	/// <param name="minute">An integer from 0 through 59 that represents a minute.</param>
	/// <param name="second">An integer from 0 through 59 that represents a second.</param>
	/// <param name="millisecond">An integer from 0 through 999 that represents a millisecond.</param>
	/// <param name="era">An era. Specify <see langword="UmAlQuraCalendar.Eras[UmAlQuraCalendar.CurrentEra]" /> or <see cref="F:System.Globalization.UmAlQuraCalendar.UmAlQuraEra" />.</param>
	/// <returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" />, <paramref name="month" />, <paramref name="day" />, or <paramref name="era" /> is outside the range supported by the <see cref="T:System.Globalization.UmAlQuraCalendar" /> class.  
	/// -or-  
	/// <paramref name="hour" /> is less than zero or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than zero or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than zero or greater than 59.  
	/// -or-  
	/// <paramref name="millisecond" /> is less than zero or greater than 999.</exception>
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
	{
		return default(DateTime);
	}

	/// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.UmAlQuraCalendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary>
	/// <param name="year">A 2-digit year from 0 through 99, or a 4-digit Um Al Qura calendar year from 1318 through 1450.</param>
	/// <returns>If the <paramref name="year" /> parameter is a 2-digit year, the return value is the corresponding 4-digit year. If the <paramref name="year" /> parameter is a 4-digit year, the return value is the unchanged <paramref name="year" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by this calendar.</exception>
	public override int ToFourDigitYear(int year)
	{
		return 0;
	}
}
