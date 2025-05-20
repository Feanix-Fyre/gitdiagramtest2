using System.Runtime.Serialization;

namespace System.Globalization;

[Serializable]
internal class GregorianCalendarHelper
{
	internal static readonly int[] DaysToMonth365;

	internal static readonly int[] DaysToMonth366;

	[OptionalField(VersionAdded = 1)]
	internal int m_maxYear;

	[OptionalField(VersionAdded = 1)]
	internal int m_minYear;

	internal Calendar m_Cal;

	[OptionalField(VersionAdded = 1)]
	internal EraInfo[] m_EraInfo;

	[OptionalField(VersionAdded = 1)]
	internal int[] m_eras;

	[OptionalField(VersionAdded = 1)]
	internal DateTime m_minDate;

	internal int MaxYear => 0;

	public int[] Eras => null;

	internal GregorianCalendarHelper(Calendar cal, EraInfo[] eraInfo)
	{
	}

	private int GetYearOffset(int year, int era, bool throwOnError)
	{
		return 0;
	}

	internal int GetGregorianYear(int year, int era)
	{
		return 0;
	}

	internal bool IsValidYear(int year, int era)
	{
		return false;
	}

	internal virtual int GetDatePart(long ticks, int part)
	{
		return 0;
	}

	internal static long GetAbsoluteDate(int year, int month, int day)
	{
		return 0L;
	}

	internal static long DateToTicks(int year, int month, int day)
	{
		return 0L;
	}

	internal static long TimeToTicks(int hour, int minute, int second, int millisecond)
	{
		return 0L;
	}

	internal void CheckTicksRange(long ticks)
	{
	}

	public int GetDayOfMonth(DateTime time)
	{
		return 0;
	}

	public DayOfWeek GetDayOfWeek(DateTime time)
	{
		return default(DayOfWeek);
	}

	public int GetDaysInMonth(int year, int month, int era)
	{
		return 0;
	}

	public int GetDaysInYear(int year, int era)
	{
		return 0;
	}

	public int GetEra(DateTime time)
	{
		return 0;
	}

	public int GetMonth(DateTime time)
	{
		return 0;
	}

	public int GetMonthsInYear(int year, int era)
	{
		return 0;
	}

	public int GetYear(DateTime time)
	{
		return 0;
	}

	public bool IsLeapYear(int year, int era)
	{
		return false;
	}

	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era)
	{
		return default(DateTime);
	}

	public int ToFourDigitYear(int year, int twoDigitYearMax)
	{
		return 0;
	}
}
