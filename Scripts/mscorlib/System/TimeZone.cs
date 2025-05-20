using System.Globalization;

namespace System;

/// <summary>Represents a time zone.</summary>
[Serializable]
[Obsolete("System.TimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo instead.")]
public abstract class TimeZone
{
	private static TimeZone currentTimeZone;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject => null;

	/// <summary>Gets the time zone of the current computer.</summary>
	/// <returns>A <see cref="T:System.TimeZone" /> object that represents the current local time zone.</returns>
	public static TimeZone CurrentTimeZone => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.TimeZone" /> class.</summary>
	protected TimeZone()
	{
	}

	/// <summary>Returns the Coordinated Universal Time (UTC) offset for the specified local time.</summary>
	/// <param name="time">A date and time value.</param>
	/// <returns>The Coordinated Universal Time (UTC) offset from <paramref name="time" />.</returns>
	public abstract TimeSpan GetUtcOffset(DateTime time);

	/// <summary>Returns the daylight saving time period for a particular year.</summary>
	/// <param name="year">The year that the daylight saving time period applies to.</param>
	/// <returns>A <see cref="T:System.Globalization.DaylightTime" /> object that contains the start and end date for daylight saving time in <paramref name="year" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="year" /> is less than 1 or greater than 9999.</exception>
	public abstract DaylightTime GetDaylightChanges(int year);

	internal static TimeSpan CalculateUtcOffset(DateTime time, DaylightTime daylightTimes)
	{
		return default(TimeSpan);
	}
}
