namespace System.Text;

internal class EncoderNLS : Encoder
{
	internal char _charLeftOver;

	private Encoding _encoding;

	private bool _mustFlush;

	internal bool _throwOnOverflow;

	internal int _charsUsed;

	public Encoding Encoding => null;

	public bool MustFlush => false;

	internal virtual bool HasState => false;

	internal EncoderNLS(Encoding encoding)
	{
	}

	public override void Reset()
	{
	}

	public override int GetByteCount(char[] chars, int index, int count, bool flush)
	{
		return 0;
	}

	public unsafe override int GetByteCount(char* chars, int count, bool flush)
	{
		return 0;
	}

	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
	{
		return 0;
	}

	public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
	{
		return 0;
	}

	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
	{
		charsUsed = default(int);
		bytesUsed = default(int);
		completed = default(bool);
	}

	public unsafe override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
	{
		charsUsed = default(int);
		bytesUsed = default(int);
		completed = default(bool);
	}

	internal void ClearMustFlush()
	{
	}
}
