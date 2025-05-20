namespace Unity.Collections;

[BurstCompatible]
public static class UTF8ArrayUnsafeUtility
{
	internal struct Comparison
	{
		public bool terminates;

		public int result;

		public Comparison(Unicode.Rune runeA, ConversionError errorA, Unicode.Rune runeB, ConversionError errorB)
		{
			terminates = false;
			result = 0;
		}
	}

	public unsafe static CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, char* src, int srcLength)
	{
		destLength = default(int);
		return default(CopyError);
	}

	public unsafe static CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength)
	{
		destLength = default(ushort);
		return default(CopyError);
	}

	public unsafe static CopyError Copy(byte* dest, out int destLength, int destUTF8MaxLengthInBytes, byte* src, int srcLength)
	{
		destLength = default(int);
		return default(CopyError);
	}

	public unsafe static CopyError Copy(byte* dest, out ushort destLength, ushort destUTF8MaxLengthInBytes, byte* src, ushort srcLength)
	{
		destLength = default(ushort);
		return default(CopyError);
	}

	public unsafe static CopyError Copy(char* dest, out int destLength, int destUCS2MaxLengthInChars, byte* src, int srcLength)
	{
		destLength = default(int);
		return default(CopyError);
	}

	public unsafe static CopyError Copy(char* dest, out ushort destLength, ushort destUCS2MaxLengthInChars, byte* src, ushort srcLength)
	{
		destLength = default(ushort);
		return default(CopyError);
	}

	public unsafe static FormatError AppendUTF8Bytes(byte* dest, ref int destLength, int destCapacity, byte* src, int srcLength)
	{
		return default(FormatError);
	}

	public unsafe static CopyError Append(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, byte* src, ushort srcLength)
	{
		return default(CopyError);
	}

	public unsafe static CopyError Append(byte* dest, ref ushort destLength, ushort destUTF8MaxLengthInBytes, char* src, int srcLength)
	{
		return default(CopyError);
	}

	public unsafe static CopyError Append(char* dest, ref ushort destLength, ushort destUCS2MaxLengthInChars, byte* src, ushort srcLength)
	{
		return default(CopyError);
	}

	public unsafe static int StrCmp(byte* utf8BufferA, int utf8LengthInBytesA, byte* utf8BufferB, int utf8LengthInBytesB)
	{
		return 0;
	}

	public unsafe static int StrCmp(char* utf16BufferA, int utf16LengthInCharsA, char* utf16BufferB, int utf16LengthInCharsB)
	{
		return 0;
	}

	public unsafe static bool EqualsUTF8Bytes(byte* aBytes, int aLength, byte* bBytes, int bLength)
	{
		return false;
	}

	public unsafe static int StrCmp(byte* utf8Buffer, int utf8LengthInBytes, char* utf16Buffer, int utf16LengthInChars)
	{
		return 0;
	}

	public unsafe static int StrCmp(char* utf16Buffer, int utf16LengthInChars, byte* utf8Buffer, int utf8LengthInBytes)
	{
		return 0;
	}
}
