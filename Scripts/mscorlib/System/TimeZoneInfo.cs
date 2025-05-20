using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Microsoft.Win32;

namespace System;

/// <summary>Represents any time zone in the world.</summary>
[Serializable]
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public sealed class TimeZoneInfo : IEquatable<TimeZoneInfo>, ISerializable, IDeserializationCallback
{
	private sealed class CachedData
	{
		private OffsetAndRule _oneYearLocalFromUtc;

		private TimeZoneInfo _localTimeZone;

		public Dictionary<string, TimeZoneInfo> _systemTimeZones;

		public ReadOnlyCollection<TimeZoneInfo> _readOnlySystemTimeZones;

		public bool _allSystemTimeZonesRead;

		public TimeZoneInfo Local => null;

		private static TimeZoneInfo GetCurrentOneYearLocal()
		{
			return null;
		}

		public OffsetAndRule GetOneYearLocalFromUtc(int year)
		{
			return null;
		}

		private TimeZoneInfo CreateLocal()
		{
			return null;
		}

		public DateTimeKind GetCorrespondingKind(TimeZoneInfo timeZone)
		{
			return default(DateTimeKind);
		}
	}

	private sealed class OffsetAndRule
	{
		public readonly int Year;

		public readonly TimeSpan Offset;

		public readonly AdjustmentRule Rule;

		public OffsetAndRule(int year, TimeSpan offset, AdjustmentRule rule)
		{
		}
	}

	[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
	internal struct DYNAMIC_TIME_ZONE_INFORMATION
	{
		internal Interop.Kernel32.TIME_ZONE_INFORMATION TZI;

		internal string TimeZoneKeyName;

		internal byte DynamicDaylightTimeDisabled;
	}

	private enum TimeZoneInfoResult
	{
		Success = 0,
		TimeZoneNotFoundException = 1,
		InvalidTimeZoneException = 2,
		SecurityException = 3
	}

	/// <summary>Provides information about a time zone adjustment, such as the transition to and from daylight saving time.</summary>
	[Serializable]
	public sealed class AdjustmentRule : IEquatable<AdjustmentRule>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _dateStart;

		private readonly DateTime _dateEnd;

		private readonly TimeSpan _daylightDelta;

		private readonly TransitionTime _daylightTransitionStart;

		private readonly TransitionTime _daylightTransitionEnd;

		private readonly TimeSpan _baseUtcOffsetDelta;

		private readonly bool _noDaylightTransitions;

		/// <summary>Gets the date when the adjustment rule takes effect.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> value that indicates when the adjustment rule takes effect.</returns>
		public DateTime DateStart => default(DateTime);

		/// <summary>Gets the date when the adjustment rule ceases to be in effect.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> value that indicates the end date of the adjustment rule.</returns>
		public DateTime DateEnd => default(DateTime);

		/// <summary>Gets the amount of time that is required to form the time zone's daylight saving time. This amount of time is added to the time zone's offset from Coordinated Universal Time (UTC).</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> object that indicates the amount of time to add to the standard time changes as a result of the adjustment rule.</returns>
		public TimeSpan DaylightDelta => default(TimeSpan);

		/// <summary>Gets information about the annual transition from standard time to daylight saving time.</summary>
		/// <returns>A <see cref="T:System.TimeZoneInfo.TransitionTime" /> object that defines the annual transition from a time zone's standard time to daylight saving time.</returns>
		public TransitionTime DaylightTransitionStart => default(TransitionTime);

		/// <summary>Gets information about the annual transition from daylight saving time back to standard time.</summary>
		/// <returns>A <see cref="T:System.TimeZoneInfo.TransitionTime" /> object that defines the annual transition from daylight saving time back to the time zone's standard time.</returns>
		public TransitionTime DaylightTransitionEnd => default(TransitionTime);

		internal TimeSpan BaseUtcOffsetDelta => default(TimeSpan);

		internal bool NoDaylightTransitions => false;

		internal bool HasDaylightSaving => false;

		/// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> object is equal to a second <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> object.</summary>
		/// <param name="other">The object to compare with the current object.</param>
		/// <returns>
		///   <see langword="true" /> if both <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> objects have equal values; otherwise, <see langword="false" />.</returns>
		public bool Equals(AdjustmentRule other)
		{
			return false;
		}

		/// <summary>Serves as a hash function for hashing algorithms and data structures such as hash tables.</summary>
		/// <returns>A 32-bit signed integer that serves as the hash code for the current <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> object.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		private AdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
		{
		}

		internal static AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
		{
			return null;
		}

		internal bool IsStartDateMarkerForBeginningOfYear()
		{
			return false;
		}

		internal bool IsEndDateMarkerForEndOfYear()
		{
			return false;
		}

		private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TransitionTime daylightTransitionStart, TransitionTime daylightTransitionEnd, bool noDaylightTransitions)
		{
		}

		/// <summary>Runs when the deserialization of a <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> object is completed.</summary>
		/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data that is required to serialize this object.</summary>
		/// <param name="info">The object to populate with data.</param>
		/// <param name="context">The destination for this serialization (see <see cref="T:System.Runtime.Serialization.StreamingContext" />).</param>
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private AdjustmentRule(SerializationInfo info, StreamingContext context)
		{
		}

		internal AdjustmentRule()
		{
		}
	}

	/// <summary>Provides information about a specific time change, such as the change from daylight saving time to standard time or vice versa, in a particular time zone.</summary>
	[Serializable]
	public readonly struct TransitionTime : IEquatable<TransitionTime>, ISerializable, IDeserializationCallback
	{
		private readonly DateTime _timeOfDay;

		private readonly byte _month;

		private readonly byte _week;

		private readonly byte _day;

		private readonly DayOfWeek _dayOfWeek;

		private readonly bool _isFixedDateRule;

		/// <summary>Gets the hour, minute, and second at which the time change occurs.</summary>
		/// <returns>The time of day at which the time change occurs.</returns>
		public DateTime TimeOfDay => default(DateTime);

		/// <summary>Gets the month in which the time change occurs.</summary>
		/// <returns>The month in which the time change occurs.</returns>
		public int Month => 0;

		/// <summary>Gets the week of the month in which a time change occurs.</summary>
		/// <returns>The week of the month in which the time change occurs.</returns>
		public int Week => 0;

		/// <summary>Gets the day on which the time change occurs.</summary>
		/// <returns>The day on which the time change occurs.</returns>
		public int Day => 0;

		/// <summary>Gets the day of the week on which the time change occurs.</summary>
		/// <returns>The day of the week on which the time change occurs.</returns>
		public DayOfWeek DayOfWeek => default(DayOfWeek);

		/// <summary>Gets a value indicating whether the time change occurs at a fixed date and time (such as November 1) or a floating date and time (such as the last Sunday of October).</summary>
		/// <returns>
		///   <see langword="true" /> if the time change rule is fixed-date; <see langword="false" /> if the time change rule is floating-date.</returns>
		public bool IsFixedDateRule => false;

		/// <summary>Determines whether an object has identical values to the current <see cref="T:System.TimeZoneInfo.TransitionTime" /> object.</summary>
		/// <param name="obj">An object to compare with the current <see cref="T:System.TimeZoneInfo.TransitionTime" /> object.</param>
		/// <returns>
		///   <see langword="true" /> if the two objects are equal; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Determines whether two specified <see cref="T:System.TimeZoneInfo.TransitionTime" /> objects are not equal.</summary>
		/// <param name="t1">The first object to compare.</param>
		/// <param name="t2">The second object to compare.</param>
		/// <returns>
		///   <see langword="true" /> if <paramref name="t1" /> and <paramref name="t2" /> have any different member values; otherwise, <see langword="false" />.</returns>
		public static bool operator !=(TransitionTime t1, TransitionTime t2)
		{
			return false;
		}

		/// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo.TransitionTime" /> object has identical values to a second <see cref="T:System.TimeZoneInfo.TransitionTime" /> object.</summary>
		/// <param name="other">An object to compare to the current instance.</param>
		/// <returns>
		///   <see langword="true" /> if the two objects have identical property values; otherwise, <see langword="false" />.</returns>
		public bool Equals(TransitionTime other)
		{
			return false;
		}

		/// <summary>Serves as a hash function for hashing algorithms and data structures such as hash tables.</summary>
		/// <returns>A 32-bit signed integer that serves as the hash code for this <see cref="T:System.TimeZoneInfo.TransitionTime" /> object.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		private TransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule)
		{
			_timeOfDay = default(DateTime);
			_month = 0;
			_week = 0;
			_day = 0;
			_dayOfWeek = default(DayOfWeek);
			_isFixedDateRule = false;
		}

		/// <summary>Defines a time change that uses a fixed-date rule (that is, a time change that occurs on a specific day of a specific month).</summary>
		/// <param name="timeOfDay">The time at which the time change occurs. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.TimeOfDay" /> property.</param>
		/// <param name="month">The month in which the time change occurs. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.Month" /> property.</param>
		/// <param name="day">The day of the month on which the time change occurs. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.Day" /> property.</param>
		/// <returns>Data about the time change.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="timeOfDay" /> parameter has a non-default date component.  
		///  -or-  
		///  The <paramref name="timeOfDay" /> parameter's <see cref="P:System.DateTime.Kind" /> property is not <see cref="F:System.DateTimeKind.Unspecified" />.  
		///  -or-  
		///  The <paramref name="timeOfDay" /> parameter does not represent a whole number of milliseconds.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="month" /> parameter is less than 1 or greater than 12.  
		///  -or-  
		///  The <paramref name="day" /> parameter is less than 1 or greater than 31.</exception>
		public static TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day)
		{
			return default(TransitionTime);
		}

		/// <summary>Defines a time change that uses a floating-date rule (that is, a time change that occurs on a specific day of a specific week of a specific month).</summary>
		/// <param name="timeOfDay">The time at which the time change occurs. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.TimeOfDay" /> property.</param>
		/// <param name="month">The month in which the time change occurs. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.Month" /> property.</param>
		/// <param name="week">The week of the month in which the time change occurs. Its value can range from 1 to 5, with 5 representing the last week of the month. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.Week" /> property.</param>
		/// <param name="dayOfWeek">The day of the week on which the time change occurs. This parameter corresponds to the <see cref="P:System.TimeZoneInfo.TransitionTime.DayOfWeek" /> property.</param>
		/// <returns>Data about the time change.</returns>
		/// <exception cref="T:System.ArgumentException">The <paramref name="timeOfDay" /> parameter has a non-default date component.  
		///  -or-  
		///  The <paramref name="timeOfDay" /> parameter does not represent a whole number of milliseconds.  
		///  -or-  
		///  The <paramref name="timeOfDay" /> parameter's <see cref="P:System.DateTime.Kind" /> property is not <see cref="F:System.DateTimeKind.Unspecified" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="month" /> is less than 1 or greater than 12.  
		/// -or-  
		/// <paramref name="week" /> is less than 1 or greater than 5.  
		/// -or-  
		/// The <paramref name="dayOfWeek" /> parameter is not a member of the <see cref="T:System.DayOfWeek" /> enumeration.</exception>
		public static TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek)
		{
			return default(TransitionTime);
		}

		private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek)
		{
		}

		/// <summary>Runs when the deserialization of an object has been completed.</summary>
		/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data that is required to serialize this object.</summary>
		/// <param name="info">The object to populate with data.</param>
		/// <param name="context">The destination for this serialization (see <see cref="T:System.Runtime.Serialization.StreamingContext" />).</param>
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private TransitionTime(SerializationInfo info, StreamingContext context)
		{
			_timeOfDay = default(DateTime);
			_month = 0;
			_week = 0;
			_day = 0;
			_dayOfWeek = default(DayOfWeek);
			_isFixedDateRule = false;
		}
	}

	private static Lazy<bool> lazyHaveRegistry;

	private readonly string _id;

	private readonly string _displayName;

	private readonly string _standardDisplayName;

	private readonly string _daylightDisplayName;

	private readonly TimeSpan _baseUtcOffset;

	private readonly bool _supportsDaylightSavingTime;

	private readonly AdjustmentRule[] _adjustmentRules;

	private static readonly TimeZoneInfo s_utcTimeZone;

	private static CachedData s_cachedData;

	private static readonly DateTime s_maxDateOnly;

	private static readonly DateTime s_minDateOnly;

	private static readonly TimeSpan MaxOffset;

	private static readonly TimeSpan MinOffset;

	private static bool HaveRegistry => false;

	/// <summary>Gets the time zone identifier.</summary>
	/// <returns>The time zone identifier.</returns>
	public string Id => null;

	/// <summary>Gets the general display name that represents the time zone.</summary>
	/// <returns>The time zone's general display name.</returns>
	public string DisplayName => null;

	/// <summary>Gets the display name for the time zone's standard time.</summary>
	/// <returns>The display name of the time zone's standard time.</returns>
	public string StandardName => null;

	/// <summary>Gets the display name for the current time zone's daylight saving time.</summary>
	/// <returns>The display name for the time zone's daylight saving time.</returns>
	public string DaylightName => null;

	/// <summary>Gets the time difference between the current time zone's standard time and Coordinated Universal Time (UTC).</summary>
	/// <returns>An object that indicates the time difference between the current time zone's standard time and Coordinated Universal Time (UTC).</returns>
	public TimeSpan BaseUtcOffset => default(TimeSpan);

	/// <summary>Gets a value indicating whether the time zone has any daylight saving time rules.</summary>
	/// <returns>
	///   <see langword="true" /> if the time zone supports daylight saving time; otherwise, <see langword="false" />.</returns>
	public bool SupportsDaylightSavingTime => false;

	/// <summary>Gets a <see cref="T:System.TimeZoneInfo" /> object that represents the local time zone.</summary>
	/// <returns>An object that represents the local time zone.</returns>
	public static TimeZoneInfo Local => null;

	/// <summary>Gets a <see cref="T:System.TimeZoneInfo" /> object that represents the Coordinated Universal Time (UTC) zone.</summary>
	/// <returns>An object that represents the Coordinated Universal Time (UTC) zone.</returns>
	public static TimeZoneInfo Utc => null;

	/// <summary>Retrieves an array of <see cref="T:System.TimeZoneInfo.AdjustmentRule" /> objects that apply to the current <see cref="T:System.TimeZoneInfo" /> object.</summary>
	/// <returns>An array of objects for this time zone.</returns>
	/// <exception cref="T:System.OutOfMemoryException">The system does not have enough memory to make an in-memory copy of the adjustment rules.</exception>
	public AdjustmentRule[] GetAdjustmentRules()
	{
		return null;
	}

	private static void PopulateAllSystemTimeZones(CachedData cachedData)
	{
	}

	private static void PopulateAllSystemTimeZonesFromRegistry(CachedData cachedData)
	{
	}

	private TimeZoneInfo(in Interop.Kernel32.TIME_ZONE_INFORMATION zone, bool dstDisabled)
	{
	}

	private static bool CheckDaylightSavingTimeNotSupported(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone)
	{
		return false;
	}

	private static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
	{
		return null;
	}

	private static string FindIdFromTimeZoneInformation(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, out bool dstDisabled)
	{
		dstDisabled = default(bool);
		return null;
	}

	private static TimeZoneInfo GetLocalTimeZone(CachedData cachedData)
	{
		return null;
	}

	private static TimeZoneInfo GetLocalTimeZoneFromWin32Data(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled)
	{
		return null;
	}

	/// <summary>Instantiates a new <see cref="T:System.TimeZoneInfo" /> object based on its identifier.</summary>
	/// <param name="id">The time zone identifier, which corresponds to the <see cref="P:System.TimeZoneInfo.Id" /> property.</param>
	/// <returns>An object whose identifier is the value of the <paramref name="id" /> parameter.</returns>
	/// <exception cref="T:System.OutOfMemoryException">The system does not have enough memory to hold information about the time zone.</exception>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="id" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.TimeZoneNotFoundException">The time zone identifier specified by <paramref name="id" /> was not found. This means that a time zone identifier whose name matches <paramref name="id" /> does not exist, or that the identifier exists but does not contain any time zone data.</exception>
	/// <exception cref="T:System.Security.SecurityException">The process does not have the permissions required to read from the registry key that contains the time zone information.</exception>
	/// <exception cref="T:System.InvalidTimeZoneException">The time zone identifier was found, but the registry data is corrupted.</exception>
	public static TimeZoneInfo FindSystemTimeZoneById(string id)
	{
		return null;
	}

	internal static TimeSpan GetDateTimeNowUtcOffsetFromUtc(DateTime time, out bool isAmbiguousLocalDst)
	{
		isAmbiguousLocalDst = default(bool);
		return default(TimeSpan);
	}

	private static bool TransitionTimeFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, out TransitionTime transitionTime, bool readStartDate)
	{
		transitionTime = default(TransitionTime);
		return false;
	}

	private static bool TryCreateAdjustmentRules(string id, in Interop.Kernel32.REG_TZI_FORMAT defaultTimeZoneInformation, out AdjustmentRule[] rules, out Exception e, int defaultBaseUtcOffset)
	{
		rules = null;
		e = null;
		return false;
	}

	private static bool TryGetTimeZoneEntryFromRegistry(RegistryKey key, string name, out Interop.Kernel32.REG_TZI_FORMAT dtzi)
	{
		dtzi = default(Interop.Kernel32.REG_TZI_FORMAT);
		return false;
	}

	private static bool TryCompareStandardDate(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, in Interop.Kernel32.REG_TZI_FORMAT registryTimeZoneInfo)
	{
		return false;
	}

	private static bool TryCompareTimeZoneInformationToRegistry(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled)
	{
		dstDisabled = default(bool);
		return false;
	}

	private static string TryGetLocalizedNameByMuiNativeResource(string resource)
	{
		return null;
	}

	private static string TryGetLocalizedNameByNativeResource(string filePath, int resource)
	{
		return null;
	}

	private static void GetLocalizedNamesByRegistryKey(RegistryKey key, out string displayName, out string standardName, out string daylightName)
	{
		displayName = null;
		standardName = null;
		daylightName = null;
	}

	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out TimeZoneInfo value, out Exception e)
	{
		value = null;
		e = null;
		return default(TimeZoneInfoResult);
	}

	private static TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out TimeZoneInfo value, out Exception e)
	{
		value = null;
		e = null;
		return default(TimeZoneInfoResult);
	}

	[PreserveSig]
	internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation);

	[PreserveSig]
	internal static extern uint GetDynamicTimeZoneInformation(out DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation);

	[PreserveSig]
	internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear);

	[PreserveSig]
	internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out Interop.Kernel32.TIME_ZONE_INFORMATION ptzi);

	internal static AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, DateTime startDate, DateTime endDate, int defaultBaseUtcOffset)
	{
		return null;
	}

	private static bool TransitionTimeFromTimeZoneInformation(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out TransitionTime transitionTime, bool readStartDate)
	{
		transitionTime = default(TransitionTime);
		return false;
	}

	internal static TimeZoneInfo TryCreateTimeZone(DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation)
	{
		return null;
	}

	internal static TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback()
	{
		return null;
	}

	internal static TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id)
	{
		return null;
	}

	private static void GetSystemTimeZonesWinRTFallback(CachedData cachedData)
	{
	}

	private AdjustmentRule GetPreviousAdjustmentRule(AdjustmentRule rule, int? ruleIndex)
	{
		return null;
	}

	/// <summary>Calculates the offset or difference between the time in this time zone and Coordinated Universal Time (UTC) for a particular date and time.</summary>
	/// <param name="dateTime">The date and time to determine the offset for.</param>
	/// <returns>An object that indicates the time difference between the two time zones.</returns>
	public TimeSpan GetUtcOffset(DateTime dateTime)
	{
		return default(TimeSpan);
	}

	internal static TimeSpan GetLocalUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return default(TimeSpan);
	}

	internal TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return default(TimeSpan);
	}

	private TimeSpan GetUtcOffset(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		return default(TimeSpan);
	}

	internal bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return false;
	}

	private bool IsDaylightSavingTime(DateTime dateTime, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		return false;
	}

	internal static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
	{
		return default(DateTime);
	}

	private static DateTime ConvertTime(DateTime dateTime, TimeZoneInfo sourceTimeZone, TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, CachedData cachedData)
	{
		return default(DateTime);
	}

	internal static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfoOptions flags)
	{
		return default(DateTime);
	}

	/// <summary>Converts the time in a specified time zone to Coordinated Universal Time (UTC).</summary>
	/// <param name="dateTime">The date and time to convert.</param>
	/// <param name="sourceTimeZone">The time zone of <paramref name="dateTime" />.</param>
	/// <returns>The Coordinated Universal Time (UTC) that corresponds to the <paramref name="dateTime" /> parameter. The <see cref="T:System.DateTime" /> object's <see cref="P:System.DateTime.Kind" /> property is always set to <see cref="F:System.DateTimeKind.Utc" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="dateTime" />.<see langword="Kind" /> is <see cref="F:System.DateTimeKind.Utc" /> and <paramref name="sourceTimeZone" /> does not equal <see cref="P:System.TimeZoneInfo.Utc" />.  
	/// -or-  
	/// <paramref name="dateTime" />.<see langword="Kind" /> is <see cref="F:System.DateTimeKind.Local" /> and <paramref name="sourceTimeZone" /> does not equal <see cref="P:System.TimeZoneInfo.Local" />.  
	/// -or-  
	/// <paramref name="sourceTimeZone" /><see langword=".IsInvalidDateTime(" /><paramref name="dateTime" /><see langword=")" /> returns <see langword="true" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sourceTimeZone" /> is <see langword="null" />.</exception>
	public static DateTime ConvertTimeToUtc(DateTime dateTime, TimeZoneInfo sourceTimeZone)
	{
		return default(DateTime);
	}

	/// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo" /> object and another <see cref="T:System.TimeZoneInfo" /> object are equal.</summary>
	/// <param name="other">A second object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the two <see cref="T:System.TimeZoneInfo" /> objects are equal; otherwise, <see langword="false" />.</returns>
	public bool Equals(TimeZoneInfo other)
	{
		return false;
	}

	/// <summary>Determines whether the current <see cref="T:System.TimeZoneInfo" /> object and another object are equal.</summary>
	/// <param name="obj">A second object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.TimeZoneInfo" /> object that is equal to the current instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for hashing algorithms and data structures such as hash tables.</summary>
	/// <returns>A 32-bit signed integer that serves as the hash code for this <see cref="T:System.TimeZoneInfo" /> object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns a sorted collection of all the time zones about which information is available on the local system.</summary>
	/// <returns>A read-only collection of <see cref="T:System.TimeZoneInfo" /> objects.</returns>
	/// <exception cref="T:System.OutOfMemoryException">There is insufficient memory to store all time zone information.</exception>
	/// <exception cref="T:System.Security.SecurityException">The user does not have permission to read from the registry keys that contain time zone information.</exception>
	public static ReadOnlyCollection<TimeZoneInfo> GetSystemTimeZones()
	{
		return null;
	}

	/// <summary>Indicates whether the current object and another <see cref="T:System.TimeZoneInfo" /> object have the same adjustment rules.</summary>
	/// <param name="other">A second object to compare with the current <see cref="T:System.TimeZoneInfo" /> object.</param>
	/// <returns>
	///   <see langword="true" /> if the two time zones have identical adjustment rules and an identical base offset; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="other" /> parameter is <see langword="null" />.</exception>
	public bool HasSameRules(TimeZoneInfo other)
	{
		return false;
	}

	/// <summary>Returns the current <see cref="T:System.TimeZoneInfo" /> object's display name.</summary>
	/// <returns>The value of the <see cref="P:System.TimeZoneInfo.DisplayName" /> property of the current <see cref="T:System.TimeZoneInfo" /> object.</returns>
	public override string ToString()
	{
		return null;
	}

	private TimeZoneInfo(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
	{
	}

	/// <summary>Creates a custom time zone with a specified identifier, an offset from Coordinated Universal Time (UTC), a display name, and a standard time display name.</summary>
	/// <param name="id">The time zone's identifier.</param>
	/// <param name="baseUtcOffset">An object that represents the time difference between this time zone and Coordinated Universal Time (UTC).</param>
	/// <param name="displayName">The display name of the new time zone.</param>
	/// <param name="standardDisplayName">The name of the new time zone's standard time.</param>
	/// <returns>The new time zone.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="id" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The <paramref name="id" /> parameter is an empty string ("").  
	///  -or-  
	///  The <paramref name="baseUtcOffset" /> parameter does not represent a whole number of minutes.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="baseUtcOffset" /> parameter is greater than 14 hours or less than -14 hours.</exception>
	public static TimeZoneInfo CreateCustomTimeZone(string id, TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
	{
		return null;
	}

	/// <summary>Runs when the deserialization of an object has been completed.</summary>
	/// <param name="sender">The object that initiated the callback. The functionality for this parameter is not currently implemented.</param>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.TimeZoneInfo" /> object contains invalid or corrupted data.</exception>
	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data needed to serialize the current <see cref="T:System.TimeZoneInfo" /> object.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with data.</param>
	/// <param name="context">The destination for this serialization (see <see cref="T:System.Runtime.Serialization.StreamingContext" />).</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.</exception>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private TimeZoneInfo(SerializationInfo info, StreamingContext context)
	{
	}

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, out int? ruleIndex)
	{
		ruleIndex = null;
		return null;
	}

	private AdjustmentRule GetAdjustmentRuleForTime(DateTime dateTime, bool dateTimeisUtc, out int? ruleIndex)
	{
		ruleIndex = null;
		return null;
	}

	private int CompareAdjustmentRuleToDateTime(AdjustmentRule rule, AdjustmentRule previousRule, DateTime dateTime, DateTime dateOnly, bool dateTimeisUtc)
	{
		return 0;
	}

	private DateTime ConvertToUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
	{
		return default(DateTime);
	}

	private DateTime ConvertFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta)
	{
		return default(DateTime);
	}

	private DateTime ConvertToFromUtc(DateTime dateTime, TimeSpan daylightDelta, TimeSpan baseUtcOffsetDelta, bool convertToUtc)
	{
		return default(DateTime);
	}

	private static DateTime ConvertUtcToTimeZone(long ticks, TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst)
	{
		isAmbiguousLocalDst = default(bool);
		return default(DateTime);
	}

	private DaylightTimeStruct GetDaylightTime(int year, AdjustmentRule rule, int? ruleIndex)
	{
		return default(DaylightTimeStruct);
	}

	private static bool GetIsDaylightSavings(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags)
	{
		return false;
	}

	private TimeSpan GetDaylightSavingsStartOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule, int? ruleIndex)
	{
		return default(TimeSpan);
	}

	private TimeSpan GetDaylightSavingsEndOffsetFromUtc(TimeSpan baseUtcOffset, AdjustmentRule rule)
	{
		return default(TimeSpan);
	}

	private static bool GetIsDaylightSavingsFromUtc(DateTime time, int year, TimeSpan utc, AdjustmentRule rule, int? ruleIndex, out bool isAmbiguousLocalDst, TimeZoneInfo zone)
	{
		isAmbiguousLocalDst = default(bool);
		return false;
	}

	private static bool CheckIsDst(DateTime startTime, DateTime time, DateTime endTime, bool ignoreYearAdjustment, AdjustmentRule rule)
	{
		return false;
	}

	private static bool GetIsAmbiguousTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		return false;
	}

	private static bool GetIsInvalidTime(DateTime time, AdjustmentRule rule, DaylightTimeStruct daylightTime)
	{
		return false;
	}

	private static TimeSpan GetUtcOffset(DateTime time, TimeZoneInfo zone, TimeZoneInfoOptions flags)
	{
		return default(TimeSpan);
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone)
	{
		return default(TimeSpan);
	}

	private static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings)
	{
		isDaylightSavings = default(bool);
		return default(TimeSpan);
	}

	internal static TimeSpan GetUtcOffsetFromUtc(DateTime time, TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
	{
		isDaylightSavings = default(bool);
		isAmbiguousLocalDst = default(bool);
		return default(TimeSpan);
	}

	internal static DateTime TransitionTimeToDateTime(int year, TransitionTime transitionTime)
	{
		return default(DateTime);
	}

	private static TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData, bool alwaysFallbackToLocalMachine = false)
	{
		value = null;
		e = null;
		return default(TimeZoneInfoResult);
	}

	private static TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out TimeZoneInfo value, out Exception e, CachedData cachedData)
	{
		value = null;
		e = null;
		return default(TimeZoneInfoResult);
	}

	private static void ValidateTimeZoneInfo(string id, TimeSpan baseUtcOffset, AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst)
	{
		adjustmentRulesSupportDst = default(bool);
	}

	internal static bool UtcOffsetOutOfRange(TimeSpan offset)
	{
		return false;
	}

	private static TimeSpan GetUtcOffset(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule)
	{
		return default(TimeSpan);
	}

	private static bool IsValidAdjustmentRuleOffest(TimeSpan baseUtcOffset, AdjustmentRule adjustmentRule)
	{
		return false;
	}

	internal TimeZoneInfo()
	{
	}
}
