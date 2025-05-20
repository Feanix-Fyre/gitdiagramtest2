namespace System.Xml;

internal class BinHexDecoder : IncrementalReadDecoder
{
	private byte[] buffer;

	private int curIndex;

	private int endIndex;

	private bool hasHalfByteCached;

	private byte cachedHalfByte;

	internal override bool IsFull => false;

	internal override int Decode(char[] chars, int startPos, int len)
	{
		return 0;
	}

	public static byte[] Decode(char[] chars, bool allowOddChars)
	{
		return null;
	}

	private unsafe static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded)
	{
		charsDecoded = default(int);
		bytesDecoded = default(int);
	}
}
