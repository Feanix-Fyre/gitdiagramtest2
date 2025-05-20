using System.Collections;
using System.Globalization;

namespace System;

[Serializable]
[Obsolete("System.CurrentSystemTimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo.Local instead.")]
internal class CurrentSystemTimeZone : TimeZone
{
	private long m_ticksOffset;

	private string m_standardName;

	private string m_daylightName;

	private readonly Hashtable m_CachedDaylightChanges;

	internal CurrentSystemTimeZone()
	{
	}

	public override DaylightTime GetDaylightChanges(int year)
	{
		return null;
	}

	private static DaylightTime CreateDaylightChanges(int year)
	{
		return null;
	}

	public override TimeSpan GetUtcOffset(DateTime time)
	{
		return default(TimeSpan);
	}

	private DaylightTime GetCachedDaylightChanges(int year)
	{
		return null;
	}
}
