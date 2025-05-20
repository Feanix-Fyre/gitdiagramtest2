using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Represents an instant in time, typically expressed as a date and time of day.</summary>
[Serializable]
[StructLayout((LayoutKind)3)]
public readonly struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable
{
	private const long TicksPerMillisecond = 10000L;

	private const long TicksPerSecond = 10000000L;

	private const long TicksPerMinute = 600000000L;

	private const long TicksPerHour = 36000000000L;

	private const long TicksPerDay = 864000000000L;

	private const int MillisPerSecond = 1000;

	private const int MillisPerMinute = 60000;

	private const int MillisPerHour = 3600000;

	private const int MillisPerDay = 86400000;

	private const int DaysPerYear = 365;

	private const int DaysPer4Years = 1461;

	private const int DaysPer100Years = 36524;

	private const int DaysPer400Years = 146097;

	private const int DaysTo1601 = 584388;

	private const int DaysTo1899 = 693593;

	internal const int DaysTo1970 = 719162;

	private const int DaysTo10000 = 3652059;

	internal const long MinTicks = 0L;

	internal const long MaxTicks = 3155378975999999999L;

	private const long MaxMillis = 315537897600000L;

	internal const long UnixEpochTicks = 621355968000000000L;

	private const long FileTimeOffset = 504911232000000000L;

	private const long DoubleDateOffset = 599264352000000000L;

	private const long OADateMinAsTicks = 31241376000000000L;

	private const double OADateMinAsDouble = -657435.0;

	private const double OADateMaxAsDouble = 2958466.0;

	private const int DatePartYear = 0;

	private const int DatePartDayOfYear = 1;

	private const int DatePartMonth = 2;

	private const int DatePartDay = 3;

	private static readonly int[] s_daysToMonth365;

	private static readonly int[] s_daysToMonth366;

	/// <summary>Represents the smallest possible value of <see cref="T:System.DateTime" />. This field is read-only.</summary>
	public static readonly DateTime MinValue;

	/// <summary>Represents the largest possible value of <see cref="T:System.DateTime" />. This field is read-only.</summary>
	public static readonly DateTime MaxValue;

	public static readonly DateTime UnixEpoch;

	private const ulong TicksMask = 4611686018427387903uL;

	private const ulong FlagsMask = 13835058055282163712uL;

	private const ulong LocalMask = 9223372036854775808uL;

	private const long TicksCeiling = 4611686018427387904L;

	private const ulong KindUnspecified = 0uL;

	private const ulong KindUtc = 4611686018427387904uL;

	private const ulong KindLocal = 9223372036854775808uL;

	private const ulong KindLocalAmbiguousDst = 13835058055282163712uL;

	private const int KindShift = 62;

	private const string TicksField = "ticks";

	private const string DateDataField = "dateData";

	private readonly ulong _dateData;

	internal long InternalTicks => 0L;

	private ulong InternalKind => 0uL;

	/// <summary>Gets the date component of this instance.</summary>
	/// <returns>A new object with the same date as this instance, and the time value set to 12:00:00 midnight (00:00:00).</returns>
	public DateTime Date => default(DateTime);

	/// <summary>Gets the day of the month represented by this instance.</summary>
	/// <returns>The day component, expressed as a value between 1 and 31.</returns>
	public int Day => 0;

	/// <summary>Gets the day of the week represented by this instance.</summary>
	/// <returns>An enumerated constant that indicates the day of the week of this <see cref="T:System.DateTime" /> value.</returns>
	public DayOfWeek DayOfWeek => default(DayOfWeek);

	/// <summary>Gets the hour component of the date represented by this instance.</summary>
	/// <returns>The hour component, expressed as a value between 0 and 23.</returns>
	public int Hour => 0;

	/// <summary>Gets a value that indicates whether the time represented by this instance is based on local time, Coordinated Universal Time (UTC), or neither.</summary>
	/// <returns>One of the enumeration values that indicates what the current time represents. The default is <see cref="F:System.DateTimeKind.Unspecified" />.</returns>
	public DateTimeKind Kind => default(DateTimeKind);

	/// <summary>Gets the milliseconds component of the date represented by this instance.</summary>
	/// <returns>The milliseconds component, expressed as a value between 0 and 999.</returns>
	public int Millisecond => 0;

	/// <summary>Gets the minute component of the date represented by this instance.</summary>
	/// <returns>The minute component, expressed as a value between 0 and 59.</returns>
	public int Minute => 0;

	/// <summary>Gets the month component of the date represented by this instance.</summary>
	/// <returns>The month component, expressed as a value between 1 and 12.</returns>
	public int Month => 0;

	/// <summary>Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, expressed as the local time.</summary>
	/// <returns>An object whose value is the current local date and time.</returns>
	public static DateTime Now => default(DateTime);

	/// <summary>Gets the seconds component of the date represented by this instance.</summary>
	/// <returns>The seconds component, expressed as a value between 0 and 59.</returns>
	public int Second => 0;

	/// <summary>Gets the number of ticks that represent the date and time of this instance.</summary>
	/// <returns>The number of ticks that represent the date and time of this instance. The value is between <see langword="DateTime.MinValue.Ticks" /> and <see langword="DateTime.MaxValue.Ticks" />.</returns>
	public long Ticks => 0L;

	/// <summary>Gets the time of day for this instance.</summary>
	/// <returns>A time interval that represents the fraction of the day that has elapsed since midnight.</returns>
	public TimeSpan TimeOfDay => default(TimeSpan);

	/// <summary>Gets the year component of the date represented by this instance.</summary>
	/// <returns>The year, between 1 and 9999.</returns>
	public int Year => 0;

	/// <summary>Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, expressed as the Coordinated Universal Time (UTC).</summary>
	/// <returns>An object whose value is the current UTC date and time.</returns>
	public static DateTime UtcNow => default(DateTime);

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to a specified number of ticks.</summary>
	/// <param name="ticks">A date and time expressed in the number of 100-nanosecond intervals that have elapsed since January 1, 0001 at 00:00:00.000 in the Gregorian calendar.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="ticks" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public DateTime(long ticks)
	{
		_dateData = 0uL;
	}

	private DateTime(ulong dateData)
	{
		_dateData = 0uL;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to a specified number of ticks and to Coordinated Universal Time (UTC) or local time.</summary>
	/// <param name="ticks">A date and time expressed in the number of 100-nanosecond intervals that have elapsed since January 1, 0001 at 00:00:00.000 in the Gregorian calendar.</param>
	/// <param name="kind">One of the enumeration values that indicates whether <paramref name="ticks" /> specifies a local time, Coordinated Universal Time (UTC), or neither.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="ticks" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="kind" /> is not one of the <see cref="T:System.DateTimeKind" /> values.</exception>
	public DateTime(long ticks, DateTimeKind kind)
	{
		_dateData = 0uL;
	}

	internal DateTime(long ticks, DateTimeKind kind, bool isAmbiguousDst)
	{
		_dateData = 0uL;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, and day.</summary>
	/// <param name="year">The year (1 through 9999).</param>
	/// <param name="month">The month (1 through 12).</param>
	/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is less than 1 or greater than 9999.  
	/// -or-  
	/// <paramref name="month" /> is less than 1 or greater than 12.  
	/// -or-  
	/// <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.</exception>
	public DateTime(int year, int month, int day)
	{
		_dateData = 0uL;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, and second.</summary>
	/// <param name="year">The year (1 through 9999).</param>
	/// <param name="month">The month (1 through 12).</param>
	/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
	/// <param name="hour">The hours (0 through 23).</param>
	/// <param name="minute">The minutes (0 through 59).</param>
	/// <param name="second">The seconds (0 through 59).</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is less than 1 or greater than 9999.  
	/// -or-  
	/// <paramref name="month" /> is less than 1 or greater than 12.  
	/// -or-  
	/// <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.  
	/// -or-  
	/// <paramref name="hour" /> is less than 0 or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than 0 or greater than 59.</exception>
	public DateTime(int year, int month, int day, int hour, int minute, int second)
	{
		_dateData = 0uL;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, second, and Coordinated Universal Time (UTC) or local time.</summary>
	/// <param name="year">The year (1 through 9999).</param>
	/// <param name="month">The month (1 through 12).</param>
	/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
	/// <param name="hour">The hours (0 through 23).</param>
	/// <param name="minute">The minutes (0 through 59).</param>
	/// <param name="second">The seconds (0 through 59).</param>
	/// <param name="kind">One of the enumeration values that indicates whether <paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" /> and <paramref name="second" /> specify a local time, Coordinated Universal Time (UTC), or neither.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is less than 1 or greater than 9999.  
	/// -or-  
	/// <paramref name="month" /> is less than 1 or greater than 12.  
	/// -or-  
	/// <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.  
	/// -or-  
	/// <paramref name="hour" /> is less than 0 or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than 0 or greater than 59.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="kind" /> is not one of the <see cref="T:System.DateTimeKind" /> values.</exception>
	public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
	{
		_dateData = 0uL;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, second, and millisecond.</summary>
	/// <param name="year">The year (1 through 9999).</param>
	/// <param name="month">The month (1 through 12).</param>
	/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
	/// <param name="hour">The hours (0 through 23).</param>
	/// <param name="minute">The minutes (0 through 59).</param>
	/// <param name="second">The seconds (0 through 59).</param>
	/// <param name="millisecond">The milliseconds (0 through 999).</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is less than 1 or greater than 9999.  
	/// -or-  
	/// <paramref name="month" /> is less than 1 or greater than 12.  
	/// -or-  
	/// <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.  
	/// -or-  
	/// <paramref name="hour" /> is less than 0 or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="millisecond" /> is less than 0 or greater than 999.</exception>
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
	{
		_dateData = 0uL;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, second, and millisecond for the specified calendar.</summary>
	/// <param name="year">The year (1 through the number of years in <paramref name="calendar" />).</param>
	/// <param name="month">The month (1 through the number of months in <paramref name="calendar" />).</param>
	/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
	/// <param name="hour">The hours (0 through 23).</param>
	/// <param name="minute">The minutes (0 through 59).</param>
	/// <param name="second">The seconds (0 through 59).</param>
	/// <param name="millisecond">The milliseconds (0 through 999).</param>
	/// <param name="calendar">The calendar that is used to interpret <paramref name="year" />, <paramref name="month" />, and <paramref name="day" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="calendar" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is not in the range supported by <paramref name="calendar" />.  
	/// -or-  
	/// <paramref name="month" /> is less than 1 or greater than the number of months in <paramref name="calendar" />.  
	/// -or-  
	/// <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.  
	/// -or-  
	/// <paramref name="hour" /> is less than 0 or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="millisecond" /> is less than 0 or greater than 999.</exception>
	public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar)
	{
		_dateData = 0uL;
	}

	private DateTime(SerializationInfo info, StreamingContext context)
	{
		_dateData = 0uL;
	}

	/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the value of the specified <see cref="T:System.TimeSpan" /> to the value of this instance.</summary>
	/// <param name="value">A positive or negative time interval.</param>
	/// <returns>An object whose value is the sum of the date and time represented by this instance and the time interval represented by <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public DateTime Add(TimeSpan value)
	{
		return default(DateTime);
	}

	private DateTime Add(double value, int scale)
	{
		return default(DateTime);
	}

	/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of days to the value of this instance.</summary>
	/// <param name="value">A number of whole and fractional days. The <paramref name="value" /> parameter can be negative or positive.</param>
	/// <returns>An object whose value is the sum of the date and time represented by this instance and the number of days represented by <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public DateTime AddDays(double value)
	{
		return default(DateTime);
	}

	/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of milliseconds to the value of this instance.</summary>
	/// <param name="value">A number of whole and fractional milliseconds. The <paramref name="value" /> parameter can be negative or positive. Note that this value is rounded to the nearest integer.</param>
	/// <returns>An object whose value is the sum of the date and time represented by this instance and the number of milliseconds represented by <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public DateTime AddMilliseconds(double value)
	{
		return default(DateTime);
	}

	/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of months to the value of this instance.</summary>
	/// <param name="months">A number of months. The <paramref name="months" /> parameter can be negative or positive.</param>
	/// <returns>An object whose value is the sum of the date and time represented by this instance and <paramref name="months" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.  
	///  -or-  
	///  <paramref name="months" /> is less than -120,000 or greater than 120,000.</exception>
	public DateTime AddMonths(int months)
	{
		return default(DateTime);
	}

	/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of seconds to the value of this instance.</summary>
	/// <param name="value">A number of whole and fractional seconds. The <paramref name="value" /> parameter can be negative or positive.</param>
	/// <returns>An object whose value is the sum of the date and time represented by this instance and the number of seconds represented by <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public DateTime AddSeconds(double value)
	{
		return default(DateTime);
	}

	/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of ticks to the value of this instance.</summary>
	/// <param name="value">A number of 100-nanosecond ticks. The <paramref name="value" /> parameter can be positive or negative.</param>
	/// <returns>An object whose value is the sum of the date and time represented by this instance and the time represented by <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public DateTime AddTicks(long value)
	{
		return default(DateTime);
	}

	/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of years to the value of this instance.</summary>
	/// <param name="value">A number of years. The <paramref name="value" /> parameter can be negative or positive.</param>
	/// <returns>An object whose value is the sum of the date and time represented by this instance and the number of years represented by <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="value" /> or the resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public DateTime AddYears(int value)
	{
		return default(DateTime);
	}

	/// <summary>Compares two instances of <see cref="T:System.DateTime" /> and returns an integer that indicates whether the first instance is earlier than, the same as, or later than the second instance.</summary>
	/// <param name="t1">The first object to compare.</param>
	/// <param name="t2">The second object to compare.</param>
	/// <returns>A signed number indicating the relative values of <paramref name="t1" /> and <paramref name="t2" />.  
	///   Value Type  
	///
	///   Condition  
	///
	///   Less than zero  
	///
	///  <paramref name="t1" /> is earlier than <paramref name="t2" />.  
	///
	///   Zero  
	///
	///  <paramref name="t1" /> is the same as <paramref name="t2" />.  
	///
	///   Greater than zero  
	///
	///  <paramref name="t1" /> is later than <paramref name="t2" />.</returns>
	public static int Compare(DateTime t1, DateTime t2)
	{
		return 0;
	}

	/// <summary>Compares the value of this instance to a specified object that contains a specified <see cref="T:System.DateTime" /> value, and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime" /> value.</summary>
	/// <param name="value">A boxed object to compare, or <see langword="null" />.</param>
	/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.  
	///   Value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   This instance is earlier than <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance is the same as <paramref name="value" />.  
	///
	///   Greater than zero  
	///
	///   This instance is later than <paramref name="value" />, or <paramref name="value" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.DateTime" />.</exception>
	public int CompareTo(object value)
	{
		return 0;
	}

	/// <summary>Compares the value of this instance to a specified <see cref="T:System.DateTime" /> value and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime" /> value.</summary>
	/// <param name="value">The object to compare to the current instance.</param>
	/// <returns>A signed number indicating the relative values of this instance and the <paramref name="value" /> parameter.  
	///   Value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   This instance is earlier than <paramref name="value" />.  
	///
	///   Zero  
	///
	///   This instance is the same as <paramref name="value" />.  
	///
	///   Greater than zero  
	///
	///   This instance is later than <paramref name="value" />.</returns>
	public int CompareTo(DateTime value)
	{
		return 0;
	}

	private static long DateToTicks(int year, int month, int day)
	{
		return 0L;
	}

	private static long TimeToTicks(int hour, int minute, int second)
	{
		return 0L;
	}

	/// <summary>Returns the number of days in the specified month and year.</summary>
	/// <param name="year">The year.</param>
	/// <param name="month">The month (a number ranging from 1 to 12).</param>
	/// <returns>The number of days in <paramref name="month" /> for the specified <paramref name="year" />.  
	///  For example, if <paramref name="month" /> equals 2 for February, the return value is 28 or 29 depending upon whether <paramref name="year" /> is a leap year.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="month" /> is less than 1 or greater than 12.  
	/// -or-  
	/// <paramref name="year" /> is less than 1 or greater than 9999.</exception>
	public static int DaysInMonth(int year, int month)
	{
		return 0;
	}

	/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
	/// <param name="value">The object to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is an instance of <see cref="T:System.DateTime" /> and equals the value of this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object value)
	{
		return false;
	}

	/// <summary>Returns a value indicating whether the value of this instance is equal to the value of the specified <see cref="T:System.DateTime" /> instance.</summary>
	/// <param name="value">The object to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="value" /> parameter equals the value of this instance; otherwise, <see langword="false" />.</returns>
	public bool Equals(DateTime value)
	{
		return false;
	}

	/// <summary>Deserializes a 64-bit binary value and recreates an original serialized <see cref="T:System.DateTime" /> object.</summary>
	/// <param name="dateData">A 64-bit signed integer that encodes the <see cref="P:System.DateTime.Kind" /> property in a 2-bit field and the <see cref="P:System.DateTime.Ticks" /> property in a 62-bit field.</param>
	/// <returns>An object that is equivalent to the <see cref="T:System.DateTime" /> object that was serialized by the <see cref="M:System.DateTime.ToBinary" /> method.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="dateData" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public static DateTime FromBinary(long dateData)
	{
		return default(DateTime);
	}

	internal static DateTime FromBinaryRaw(long dateData)
	{
		return default(DateTime);
	}

	/// <summary>Converts the specified Windows file time to an equivalent local time.</summary>
	/// <param name="fileTime">A Windows file time expressed in ticks.</param>
	/// <returns>An object that represents the local time equivalent of the date and time represented by the <paramref name="fileTime" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="fileTime" /> is less than 0 or represents a time greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public static DateTime FromFileTime(long fileTime)
	{
		return default(DateTime);
	}

	/// <summary>Converts the specified Windows file time to an equivalent UTC time.</summary>
	/// <param name="fileTime">A Windows file time expressed in ticks.</param>
	/// <returns>An object that represents the UTC time equivalent of the date and time represented by the <paramref name="fileTime" /> parameter.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="fileTime" /> is less than 0 or represents a time greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public static DateTime FromFileTimeUtc(long fileTime)
	{
		return default(DateTime);
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize the current <see cref="T:System.DateTime" /> object.</summary>
	/// <param name="info">The object to populate with data.</param>
	/// <param name="context">The destination for this serialization. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Indicates whether this instance of <see cref="T:System.DateTime" /> is within the daylight saving time range for the current time zone.</summary>
	/// <returns>
	///   <see langword="true" /> if the value of the <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Local" /> or <see cref="F:System.DateTimeKind.Unspecified" /> and the value of this instance of <see cref="T:System.DateTime" /> is within the daylight saving time range for the local time zone; <see langword="false" /> if <see cref="P:System.DateTime.Kind" /> is <see cref="F:System.DateTimeKind.Utc" />.</returns>
	public bool IsDaylightSavingTime()
	{
		return false;
	}

	/// <summary>Creates a new <see cref="T:System.DateTime" /> object that has the same number of ticks as the specified <see cref="T:System.DateTime" />, but is designated as either local time, Coordinated Universal Time (UTC), or neither, as indicated by the specified <see cref="T:System.DateTimeKind" /> value.</summary>
	/// <param name="value">A date and time.</param>
	/// <param name="kind">One of the enumeration values that indicates whether the new object represents local time, UTC, or neither.</param>
	/// <returns>A new object that has the same number of ticks as the object represented by the <paramref name="value" /> parameter and the <see cref="T:System.DateTimeKind" /> value specified by the <paramref name="kind" /> parameter.</returns>
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
	{
		return default(DateTime);
	}

	/// <summary>Serializes the current <see cref="T:System.DateTime" /> object to a 64-bit binary value that subsequently can be used to recreate the <see cref="T:System.DateTime" /> object.</summary>
	/// <returns>A 64-bit signed integer that encodes the <see cref="P:System.DateTime.Kind" /> and <see cref="P:System.DateTime.Ticks" /> properties.</returns>
	public long ToBinary()
	{
		return 0L;
	}

	private int GetDatePart(int part)
	{
		return 0;
	}

	internal void GetDatePart(out int year, out int month, out int day)
	{
		year = default(int);
		month = default(int);
		day = default(int);
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	internal bool IsAmbiguousDaylightSavingTime()
	{
		return false;
	}

	/// <summary>Returns an indication whether the specified year is a leap year.</summary>
	/// <param name="year">A 4-digit year.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="year" /> is a leap year; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is less than 1 or greater than 9999.</exception>
	public static bool IsLeapYear(int year)
	{
		return false;
	}

	/// <summary>Converts the string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent by using culture-specific format information.</summary>
	/// <param name="s">A string that contains a date and time to convert. See The string to parse for more information.</param>
	/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />.  See Parsing and cultural conventions</param>
	/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" /> as specified by <paramref name="provider" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> does not contain a valid string representation of a date and time.</exception>
	public static DateTime Parse(string s, IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>Converts the string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent by using culture-specific format information and a formatting style.</summary>
	/// <param name="s">A string that contains a date and time to convert. See The string to parse for more information.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.  See Parsing and cultural conventions</param>
	/// <param name="styles">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s" /> for the parse operation to succeed, and that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
	/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="provider" /> and <paramref name="styles" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> does not contain a valid string representation of a date and time.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="styles" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
	{
		return default(DateTime);
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified format and culture-specific format information. The format of the string representation must match the specified format exactly.</summary>
	/// <param name="s">A string that contains a date and time to convert.</param>
	/// <param name="format">A format specifier that defines the required format of <paramref name="s" />. For more information, see the Remarks section.</param>
	/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />.</param>
	/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> or <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> or <paramref name="format" /> is an empty string.  
	/// -or-  
	/// <paramref name="s" /> does not contain a date and time that corresponds to the pattern specified in <paramref name="format" />.  
	/// -or-  
	/// The hour component and the AM/PM designator in <paramref name="s" /> do not agree.</exception>
	public static DateTime ParseExact(string s, string format, IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly or an exception is thrown.</summary>
	/// <param name="s">A string containing a date and time to convert.</param>
	/// <param name="format">A format specifier that defines the required format of <paramref name="s" />. For more information, see the Remarks section.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <param name="style">A bitwise combination of the enumeration values that provides additional information about <paramref name="s" />, about style elements that may be present in <paramref name="s" />, or about the conversion from <paramref name="s" /> to a <see cref="T:System.DateTime" /> value. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
	/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="format" />, <paramref name="provider" />, and <paramref name="style" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> or <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> or <paramref name="format" /> is an empty string.  
	/// -or-  
	/// <paramref name="s" /> does not contain a date and time that corresponds to the pattern specified in <paramref name="format" />.  
	/// -or-  
	/// The hour component and the AM/PM designator in <paramref name="s" /> do not agree.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
	{
		return default(DateTime);
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly or an exception is thrown.</summary>
	/// <param name="s">A string that contains a date and time to convert.</param>
	/// <param name="formats">An array of allowable formats of <paramref name="s" />. For more information, see the Remarks section.</param>
	/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />.</param>
	/// <param name="style">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
	/// <returns>An object that is equivalent to the date and time contained in <paramref name="s" />, as specified by <paramref name="formats" />, <paramref name="provider" />, and <paramref name="style" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="s" /> or <paramref name="formats" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="s" /> is an empty string.  
	/// -or-  
	/// an element of <paramref name="formats" /> is an empty string.  
	/// -or-  
	/// <paramref name="s" /> does not contain a date and time that corresponds to any element of <paramref name="formats" />.  
	/// -or-  
	/// The hour component and the AM/PM designator in <paramref name="s" /> do not agree.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="style" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
	public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
	{
		return default(DateTime);
	}

	/// <summary>Subtracts the specified date and time from this instance.</summary>
	/// <param name="value">The date and time value to subtract.</param>
	/// <returns>A time interval that is equal to the date and time represented by this instance minus the date and time represented by <paramref name="value" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The result is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public TimeSpan Subtract(DateTime value)
	{
		return default(TimeSpan);
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to a Windows file time.</summary>
	/// <returns>The value of the current <see cref="T:System.DateTime" /> object expressed as a Windows file time.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting file time would represent a date and time before 12:00 midnight January 1, 1601 C.E. UTC.</exception>
	public long ToFileTime()
	{
		return 0L;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to a Windows file time.</summary>
	/// <returns>The value of the current <see cref="T:System.DateTime" /> object expressed as a Windows file time.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting file time would represent a date and time before 12:00 midnight January 1, 1601 C.E. UTC.</exception>
	public long ToFileTimeUtc()
	{
		return 0L;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to local time.</summary>
	/// <returns>An object whose <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Local" />, and whose value is the local time equivalent to the value of the current <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MaxValue" /> if the converted value is too large to be represented by a <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MinValue" /> if the converted value is too small to be represented as a <see cref="T:System.DateTime" /> object.</returns>
	public DateTime ToLocalTime()
	{
		return default(DateTime);
	}

	internal DateTime ToLocalTime(bool throwOnOverflow)
	{
		return default(DateTime);
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent short date string representation.</summary>
	/// <returns>A string that contains the short date string representation of the current <see cref="T:System.DateTime" /> object.</returns>
	public string ToShortDateString()
	{
		return null;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent short time string representation.</summary>
	/// <returns>A string that contains the short time string representation of the current <see cref="T:System.DateTime" /> object.</returns>
	public string ToShortTimeString()
	{
		return null;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the formatting conventions of the current culture.</summary>
	/// <returns>A string representation of the value of the current <see cref="T:System.DateTime" /> object.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture.</exception>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the specified format and the formatting conventions of the current culture.</summary>
	/// <param name="format">A standard or custom date and time format string.</param>
	/// <returns>A string representation of value of the current <see cref="T:System.DateTime" /> object as specified by <paramref name="format" />.</returns>
	/// <exception cref="T:System.FormatException">The length of <paramref name="format" /> is 1, and it is not one of the format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.  
	///  -or-  
	///  <paramref name="format" /> does not contain a valid custom format pattern.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture.</exception>
	public string ToString(string format)
	{
		return null;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the specified culture-specific format information.</summary>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A string representation of value of the current <see cref="T:System.DateTime" /> object as specified by <paramref name="provider" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="provider" />.</exception>
	public string ToString(IFormatProvider provider)
	{
		return null;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the specified format and culture-specific format information.</summary>
	/// <param name="format">A standard or custom date and time format string.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A string representation of value of the current <see cref="T:System.DateTime" /> object as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
	/// <exception cref="T:System.FormatException">The length of <paramref name="format" /> is 1, and it is not one of the format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.  
	///  -or-  
	///  <paramref name="format" /> does not contain a valid custom format pattern.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="provider" />.</exception>
	public string ToString(string format, IFormatProvider provider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
	{
		charsWritten = default(int);
		return false;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to Coordinated Universal Time (UTC).</summary>
	/// <returns>An object whose <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Utc" />, and whose value is the UTC equivalent to the value of the current <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MaxValue" /> if the converted value is too large to be represented by a <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MinValue" /> if the converted value is too small to be represented by a <see cref="T:System.DateTime" /> object.</returns>
	public DateTime ToUniversalTime()
	{
		return default(DateTime);
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified culture-specific format information and formatting style, and returns a value that indicates whether the conversion succeeded.</summary>
	/// <param name="s">A string containing a date and time to convert.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <param name="styles">A bitwise combination of enumeration values that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
	/// <param name="result">When this method returns, contains the <see cref="T:System.DateTime" /> value equivalent to the date and time contained in <paramref name="s" />, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue" /> if the conversion failed. The conversion fails if the <paramref name="s" /> parameter is <see langword="null" />, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="s" /> parameter was converted successfully; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="styles" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.  
	/// -or-  
	/// <paramref name="styles" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />).</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="provider" /> is a neutral culture and cannot be used in a parsing operation.</exception>
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
	{
		result = default(DateTime);
		return false;
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly. The method returns a value that indicates whether the conversion succeeded.</summary>
	/// <param name="s">A string containing a date and time to convert.</param>
	/// <param name="format">The required format of <paramref name="s" />.</param>
	/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />.</param>
	/// <param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of <paramref name="s" />.</param>
	/// <param name="result">When this method returns, contains the <see cref="T:System.DateTime" /> value equivalent to the date and time contained in <paramref name="s" />, if the conversion succeeded, or <see cref="F:System.DateTime.MinValue" /> if the conversion failed. The conversion fails if either the <paramref name="s" /> or <paramref name="format" /> parameter is <see langword="null" />, is an empty string, or does not contain a date and time that correspond to the pattern specified in <paramref name="format" />. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="s" /> was converted successfully; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="styles" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.  
	/// -or-  
	/// <paramref name="styles" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values (for example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />).</exception>
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result)
	{
		result = default(DateTime);
		return false;
	}

	/// <summary>Adds a specified time interval to a specified date and time, yielding a new date and time.</summary>
	/// <param name="d">The date and time value to add.</param>
	/// <param name="t">The time interval to add.</param>
	/// <returns>An object that is the sum of the values of <paramref name="d" /> and <paramref name="t" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public static DateTime operator +(DateTime d, TimeSpan t)
	{
		return default(DateTime);
	}

	/// <summary>Subtracts a specified time interval from a specified date and time and returns a new date and time.</summary>
	/// <param name="d">The date and time value to subtract from.</param>
	/// <param name="t">The time interval to subtract.</param>
	/// <returns>An object whose value is the value of <paramref name="d" /> minus the value of <paramref name="t" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />.</exception>
	public static DateTime operator -(DateTime d, TimeSpan t)
	{
		return default(DateTime);
	}

	/// <summary>Subtracts a specified date and time from another specified date and time and returns a time interval.</summary>
	/// <param name="d1">The date and time value to subtract from (the minuend).</param>
	/// <param name="d2">The date and time value to subtract (the subtrahend).</param>
	/// <returns>The time interval between <paramref name="d1" /> and <paramref name="d2" />; that is, <paramref name="d1" /> minus <paramref name="d2" />.</returns>
	public static TimeSpan operator -(DateTime d1, DateTime d2)
	{
		return default(TimeSpan);
	}

	/// <summary>Determines whether two specified instances of <see cref="T:System.DateTime" /> are equal.</summary>
	/// <param name="d1">The first object to compare.</param>
	/// <param name="d2">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> and <paramref name="d2" /> represent the same date and time; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(DateTime d1, DateTime d2)
	{
		return false;
	}

	/// <summary>Determines whether two specified instances of <see cref="T:System.DateTime" /> are not equal.</summary>
	/// <param name="d1">The first object to compare.</param>
	/// <param name="d2">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> and <paramref name="d2" /> do not represent the same date and time; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(DateTime d1, DateTime d2)
	{
		return false;
	}

	/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> is earlier than another specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="t1">The first object to compare.</param>
	/// <param name="t2">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="t1" /> is earlier than <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator <(DateTime t1, DateTime t2)
	{
		return false;
	}

	/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> represents a date and time that is the same as or earlier than another specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="t1">The first object to compare.</param>
	/// <param name="t2">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="t1" /> is the same as or earlier than <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator <=(DateTime t1, DateTime t2)
	{
		return false;
	}

	/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> is later than another specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="t1">The first object to compare.</param>
	/// <param name="t2">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="t1" /> is later than <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator >(DateTime t1, DateTime t2)
	{
		return false;
	}

	/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> represents a date and time that is the same as or later than another specified <see cref="T:System.DateTime" />.</summary>
	/// <param name="t1">The first object to compare.</param>
	/// <param name="t2">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="t1" /> is the same as or later than <paramref name="t2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator >=(DateTime t1, DateTime t2)
	{
		return false;
	}

	/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.DateTime" />.</summary>
	/// <returns>The enumerated constant, <see cref="F:System.TypeCode.DateTime" />.</returns>
	public TypeCode GetTypeCode()
	{
		return default(TypeCode);
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return false;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	char IConvertible.ToChar(IFormatProvider provider)
	{
		return '\0';
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return 0;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return 0u;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return 0L;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return 0uL;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return 0f;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return 0.0;
	}

	/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The return value for this member is not used.</returns>
	/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return default(decimal);
	}

	/// <summary>Returns the current <see cref="T:System.DateTime" /> object.</summary>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>The current object.</returns>
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return default(DateTime);
	}

	/// <summary>Converts the current <see cref="T:System.DateTime" /> object to an object of a specified type.</summary>
	/// <param name="type">The desired type.</param>
	/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify <see langword="null" />.)</param>
	/// <returns>An object of the type specified by the <paramref name="type" /> parameter, with a value equivalent to the current <see cref="T:System.DateTime" /> object.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DateTime" /> type.</exception>
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return null;
	}

	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result)
	{
		result = default(DateTime);
		return false;
	}

	internal static long GetSystemTimeAsFileTime()
	{
		return 0L;
	}

	internal long ToBinaryRaw()
	{
		return 0L;
	}
}
