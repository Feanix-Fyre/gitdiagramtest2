namespace System.IO.Compression;

internal sealed class OutputWindow
{
	private readonly byte[] _window;

	private int _end;

	private int _bytesUsed;

	public int FreeBytes => 0;

	public int AvailableBytes => 0;

	public void Write(byte b)
	{
	}

	public void WriteLengthDistance(int length, int distance)
	{
	}

	public int CopyFrom(InputBuffer input, int length)
	{
		return 0;
	}

	public int CopyTo(byte[] output, int offset, int length)
	{
		return 0;
	}
}
