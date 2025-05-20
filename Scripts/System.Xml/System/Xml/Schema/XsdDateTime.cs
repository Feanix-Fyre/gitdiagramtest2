using System.Text;

namespace System.Xml.Schema;

internal struct XsdDateTime
{
	private enum DateTimeTypeCode
	{
		DateTime = 0,
		Time = 1,
		Date = 2,
		GYearMonth = 3,
		GYear = 4,
		GMonthDay = 5,
		GDay = 6,
		GMonth = 7,
		XdrDateTime = 8
	}

	private enum XsdDateTimeKind
	{
		Unspecified = 0,
		Zulu = 1,
		LocalWestOfZulu = 2,
		LocalEastOfZulu = 3
	}

	private struct Parser
	{
		public DateTimeTypeCode typeCode;

		public int year;

		public int month;

		public int day;

		public int hour;

		public int minute;

		public int second;

		public int fraction;

		public XsdDateTimeKind kind;

		public int zoneHour;

		public int zoneMinute;

		private string text;

		private int length;

		private static int[] Power10;

		public bool Parse(string text, XsdDateTimeFlags kinds)
		{
			return false;
		}

		private bool ParseDate(int start)
		{
			return false;
		}

		private bool ParseTimeAndZoneAndWhitespace(int start)
		{
			return false;
		}

		private bool ParseTimeAndWhitespace(int start)
		{
			return false;
		}

		private bool ParseTime(ref int start)
		{
			return false;
		}

		private bool ParseZoneAndWhitespace(int start)
		{
			return false;
		}

		private bool Parse4Dig(int start, ref int num)
		{
			return false;
		}

		private bool Parse2Dig(int start, ref int num)
		{
			return false;
		}

		private bool ParseChar(int start, char ch)
		{
			return false;
		}

		private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right)
		{
			return false;
		}
	}

	private DateTime dt;

	private uint extra;

	private static readonly int Lzyyyy;

	private static readonly int Lzyyyy_;

	private static readonly int Lzyyyy_MM;

	private static readonly int Lzyyyy_MM_;

	private static readonly int Lzyyyy_MM_dd;

	private static readonly int Lzyyyy_MM_ddT;

	private static readonly int LzHH;

	private static readonly int LzHH_;

	private static readonly int LzHH_mm;

	private static readonly int LzHH_mm_;

	private static readonly int LzHH_mm_ss;

	private static readonly int Lz_;

	private static readonly int Lz_zz;

	private static readonly int Lz_zz_;

	private static readonly int Lz_zz_zz;

	private static readonly int Lz__;

	private static readonly int Lz__mm;

	private static readonly int Lz__mm_;

	private static readonly int Lz__mm__;

	private static readonly int Lz__mm_dd;

	private static readonly int Lz___;

	private static readonly int Lz___dd;

	private static readonly XmlTypeCode[] typeCodes;

	private DateTimeTypeCode InternalTypeCode => default(DateTimeTypeCode);

	private XsdDateTimeKind InternalKind => default(XsdDateTimeKind);

	public int Year => 0;

	public int Month => 0;

	public int Day => 0;

	public int Hour => 0;

	public int Minute => 0;

	public int Second => 0;

	public int Fraction => 0;

	public int ZoneHour => 0;

	public int ZoneMinute => 0;

	public XsdDateTime(string text, XsdDateTimeFlags kinds)
	{
		dt = default(DateTime);
		extra = 0u;
	}

	private XsdDateTime(Parser parser)
	{
		dt = default(DateTime);
		extra = 0u;
	}

	private void InitiateXsdDateTime(Parser parser)
	{
	}

	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result)
	{
		result = default(XsdDateTime);
		return false;
	}

	public XsdDateTime(DateTime dateTime, XsdDateTimeFlags kinds)
	{
		dt = default(DateTime);
		extra = 0u;
	}

	public XsdDateTime(DateTimeOffset dateTimeOffset)
	{
		dt = default(DateTime);
		extra = 0u;
	}

	public XsdDateTime(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds)
	{
		dt = default(DateTime);
		extra = 0u;
	}

	public static implicit operator DateTime(XsdDateTime xdt)
	{
		return default(DateTime);
	}

	public static implicit operator DateTimeOffset(XsdDateTime xdt)
	{
		return default(DateTimeOffset);
	}

	public override string ToString()
	{
		return null;
	}

	private void PrintDate(StringBuilder sb)
	{
	}

	private void PrintTime(StringBuilder sb)
	{
	}

	private void PrintZone(StringBuilder sb)
	{
	}

	private void IntToCharArray(char[] text, int start, int value, int digits)
	{
	}

	private void ShortToCharArray(char[] text, int start, int value)
	{
	}
}
