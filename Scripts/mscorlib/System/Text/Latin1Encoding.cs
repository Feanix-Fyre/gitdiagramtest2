using System.Runtime.Serialization;

namespace System.Text;

[Serializable]
internal class Latin1Encoding : EncodingNLS, ISerializable
{
	internal static readonly Latin1Encoding s_default;

	private static readonly char[] arrayCharBestFit;

	public Latin1Encoding()
		: base(0)
	{
	}

	internal Latin1Encoding(SerializationInfo info, StreamingContext context)
		: base(0)
	{
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal unsafe override int GetByteCount(char* chars, int charCount, EncoderNLS encoder)
	{
		return 0;
	}

	internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
	{
		return 0;
	}

	internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS decoder)
	{
		return 0;
	}

	internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS decoder)
	{
		return 0;
	}

	public override int GetMaxByteCount(int charCount)
	{
		return 0;
	}

	public override int GetMaxCharCount(int byteCount)
	{
		return 0;
	}

	internal override char[] GetBestFitUnicodeToBytesData()
	{
		return null;
	}
}
