using System.Text;

namespace System.Xml;

internal abstract class BinXmlDateTime
{
	internal static int[] KatmaiTimeScaleMultiplicator;

	private static readonly double SQLTicksPerMillisecond;

	public static readonly int SQLTicksPerSecond;

	public static readonly int SQLTicksPerMinute;

	public static readonly int SQLTicksPerHour;

	private static readonly int SQLTicksPerDay;

	private static void Write2Dig(StringBuilder sb, int val)
	{
	}

	private static void Write4DigNeg(StringBuilder sb, int val)
	{
	}

	private static void Write3Dec(StringBuilder sb, int val)
	{
	}

	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day)
	{
	}

	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms)
	{
	}

	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction)
	{
	}

	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone)
	{
	}

	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min)
	{
	}

	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms)
	{
		yr = default(int);
		mnth = default(int);
		day = default(int);
		hr = default(int);
		min = default(int);
		sec = default(int);
		ms = default(int);
	}

	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min)
	{
		yr = default(int);
		mnth = default(int);
		day = default(int);
		negTimeZone = default(bool);
		hr = default(int);
		min = default(int);
	}

	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms)
	{
		hr = default(int);
		min = default(int);
		sec = default(int);
		ms = default(int);
	}

	public static string XsdDateTimeToString(long val)
	{
		return null;
	}

	public static string XsdDateToString(long val)
	{
		return null;
	}

	public static string XsdTimeToString(long val)
	{
		return null;
	}

	public static string SqlDateTimeToString(int dateticks, uint timeticks)
	{
		return null;
	}

	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks)
	{
		return default(DateTime);
	}

	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks)
	{
		return null;
	}

	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks)
	{
		return default(DateTime);
	}

	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset)
	{
		return default(DateTime);
	}

	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset)
	{
		return default(DateTime);
	}

	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset)
	{
		return default(DateTime);
	}

	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset)
	{
		return default(DateTimeOffset);
	}

	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset)
	{
		return default(DateTimeOffset);
	}

	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset)
	{
		return default(DateTimeOffset);
	}

	public static string XsdKatmaiDateToString(byte[] data, int offset)
	{
		return null;
	}

	public static string XsdKatmaiDateTimeToString(byte[] data, int offset)
	{
		return null;
	}

	public static string XsdKatmaiTimeToString(byte[] data, int offset)
	{
		return null;
	}

	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset)
	{
		return null;
	}

	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset)
	{
		return null;
	}

	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset)
	{
		return null;
	}

	private static long GetKatmaiDateTicks(byte[] data, ref int pos)
	{
		return 0L;
	}

	private static long GetKatmaiTimeTicks(byte[] data, ref int pos)
	{
		return 0L;
	}

	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos)
	{
		return 0L;
	}

	private static int GetFractions(DateTime dt)
	{
		return 0;
	}

	private static int GetFractions(DateTimeOffset dt)
	{
		return 0;
	}
}
