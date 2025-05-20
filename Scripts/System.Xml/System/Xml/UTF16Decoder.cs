using System.Text;

namespace System.Xml;

internal class UTF16Decoder : Decoder
{
	private bool bigEndian;

	private int lastByte;

	public UTF16Decoder(bool bigEndian)
	{
	}

	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return 0;
	}

	public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
	{
		return 0;
	}

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		return 0;
	}

	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
	{
		bytesUsed = default(int);
		charsUsed = default(int);
		completed = default(bool);
	}
}
