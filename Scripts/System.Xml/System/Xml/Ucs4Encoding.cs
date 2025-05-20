using System.Text;

namespace System.Xml;

internal class Ucs4Encoding : Encoding
{
	internal Ucs4Decoder ucs4Decoder;

	public override string WebName => null;

	public override int CodePage => 0;

	internal static Encoding UCS4_Littleendian => null;

	internal static Encoding UCS4_Bigendian => null;

	internal static Encoding UCS4_2143 => null;

	internal static Encoding UCS4_3412 => null;

	public override Decoder GetDecoder()
	{
		return null;
	}

	public override int GetByteCount(char[] chars, int index, int count)
	{
		return 0;
	}

	public override byte[] GetBytes(string s)
	{
		return null;
	}

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
	{
		return 0;
	}

	public override int GetMaxByteCount(int charCount)
	{
		return 0;
	}

	public override int GetCharCount(byte[] bytes, int index, int count)
	{
		return 0;
	}

	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
	{
		return 0;
	}

	public override int GetMaxCharCount(int byteCount)
	{
		return 0;
	}

	public override Encoder GetEncoder()
	{
		return null;
	}
}
