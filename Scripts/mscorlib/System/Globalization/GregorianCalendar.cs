using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization;

/// <summary>Represents the Gregorian calendar.</summary>
[Serializable]
[ComVisible(true)]
public class GregorianCalendar : Calendar
{
	internal GregorianCalendarTypes m_type;

	internal static readonly int[] DaysToMonth365;

	internal static readonly int[] DaysToMonth366;

	private static Calendar s_defaultInstance;

	/// <summary>Gets the earliest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type.</summary>
	/// <returns>The earliest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type, which is the first moment of January 1, 0001 C.E. and is equivalent to <see cref="F:System.DateTime.MinValue" />.</returns>
	[ComVisible(false)]
	public override DateTime MinSupportedDateTime => default(DateTime);

	/// <summary>Gets the latest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type.</summary>
	/// <returns>The latest date and time supported by the <see cref="T:System.Globalization.GregorianCalendar" /> type, which is the last moment of December 31, 9999 C.E. and is equivalent to <see cref="F:System.DateTime.MaxValue" />.</returns>
	[ComVisible(false)]
	public override DateTime MaxSupportedDateTime => default(DateTime);

	internal override int ID => 0;

	/// <summary>Gets the list of eras in the <see cref="T:System.Globalization.GregorianCalendar" />.</summary>
	/// <returns>An array of integers that represents the eras in the <see cref="T:System.Globalization.GregorianCalendar" />.</returns>
	public override int[] Eras => null;

	/// <summary>Gets or sets the last year of a 100-year range that can be represented by a 2-digit year.</summary>
	/// <returns>The last year of a 100-year range that can be represented by a 2-digit year.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 99.  
	///  -or-  
	///  The value specified in a set operation is greater than <see langword="MaxSupportedDateTime.Year" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">In a set operation, the current instance is read-only.</exception>
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

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	internal static Calendar GetDefaultInstance()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.GregorianCalendar" /> class using the default <see cref="T:System.Globalization.GregorianCalendarTypes" /> value.</summary>
	public GregorianCalendar()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.GregorianCalendar" /> class using the specified <see cref="T:System.Globalization.GregorianCalendarTypes" /> value.</summary>
	/// <param name="type">The <see cref="T:System.Globalization.GregorianCalendarTypes" /> value that denotes which language version of the calendar to create.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="type" /> is not a member of the <see cref="T:System.Globalization.GregorianCalendarTypes" /> enumeration.</exception>
	public GregorianCalendar(GregorianCalendarTypes type)
	{
	}

	internal virtual int GetDatePart(long ticks, int part)
	{
		return 0;
	}

	internal static long GetAbsoluteDate(int year, int month, int day)
	{
		return 0L;
	}

	/// <summary>Returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>An integer from 1 to 31 that represents the day of the month in <paramref name="time" />.</returns>
	public override int GetDayOfMonth(DateTime time)
	{
		return 0;
	}

	/// <summary>Returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in <paramref name="time" />.</returns>
	public override DayOfWeek GetDayOfWeek(DateTime time)
	{
		return default(DayOfWeek);
	}

	/// <summary>Returns the number of days in the specified month in the specified year in the specified era.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="month">An integer from 1 to 12 that represents the month.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>The number of days in the specified month in the specified year in the specified era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="era" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="year" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="month" /> is outside the range supported by the calendar.</exception>
	public override int GetDaysInMonth(int year, int month, int era)
	{
		return 0;
	}

	/// <summary>Returns the number of days in the specified year in the specified era.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>The number of days in the specified year in the specified era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="era" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="year" /> is outside the range supported by the calendar.</exception>
	public override int GetDaysInYear(int year, int era)
	{
		return 0;
	}

	/// <summary>Returns the era in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>An integer that represents the era in <paramref name="time" />.</returns>
	public override int GetEra(DateTime time)
	{
		return 0;
	}

	/// <summary>Returns the month in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>An integer from 1 to 12 that represents the month in <paramref name="time" />.</returns>
	public override int GetMonth(DateTime time)
	{
		return 0;
	}

	/// <summary>Returns the number of months in the specified year in the specified era.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>The number of months in the specified year in the specified era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="era" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="year" /> is outside the range supported by the calendar.</exception>
	public override int GetMonthsInYear(int year, int era)
	{
		return 0;
	}

	/// <summary>Returns the year in the specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="time">The <see cref="T:System.DateTime" /> to read.</param>
	/// <returns>An integer that represents the year in <paramref name="time" />.</returns>
	public override int GetYear(DateTime time)
	{
		return 0;
	}

	/// <summary>Determines whether the specified year in the specified era is a leap year.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>
	///   <see langword="true" /> if the specified year is a leap year; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="era" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="year" /> is outside the range supported by the calendar.</exception>
	public override bool IsLeapYear(int year, int era)
	{
		return false;
	}

	/// <summary>Returns a <see cref="T:System.DateTime" /> that is set to the specified date and time in the specified era.</summary>
	/// <param name="year">An integer that represents the year.</param>
	/// <param name="month">An integer from 1 to 12 that represents the month.</param>
	/// <param name="day">An integer from 1 to 31 that represents the day.</param>
	/// <param name="hour">An integer from 0 to 23 that represents the hour.</param>
	/// <param name="minute">An integer from 0 to 59 that represents the minute.</param>
	/// <param name="second">An integer from 0 to 59 that represents the second.</param>
	/// <param name="millisecond">An integer from 0 to 999 that represents the millisecond.</param>
	/// <param name="era">An integer that represents the era.</param>
	/// <returns>The <see cref="T:System.DateTime" /> that is set to the specified date and time in the current era.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="era" /> is outside the range supported by the calendar.  
	/// -or-  
	/// <paramref name="year" /> is outside the range supported by the calendar.  
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
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
	{
		return default(DateTime);
	}

	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result)
	{
		result = default(DateTime);
		return false;
	}

	/// <summary>Converts the specified year to a four-digit year by using the <see cref="P:System.Globalization.GregorianCalendar.TwoDigitYearMax" /> property to determine the appropriate century.</summary>
	/// <param name="year">A two-digit or four-digit integer that represents the year to convert.</param>
	/// <returns>An integer that contains the four-digit representation of <paramref name="year" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is outside the range supported by the calendar.</exception>
	public override int ToFourDigitYear(int year)
	{
		return 0;
	}
}
