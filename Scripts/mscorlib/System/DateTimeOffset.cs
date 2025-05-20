using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Represents a point in time, typically expressed as a date and time of day, relative to Coordinated Universal Time (UTC).</summary>
[Serializable]
[StructLayout((LayoutKind)3)]
public readonly struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable
{
	/// <summary>Represents the earliest possible <see cref="T:System.DateTimeOffset" /> value. This field is read-only.</summary>
	public static readonly DateTimeOffset MinValue;

	/// <summary>Represents the greatest possible value of <see cref="T:System.DateTimeOffset" />. This field is read-only.</summary>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <see cref="F:System.DateTime.MaxValue" /> is outside the range of the current or specified culture's default calendar.</exception>
	public static readonly DateTimeOffset MaxValue;

	public static readonly DateTimeOffset UnixEpoch;

	private readonly DateTime _dateTime;

	private readonly short _offsetMinutes;

	/// <summary>Gets a <see cref="T:System.DateTimeOffset" /> object that is set to the current date and time on the current computer, with the offset set to the local time's offset from Coordinated Universal Time (UTC).</summary>
	/// <returns>A <see cref="T:System.DateTimeOffset" /> object whose date and time is the current local time and whose offset is the local time zone's offset from Coordinated Universal Time (UTC).</returns>
	public static DateTimeOffset Now => default(DateTimeOffset);

	/// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The date and time of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
	public DateTime DateTime => default(DateTime);

	/// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the Coordinated Universal Time (UTC) date and time of the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The Coordinated Universal Time (UTC) date and time of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
	public DateTime UtcDateTime => default(DateTime);

	/// <summary>Gets a <see cref="T:System.DateTime" /> value that represents the local date and time of the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The local date and time of the current <see cref="T:System.DateTimeOffset" /> object.</returns>
	public DateTime LocalDateTime => default(DateTime);

	private DateTime ClockDateTime => default(DateTime);

	/// <summary>Gets the day of the month represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The day component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as a value between 1 and 31.</returns>
	public int Day => 0;

	/// <summary>Gets the hour component of the time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The hour component of the current <see cref="T:System.DateTimeOffset" /> object. This property uses a 24-hour clock; the value ranges from 0 to 23.</returns>
	public int Hour => 0;

	/// <summary>Gets the millisecond component of the time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The millisecond component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer between 0 and 999.</returns>
	public int Millisecond => 0;

	/// <summary>Gets the minute component of the time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The minute component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer between 0 and 59.</returns>
	public int Minute => 0;

	/// <summary>Gets the month component of the date represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The month component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer between 1 and 12.</returns>
	public int Month => 0;

	/// <summary>Gets the time's offset from Coordinated Universal Time (UTC).</summary>
	/// <returns>The difference between the current <see cref="T:System.DateTimeOffset" /> object's time value and Coordinated Universal Time (UTC).</returns>
	public TimeSpan Offset => default(TimeSpan);

	/// <summary>Gets the second component of the clock time represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The second component of the <see cref="T:System.DateTimeOffset" /> object, expressed as an integer value between 0 and 59.</returns>
	public int Second => 0;

	/// <summary>Gets the number of ticks that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object in clock time.</summary>
	/// <returns>The number of ticks in the <see cref="T:System.DateTimeOffset" /> object's clock time.</returns>
	public long Ticks => 0L;

	/// <summary>Gets the time of day for the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The time interval of the current date that has elapsed since midnight.</returns>
	public TimeSpan TimeOfDay => default(TimeSpan);

	/// <summary>Gets the year component of the date represented by the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>The year component of the current <see cref="T:System.DateTimeOffset" /> object, expressed as an integer value between 0 and 9999.</returns>
	public int Year => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified number of ticks and offset.</summary>
	/// <param name="ticks">A date and time expressed as the number of 100-nanosecond intervals that have elapsed since 12:00:00 midnight on January 1, 0001.</param>
	/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" /> is not specified in whole minutes.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.  
	///  -or-  
	///  <paramref name="ticks" /> is less than <see langword="DateTimeOffset.MinValue.Ticks" /> or greater than <see langword="DateTimeOffset.MaxValue.Ticks" />.  
	///  -or-  
	///  <paramref name="Offset" /> s less than -14 hours or greater than 14 hours.</exception>
	public DateTimeOffset(long ticks, TimeSpan offset)
	{
		_dateTime = default(DateTime);
		_offsetMinutes = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified <see cref="T:System.DateTime" /> value.</summary>
	/// <param name="dateTime">A date and time.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The Coordinated Universal Time (UTC) date and time that results from applying the offset is earlier than <see cref="F:System.DateTimeOffset.MinValue" />.  
	///  -or-  
	///  The UTC date and time that results from applying the offset is later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
	public DateTimeOffset(DateTime dateTime)
	{
		_dateTime = default(DateTime);
		_offsetMinutes = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified <see cref="T:System.DateTime" /> value and offset.</summary>
	/// <param name="dateTime">A date and time.</param>
	/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="dateTime.Kind" /> equals <see cref="F:System.DateTimeKind.Utc" /> and <paramref name="offset" /> does not equal zero.  
	/// -or-  
	/// <paramref name="dateTime.Kind" /> equals <see cref="F:System.DateTimeKind.Local" /> and <paramref name="offset" /> does not equal the offset of the system's local time zone.  
	/// -or-  
	/// <paramref name="offset" /> is not specified in whole minutes.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="offset" /> is less than -14 hours or greater than 14 hours.  
	/// -or-  
	/// <see cref="P:System.DateTimeOffset.UtcDateTime" /> is less than <see cref="F:System.DateTimeOffset.MinValue" /> or greater than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
	public DateTimeOffset(DateTime dateTime, TimeSpan offset)
	{
		_dateTime = default(DateTime);
		_offsetMinutes = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified year, month, day, hour, minute, second, and offset.</summary>
	/// <param name="year">The year (1 through 9999).</param>
	/// <param name="month">The month (1 through 12).</param>
	/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
	/// <param name="hour">The hours (0 through 23).</param>
	/// <param name="minute">The minutes (0 through 59).</param>
	/// <param name="second">The seconds (0 through 59).</param>
	/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" /> does not represent whole minutes.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is less than one or greater than 9999.  
	/// -or-  
	/// <paramref name="month" /> is less than one or greater than 12.  
	/// -or-  
	/// <paramref name="day" /> is less than one or greater than the number of days in <paramref name="month" />.  
	/// -or-  
	/// <paramref name="hour" /> is less than zero or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="offset" /> is less than -14 hours or greater than 14 hours.  
	/// -or-  
	/// The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
	{
		_dateTime = default(DateTime);
		_offsetMinutes = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified year, month, day, hour, minute, second, millisecond, and offset.</summary>
	/// <param name="year">The year (1 through 9999).</param>
	/// <param name="month">The month (1 through 12).</param>
	/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
	/// <param name="hour">The hours (0 through 23).</param>
	/// <param name="minute">The minutes (0 through 59).</param>
	/// <param name="second">The seconds (0 through 59).</param>
	/// <param name="millisecond">The milliseconds (0 through 999).</param>
	/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" /> does not represent whole minutes.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is less than one or greater than 9999.  
	/// -or-  
	/// <paramref name="month" /> is less than one or greater than 12.  
	/// -or-  
	/// <paramref name="day" /> is less than one or greater than the number of days in <paramref name="month" />.  
	/// -or-  
	/// <paramref name="hour" /> is less than zero or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="millisecond" /> is less than 0 or greater than 999.  
	/// -or-  
	/// <paramref name="offset" /> is less than -14 or greater than 14.  
	/// -or-  
	/// The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset)
	{
		_dateTime = default(DateTime);
		_offsetMinutes = 0;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.DateTimeOffset" /> structure using the specified year, month, day, hour, minute, second, millisecond, and offset of a specified calendar.</summary>
	/// <param name="year">The year.</param>
	/// <param name="month">The month (1 through 12).</param>
	/// <param name="day">The day (1 through the number of days in <paramref name="month" />).</param>
	/// <param name="hour">The hours (0 through 23).</param>
	/// <param name="minute">The minutes (0 through 59).</param>
	/// <param name="second">The seconds (0 through 59).</param>
	/// <param name="millisecond">The milliseconds (0 through 999).</param>
	/// <param name="calendar">The calendar that is used to interpret <paramref name="year" />, <paramref name="month" />, and <paramref name="day" />.</param>
	/// <param name="offset">The time's offset from Coordinated Universal Time (UTC).</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="offset" /> does not represent whole minutes.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="calendar" /> cannot be <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is less than the <paramref name="calendar" /> parameter's <see langword="MinSupportedDateTime.Year" /> or greater than <see langword="MaxSupportedDateTime.Year" />.  
	/// -or-  
	/// <paramref name="month" /> is either less than or greater than the number of months in <paramref name="year" /> in the <paramref name="calendar" />.  
	/// -or-  
	/// <paramref name="day" /> is less than one or greater than the number of days in <paramref name="month" />.  
	/// -or-  
	/// <paramref name="hour" /> is less than zero or greater than 23.  
	/// -or-  
	/// <paramref name="minute" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="second" /> is less than 0 or greater than 59.  
	/// -or-  
	/// <paramref name="millisecond" /> is less than 0 or greater than 999.  
	/// -or-  
	/// <paramref name="offset" /> is less than -14 hours or greater than 14 hours.  
	/// -or-  
	/// The <paramref name="year" />, <paramref name="month" />, and <paramref name="day" /> parameters cannot be represented as a date and time value.  
	/// -or-  
	/// The <see cref="P:System.DateTimeOffset.UtcDateTime" /> property is earlier than <see cref="F:System.DateTimeOffset.MinValue" /> or later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
	public DateTimeOffset(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset)
	{
		_dateTime = default(DateTime);
		_offsetMinutes = 0;
	}

	/// <summary>Compares two <see cref="T:System.DateTimeOffset" /> objects and indicates whether the first is earlier than the second, equal to the second, or later than the second.</summary>
	/// <param name="first">The first object to compare.</param>
	/// <param name="second">The second object to compare.</param>
	/// <returns>A signed integer that indicates whether the value of the <paramref name="first" /> parameter is earlier than, later than, or the same time as the value of the <paramref name="second" /> parameter, as the following table shows.  
	///   Return value  
	///
	///   Meaning  
	///
	///   Less than zero  
	///
	///  <paramref name="first" /> is earlier than <paramref name="second" />.  
	///
	///   Zero  
	///
	///  <paramref name="first" /> is equal to <paramref name="second" />.  
	///
	///   Greater than zero  
	///
	///  <paramref name="first" /> is later than <paramref name="second" />.</returns>
	public static int Compare(DateTimeOffset first, DateTimeOffset second)
	{
		return 0;
	}

	/// <summary>Compares the value of the current <see cref="T:System.DateTimeOffset" /> object with another object of the same type.</summary>
	/// <param name="obj">The object to compare with the current <see cref="T:System.DateTimeOffset" /> object.</param>
	/// <returns>A 32-bit signed integer that indicates whether the current <see cref="T:System.DateTimeOffset" /> object is less than, equal to, or greater than <paramref name="obj" />. The return values of the method are interpreted as follows:  
	///   Return Value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   The current <see cref="T:System.DateTimeOffset" /> object is less than (earlier than) <paramref name="obj" />.  
	///
	///   Zero  
	///
	///   The current <see cref="T:System.DateTimeOffset" /> object is equal to (the same point in time as) <paramref name="obj" />.  
	///
	///   Greater than zero  
	///
	///   The current <see cref="T:System.DateTimeOffset" /> object is greater than (later than) <paramref name="obj" />.</returns>
	int IComparable.CompareTo(object obj)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.DateTimeOffset" /> object to a specified <see cref="T:System.DateTimeOffset" /> object and indicates whether the current object is earlier than, the same as, or later than the second <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <param name="other">An object to compare with the current <see cref="T:System.DateTimeOffset" /> object.</param>
	/// <returns>A signed integer that indicates the relationship between the current <see cref="T:System.DateTimeOffset" /> object and <paramref name="other" />, as the following table shows.  
	///   Return Value  
	///
	///   Description  
	///
	///   Less than zero  
	///
	///   The current <see cref="T:System.DateTimeOffset" /> object is earlier than <paramref name="other" />.  
	///
	///   Zero  
	///
	///   The current <see cref="T:System.DateTimeOffset" /> object is the same as <paramref name="other" />.  
	///
	///   Greater than zero.  
	///
	///   The current <see cref="T:System.DateTimeOffset" /> object is later than <paramref name="other" />.</returns>
	public int CompareTo(DateTimeOffset other)
	{
		return 0;
	}

	/// <summary>Determines whether a <see cref="T:System.DateTimeOffset" /> object represents the same point in time as a specified object.</summary>
	/// <param name="obj">The object to compare to the current <see cref="T:System.DateTimeOffset" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="obj" /> parameter is a <see cref="T:System.DateTimeOffset" /> object and represents the same point in time as the current <see cref="T:System.DateTimeOffset" /> object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Determines whether the current <see cref="T:System.DateTimeOffset" /> object represents the same point in time as a specified <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <param name="other">An object to compare to the current <see cref="T:System.DateTimeOffset" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if both <see cref="T:System.DateTimeOffset" /> objects have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, <see langword="false" />.</returns>
	public bool Equals(DateTimeOffset other)
	{
		return false;
	}

	/// <summary>Converts the specified Windows file time to an equivalent local time.</summary>
	/// <param name="fileTime">A Windows file time, expressed in ticks.</param>
	/// <returns>An object that represents the date and time of <paramref name="fileTime" /> with the offset set to the local time offset.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="filetime" /> is less than zero.  
	/// -or-  
	/// <paramref name="filetime" /> is greater than <see langword="DateTimeOffset.MaxValue.Ticks" />.</exception>
	public static DateTimeOffset FromFileTime(long fileTime)
	{
		return default(DateTimeOffset);
	}

	/// <summary>Runs when the deserialization of an object has been completed.</summary>
	/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data required to serialize the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <param name="info">The object to populate with data.</param>
	/// <param name="context">The destination for this serialization (see <see cref="T:System.Runtime.Serialization.StreamingContext" />).</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.</exception>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private DateTimeOffset(SerializationInfo info, StreamingContext context)
	{
		_dateTime = default(DateTime);
		_offsetMinutes = 0;
	}

	/// <summary>Returns the hash code for the current <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified culture-specific format information.</summary>
	/// <param name="input">A string that contains a date and time to convert.</param>
	/// <param name="formatProvider">An object that provides culture-specific format information about <paramref name="input" />.</param>
	/// <returns>An object that is equivalent to the date and time that is contained in <paramref name="input" />, as specified by <paramref name="formatProvider" />.</returns>
	/// <exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="input" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="input" /> does not contain a valid string representation of a date and time.  
	/// -or-  
	/// <paramref name="input" /> contains the string representation of an offset value without a date or time.</exception>
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider)
	{
		return default(DateTimeOffset);
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified culture-specific format information and formatting style.</summary>
	/// <param name="input">A string that contains a date and time to convert.</param>
	/// <param name="formatProvider">An object that provides culture-specific format information about <paramref name="input" />.</param>
	/// <param name="styles">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="input" />. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
	/// <returns>An object that is equivalent to the date and time that is contained in <paramref name="input" /> as specified by <paramref name="formatProvider" /> and <paramref name="styles" />.</returns>
	/// <exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.  
	///  -or-  
	///  <paramref name="styles" /> is not a valid <see cref="T:System.Globalization.DateTimeStyles" /> value.  
	///  -or-  
	///  <paramref name="styles" /> includes an unsupported <see cref="T:System.Globalization.DateTimeStyles" /> value.  
	///  -or-  
	///  <paramref name="styles" /> includes <see cref="T:System.Globalization.DateTimeStyles" /> values that cannot be used together.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="input" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="input" /> does not contain a valid string representation of a date and time.  
	/// -or-  
	/// <paramref name="input" /> contains the string representation of an offset value without a date or time.</exception>
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles)
	{
		return default(DateTimeOffset);
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly.</summary>
	/// <param name="input">A string that contains a date and time to convert.</param>
	/// <param name="format">A format specifier that defines the expected format of <paramref name="input" />.</param>
	/// <param name="formatProvider">An object that supplies culture-specific formatting information about <paramref name="input" />.</param>
	/// <param name="styles">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="input" />.</param>
	/// <returns>An object that is equivalent to the date and time that is contained in the <paramref name="input" /> parameter, as specified by the <paramref name="format" />, <paramref name="formatProvider" />, and <paramref name="styles" /> parameters.</returns>
	/// <exception cref="T:System.ArgumentException">The offset is greater than 14 hours or less than -14 hours.  
	///  -or-  
	///  The <paramref name="styles" /> parameter includes an unsupported value.  
	///  -or-  
	///  The <paramref name="styles" /> parameter contains <see cref="T:System.Globalization.DateTimeStyles" /> values that cannot be used together.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="input" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="format" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.FormatException">
	///   <paramref name="input" /> is an empty string ("").  
	/// -or-  
	/// <paramref name="input" /> does not contain a valid string representation of a date and time.  
	/// -or-  
	/// <paramref name="format" /> is an empty string.  
	/// -or-  
	/// The hour component and the AM/PM designator in <paramref name="input" /> do not agree.</exception>
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles)
	{
		return default(DateTimeOffset);
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to a Windows file time.</summary>
	/// <returns>The value of the current <see cref="T:System.DateTimeOffset" /> object, expressed as a Windows file time.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting file time would represent a date and time before midnight on January 1, 1601 C.E. Coordinated Universal Time (UTC).</exception>
	public long ToFileTime()
	{
		return 0L;
	}

	/// <summary>Returns the number of seconds that have elapsed since 1970-01-01T00:00:00Z.</summary>
	/// <returns>The number of seconds that have elapsed since 1970-01-01T00:00:00Z.</returns>
	public long ToUnixTimeSeconds()
	{
		return 0L;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to its equivalent string representation.</summary>
	/// <returns>A string representation of a <see cref="T:System.DateTimeOffset" /> object that includes the offset appended at the end of the string.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture.</exception>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to its equivalent string representation using the specified culture-specific formatting information.</summary>
	/// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A string representation of the value of the current <see cref="T:System.DateTimeOffset" /> object, as specified by <paramref name="formatProvider" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="formatProvider" />.</exception>
	public string ToString(IFormatProvider formatProvider)
	{
		return null;
	}

	/// <summary>Converts the value of the current <see cref="T:System.DateTimeOffset" /> object to its equivalent string representation using the specified format and culture-specific format information.</summary>
	/// <param name="format">A format string.</param>
	/// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
	/// <returns>A string representation of the value of the current <see cref="T:System.DateTimeOffset" /> object, as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
	/// <exception cref="T:System.FormatException">The length of <paramref name="format" /> is one, and it is not one of the standard format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.  
	///  -or-  
	///  <paramref name="format" /> does not contain a valid custom format pattern.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="formatProvider" />.</exception>
	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider formatProvider = null)
	{
		charsWritten = default(int);
		return false;
	}

	/// <summary>Converts the current <see cref="T:System.DateTimeOffset" /> object to a <see cref="T:System.DateTimeOffset" /> value that represents the Coordinated Universal Time (UTC).</summary>
	/// <returns>An object that represents the date and time of the current <see cref="T:System.DateTimeOffset" /> object converted to Coordinated Universal Time (UTC).</returns>
	public DateTimeOffset ToUniversalTime()
	{
		return default(DateTimeOffset);
	}

	/// <summary>Tries to convert a specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent, and returns a value that indicates whether the conversion succeeded.</summary>
	/// <param name="input">A string that contains a date and time to convert.</param>
	/// <param name="formatProvider">An object that provides culture-specific formatting information about <paramref name="input" />.</param>
	/// <param name="styles">A bitwise combination of enumeration values that indicates the permitted format of <paramref name="input" />.</param>
	/// <param name="result">When the method returns, contains the <see cref="T:System.DateTimeOffset" /> value equivalent to the date and time of <paramref name="input" />, if the conversion succeeded, or <see cref="F:System.DateTimeOffset.MinValue" />, if the conversion failed. The conversion fails if the <paramref name="input" /> parameter is <see langword="null" /> or does not contain a valid string representation of a date and time. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="input" /> parameter is successfully converted; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="styles" /> includes an undefined <see cref="T:System.Globalization.DateTimeStyles" /> value.  
	/// -or-  
	/// <see cref="F:System.Globalization.DateTimeStyles.NoCurrentDateDefault" /> is not supported.  
	/// -or-  
	/// <paramref name="styles" /> includes mutually exclusive <see cref="T:System.Globalization.DateTimeStyles" /> values.</exception>
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
	{
		result = default(DateTimeOffset);
		return false;
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly.</summary>
	/// <param name="input">A string that contains a date and time to convert.</param>
	/// <param name="format">A format specifier that defines the required format of <paramref name="input" />.</param>
	/// <param name="formatProvider">An object that supplies culture-specific formatting information about <paramref name="input" />.</param>
	/// <param name="styles">A bitwise combination of enumeration values that indicates the permitted format of input. A typical value to specify is <see langword="None" />.</param>
	/// <param name="result">When the method returns, contains the <see cref="T:System.DateTimeOffset" /> equivalent to the date and time of <paramref name="input" />, if the conversion succeeded, or <see cref="F:System.DateTimeOffset.MinValue" />, if the conversion failed. The conversion fails if the <paramref name="input" /> parameter is <see langword="null" />, or does not contain a valid string representation of a date and time in the expected format defined by <paramref name="format" /> and provider. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="input" /> parameter is successfully converted; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="styles" /> includes an undefined <see cref="T:System.Globalization.DateTimeStyles" /> value.  
	/// -or-  
	/// <see cref="F:System.Globalization.DateTimeStyles.NoCurrentDateDefault" /> is not supported.  
	/// -or-  
	/// <paramref name="styles" /> includes mutually exclusive <see cref="T:System.Globalization.DateTimeStyles" /> values.</exception>
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
	{
		result = default(DateTimeOffset);
		return false;
	}

	/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTimeOffset" /> equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match one of the specified formats exactly.</summary>
	/// <param name="input">A string that contains a date and time to convert.</param>
	/// <param name="formats">An array that defines the expected formats of <paramref name="input" />.</param>
	/// <param name="formatProvider">An object that supplies culture-specific formatting information about <paramref name="input" />.</param>
	/// <param name="styles">A bitwise combination of enumeration values that indicates the permitted format of input. A typical value to specify is <see langword="None" />.</param>
	/// <param name="result">When the method returns, contains the <see cref="T:System.DateTimeOffset" /> equivalent to the date and time of <paramref name="input" />, if the conversion succeeded, or <see cref="F:System.DateTimeOffset.MinValue" />, if the conversion failed. The conversion fails if the <paramref name="input" /> does not contain a valid string representation of a date and time, or does not contain the date and time in the expected format defined by <paramref name="format" />, or if <paramref name="formats" /> is <see langword="null" />. This parameter is passed uninitialized.</param>
	/// <returns>
	///   <see langword="true" /> if the <paramref name="input" /> parameter is successfully converted; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="styles" /> includes an undefined <see cref="T:System.Globalization.DateTimeStyles" /> value.  
	/// -or-  
	/// <see cref="F:System.Globalization.DateTimeStyles.NoCurrentDateDefault" /> is not supported.  
	/// -or-  
	/// <paramref name="styles" /> includes mutually exclusive <see cref="T:System.Globalization.DateTimeStyles" /> values.</exception>
	public static bool TryParseExact(string input, string[] formats, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result)
	{
		result = default(DateTimeOffset);
		return false;
	}

	private static short ValidateOffset(TimeSpan offset)
	{
		return 0;
	}

	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset)
	{
		return default(DateTime);
	}

	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName)
	{
		return default(DateTimeStyles);
	}

	/// <summary>Defines an implicit conversion of a <see cref="T:System.DateTime" /> object to a <see cref="T:System.DateTimeOffset" /> object.</summary>
	/// <param name="dateTime">The object to convert.</param>
	/// <returns>The converted object.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The Coordinated Universal Time (UTC) date and time that results from applying the offset is earlier than <see cref="F:System.DateTimeOffset.MinValue" />.  
	///  -or-  
	///  The UTC date and time that results from applying the offset is later than <see cref="F:System.DateTimeOffset.MaxValue" />.</exception>
	public static implicit operator DateTimeOffset(DateTime dateTime)
	{
		return default(DateTimeOffset);
	}

	/// <summary>Subtracts one <see cref="T:System.DateTimeOffset" /> object from another and yields a time interval.</summary>
	/// <param name="left">The minuend.</param>
	/// <param name="right">The subtrahend.</param>
	/// <returns>An object that represents the difference between <paramref name="left" /> and <paramref name="right" />.</returns>
	public static TimeSpan operator -(DateTimeOffset left, DateTimeOffset right)
	{
		return default(TimeSpan);
	}

	/// <summary>Determines whether two specified <see cref="T:System.DateTimeOffset" /> objects represent the same point in time.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if both <see cref="T:System.DateTimeOffset" /> objects have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(DateTimeOffset left, DateTimeOffset right)
	{
		return false;
	}

	/// <summary>Determines whether two specified <see cref="T:System.DateTimeOffset" /> objects refer to different points in time.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> and <paramref name="right" /> do not have the same <see cref="P:System.DateTimeOffset.UtcDateTime" /> value; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(DateTimeOffset left, DateTimeOffset right)
	{
		return false;
	}
}
