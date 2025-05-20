using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization;

/// <summary>Represents time in divisions, such as weeks, months, and years.</summary>
[Serializable]
[ComVisible(true)]
public abstract class Calendar : ICloneable
{
	internal const long TicksPerMillisecond = 10000L;

	internal const long TicksPerSecond = 10000000L;

	internal const long TicksPerMinute = 600000000L;

	internal const long TicksPerHour = 36000000000L;

	internal const long TicksPerDay = 864000000000L;

	internal const int MillisPerSecond = 1000;

	internal const int MillisPerMinute = 60000;

	internal const int MillisPerHour = 3600000;

	internal const int MillisPerDay = 86400000;

	internal const int DaysPerYear = 365;

	internal const int DaysPer4Years = 1461;

	internal const int DaysPer100Years = 36524;

	internal const int DaysPer400Years = 146097;

	internal const int DaysTo10000 = 3652059;

	internal const long MaxMillis = 315537897600000L;

	internal const int CAL_GREGORIAN = 1;

	internal const int CAL_GREGORIAN_US = 2;

	internal const int CAL_JAPAN = 3;

	internal const int CAL_TAIWAN = 4;

	internal const int CAL_KOREA = 5;

	internal const int CAL_HIJRI = 6;

	internal const int CAL_THAI = 7;

	internal const int CAL_HEBREW = 8;

	internal const int CAL_GREGORIAN_ME_FRENCH = 9;

	internal const int CAL_GREGORIAN_ARABIC = 10;

	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;

	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;

	internal const int CAL_JULIAN = 13;

	internal const int CAL_JAPANESELUNISOLAR = 14;

	internal const int CAL_CHINESELUNISOLAR = 15;

	internal const int CAL_SAKA = 16;

	internal const int CAL_LUNAR_ETO_CHN = 17;

	internal const int CAL_LUNAR_ETO_KOR = 18;

	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;

	internal const int CAL_KOREANLUNISOLAR = 20;

	internal const int CAL_TAIWANLUNISOLAR = 21;

	internal const int CAL_PERSIAN = 22;

	internal const int CAL_UMALQURA = 23;

	internal int m_currentEraValue;

	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly;

	/// <summary>Represents the current era of the current calendar. The value of this field is 0.</summary>
	public const int CurrentEra = 0;

	internal int twoDigitYearMax;

	/// <summary>Gets the earliest date and time supported by this <see cref="T:System.Globalization.Calendar" /> object.</summary>
	/// <returns>The earliest date and time supported by this calendar. The default is <see cref="F:System.DateTime.MinValue" />.</returns>
	[ComVisible(false)]
	public virtual DateTime MinSupportedDateTime => default(DateTime);

	/// <summary>Gets the latest date and time supported by this <see cref="T:System.Globalization.Calendar" /> object.</summary>
	/// <returns>The latest date and time supported by this calendar. The default is <see cref="F:System.DateTime.MaxValue" />.</returns>
	[ComVisible(false)]
	public virtual DateTime MaxSupportedDateTime => default(DateTime);

	internal virtual int ID => 0;

	internal virtual int BaseCalendarID => 0;

	internal virtual int CurrentEraValue => 0;

	/// <summary>When overridden in a derived class, gets the list of eras in the current calendar.</summary>
	/// <returns>An array of integers that represents the eras in the current calendar.</returns>
	public abstract int[] Eras { get; }

	/// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary>
	/// <returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Globalization.Calendar" /> object is read-only.</exception>
	public virtual int TwoDigitYearMax
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.Calendar" /> class.</summary>
	protected Calendar()
	{
	}

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Globalization.Calendar" /> object.</summary>
	/// <returns>A new instance of <see cref="T:System.Object" /> that is the memberwise clone of the current <see cref="T:System.Globalization.Calendar" /> object.</returns>
	[ComVisible(false)]
	public virtual object Clone()
	{
		return null;
	}

	internal void VerifyWritable()
	{
	}

	internal void SetReadOnlyState(bool readOnly)
	{
	}

	/// <summary>When overridden in a derived class, returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>A positive integer that represents the day of the month in the <paramref name="time" /> parameter.</returns>
	public abstract int GetDayOfMonth(DateTime time);

	/// <summary>When overridden in a derived class, returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in the <paramref name="time" /> parameter.</returns>
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	/// <summary>When overridden in a derived class, returns the number of days in the specified month, year, and era.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="month">A positive integer that represents the month.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>The number of days in the specified month in the specified year in the specified era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="month" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="era" /> is outside the range supported by the calendar.</exception>
	public abstract int GetDaysInMonth(int year, int month, int era);

	/// <summary>When overridden in a derived class, returns the number of days in the specified year and era.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>The number of days in the specified year in the specified era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="era" /> is outside the range supported by the calendar.</exception>
	public abstract int GetDaysInYear(int year, int era);

	/// <summary>When overridden in a derived class, returns the era in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>An integer that represents the era in <paramref name="time" />.</returns>
	public abstract int GetEra(DateTime time);

	/// <summary>When overridden in a derived class, returns the month in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>A positive integer that represents the month in <paramref name="time" />.</returns>
	public abstract int GetMonth(DateTime time);

	/// <summary>When overridden in a derived class, returns the number of months in the specified year in the specified era.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>The number of months in the specified year in the specified era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="era" /> is outside the range supported by the calendar.</exception>
	public abstract int GetMonthsInYear(int year, int era);

	/// <summary>When overridden in a derived class, returns the year in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>An integer that represents the year in <paramref name="time" />.</returns>
	public abstract int GetYear(DateTime time);

	/// <summary>Determines whether the specified year in the current era is a leap year.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <returns>
	///   <see langword="true" /> if the specified year is a leap year; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by the calendar.</exception>
	public virtual bool IsLeapYear(int year)
	{
		return false;
	}

	/// <summary>When overridden in a derived class, determines whether the specified year in the specified era is a leap year.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>
	///   <see langword="true" /> if the specified year is a leap year; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="era" /> is outside the range supported by the calendar.</exception>
	public abstract bool IsLeapYear(int year, int era);

	/// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="month">A positive integer that represents the month.</param>
	/// <param name="day">A positive integer that represents the day.</param>
	/// <param name="hour">An integer from 0 to 23 that represents the hour.</param>
	/// <param name="minute">An integer from 0 to 59 that represents the minute.</param>
	/// <param name="second">An integer from 0 to 59 that represents the second.</param>
	/// <param name="millisecond">An integer from 0 to 999 that represents the millisecond.</param>
	/// <returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="month" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="day" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="hour" /> is less than zero or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than zero or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than zero or greater than 59.  
	/// -or-  
	/// <paramref name="millisecond" /> is less than zero or greater than 999.</exception>
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
	{
		return default(DateTime);
	}

	/// <summary>When overridden in a derived class, returns a <see cref="T:System.DateTime" /> that is set to the specified date and time in the specified era.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="month">A positive integer that represents the month.</param>
	/// <param name="day">A positive integer that represents the day.</param>
	/// <param name="hour">An integer from 0 to 23 that represents the hour.</param>
	/// <param name="minute">An integer from 0 to 59 that represents the minute.</param>
	/// <param name="second">An integer from 0 to 59 that represents the second.</param>
	/// <param name="millisecond">An integer from 0 to 999 that represents the millisecond.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="month" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="day" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="hour" /> is less than zero or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than zero or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than zero or greater than 59.  
	/// -or-  
	/// <paramref name="millisecond" /> is less than zero or greater than 999.  
	/// -or-  
	/// <paramref name="era" /> is outside the range supported by the calendar.</exception>
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
	{
		result = default(DateTime);
		return false;
	}

	internal virtual bool IsValidYear(int year, int era)
	{
		return false;
	}

	internal virtual bool IsValidMonth(int year, int month, int era)
	{
		return false;
	}

	internal virtual bool IsValidDay(int year, int month, int day, int era)
	{
		return false;
	}

	/// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.Calendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary>
	/// <param name="year">A two-digit or four-digit integer that represents the year to convert.</param>
	/// <returns>An integer that contains the four-digit representation of <paramref name="year" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by the calendar.</exception>
	public virtual int ToFourDigitYear(int year)
	{
		return 0;
	}

	internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
	{
		return 0L;
	}

	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue)
	{
		return 0;
	}
}
