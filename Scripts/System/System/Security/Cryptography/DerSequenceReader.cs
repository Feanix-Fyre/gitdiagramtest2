using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Security.Cryptography;

internal class DerSequenceReader
{
	internal enum DerTag : byte
	{
		Boolean = 1,
		Integer = 2,
		BitString = 3,
		OctetString = 4,
		Null = 5,
		ObjectIdentifier = 6,
		UTF8String = 12,
		Sequence = 16,
		Set = 17,
		PrintableString = 19,
		T61String = 20,
		IA5String = 22,
		UTCTime = 23,
		GeneralizedTime = 24,
		BMPString = 30
	}

	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo;

	private static Encoding s_utf8EncodingWithExceptionFallback;

	private static Encoding s_latin1Encoding;

	private readonly byte[] _data;

	private readonly int _end;

	private int _position;

	[CompilerGenerated]
	private int _003CContentLength_003Ek__BackingField;

	private int ContentLength
	{
		[CompilerGenerated]
		set
		{
			_003CContentLength_003Ek__BackingField = value;
		}
	}

	internal bool HasData => false;

	internal DerSequenceReader(byte[] data)
	{
	}

	internal DerSequenceReader(byte[] data, int offset, int length)
	{
	}

	private DerSequenceReader(DerTag tagToEat, byte[] data, int offset, int length)
	{
	}

	internal byte PeekTag()
	{
		return 0;
	}

	internal void SkipValue()
	{
	}

	internal byte[] ReadNextEncodedValue()
	{
		return null;
	}

	internal bool ReadBoolean()
	{
		return false;
	}

	internal int ReadInteger()
	{
		return 0;
	}

	internal byte[] ReadIntegerBytes()
	{
		return null;
	}

	internal byte[] ReadBitString()
	{
		return null;
	}

	internal byte[] ReadOctetString()
	{
		return null;
	}

	internal string ReadOidAsString()
	{
		return null;
	}

	internal string ReadUtf8String()
	{
		return null;
	}

	private DerSequenceReader ReadCollectionWithTag(DerTag expected)
	{
		return null;
	}

	internal DerSequenceReader ReadSequence()
	{
		return null;
	}

	internal DerSequenceReader ReadSet()
	{
		return null;
	}

	internal string ReadPrintableString()
	{
		return null;
	}

	internal string ReadIA5String()
	{
		return null;
	}

	internal string ReadT61String()
	{
		return null;
	}

	internal DateTime ReadX509Date()
	{
		return default(DateTime);
	}

	internal DateTime ReadUtcTime()
	{
		return default(DateTime);
	}

	internal DateTime ReadGeneralizedTime()
	{
		return default(DateTime);
	}

	internal string ReadBMPString()
	{
		return null;
	}

	private static string TrimTrailingNulls(string value)
	{
		return null;
	}

	private DateTime ReadTime(DerTag timeTag, string formatString)
	{
		return default(DateTime);
	}

	private byte[] ReadContentAsBytes()
	{
		return null;
	}

	private void EatTag(DerTag expected)
	{
	}

	private static void CheckTag(DerTag expected, byte[] data, int position)
	{
	}

	private int EatLength()
	{
		return 0;
	}

	private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed)
	{
		bytesConsumed = default(int);
		return 0;
	}
}
