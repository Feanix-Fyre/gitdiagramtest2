namespace System.Xml;

internal abstract class Base64Encoder
{
	private byte[] leftOverBytes;

	private int leftOverBytesCount;

	private char[] charsLine;

	internal Base64Encoder()
	{
	}

	internal abstract void WriteChars(char[] chars, int index, int count);

	internal void Encode(byte[] buffer, int index, int count)
	{
	}

	internal void Flush()
	{
	}
}
