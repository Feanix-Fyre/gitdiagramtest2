using System.Text;

namespace System.Xml;

internal abstract class Ucs4Decoder : Decoder
{
	internal byte[] lastBytes;

	internal int lastBytesCount;

	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return 0;
	}

	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

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

	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex)
	{
	}
}
