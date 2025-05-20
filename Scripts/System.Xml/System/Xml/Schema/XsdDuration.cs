namespace System.Xml.Schema;

internal struct XsdDuration
{
	private enum Parts
	{
		HasNone = 0,
		HasYears = 1,
		HasMonths = 2,
		HasDays = 4,
		HasHours = 8,
		HasMinutes = 0x10,
		HasSeconds = 0x20
	}

	public enum DurationType
	{
		Duration = 0,
		YearMonthDuration = 1,
		DayTimeDuration = 2
	}

	private int years;

	private int months;

	private int days;

	private int hours;

	private int minutes;

	private int seconds;

	private uint nanoseconds;

	public bool IsNegative => false;

	public int Years => 0;

	public int Months => 0;

	public int Days => 0;

	public int Hours => 0;

	public int Minutes => 0;

	public int Seconds => 0;

	public int Nanoseconds => 0;

	public XsdDuration(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds)
	{
		this.years = 0;
		this.months = 0;
		this.days = 0;
		this.hours = 0;
		this.minutes = 0;
		this.seconds = 0;
		this.nanoseconds = 0u;
	}

	public XsdDuration(TimeSpan timeSpan)
	{
		years = 0;
		months = 0;
		days = 0;
		hours = 0;
		minutes = 0;
		seconds = 0;
		nanoseconds = 0u;
	}

	public XsdDuration(TimeSpan timeSpan, DurationType durationType)
	{
		years = 0;
		months = 0;
		days = 0;
		hours = 0;
		minutes = 0;
		seconds = 0;
		nanoseconds = 0u;
	}

	public XsdDuration(string s)
	{
		years = 0;
		months = 0;
		days = 0;
		hours = 0;
		minutes = 0;
		seconds = 0;
		nanoseconds = 0u;
	}

	public XsdDuration(string s, DurationType durationType)
	{
		years = 0;
		months = 0;
		days = 0;
		hours = 0;
		minutes = 0;
		seconds = 0;
		nanoseconds = 0u;
	}

	public TimeSpan ToTimeSpan()
	{
		return default(TimeSpan);
	}

	public TimeSpan ToTimeSpan(DurationType durationType)
	{
		return default(TimeSpan);
	}

	internal Exception TryToTimeSpan(out TimeSpan result)
	{
		result = default(TimeSpan);
		return null;
	}

	internal Exception TryToTimeSpan(DurationType durationType, out TimeSpan result)
	{
		result = default(TimeSpan);
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	internal string ToString(DurationType durationType)
	{
		return null;
	}

	internal static Exception TryParse(string s, out XsdDuration result)
	{
		result = default(XsdDuration);
		return null;
	}

	internal static Exception TryParse(string s, DurationType durationType, out XsdDuration result)
	{
		result = default(XsdDuration);
		return null;
	}

	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits)
	{
		result = default(int);
		numDigits = default(int);
		return null;
	}
}
