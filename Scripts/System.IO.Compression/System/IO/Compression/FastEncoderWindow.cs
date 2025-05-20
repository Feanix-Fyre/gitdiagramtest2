namespace System.IO.Compression;

internal sealed class FastEncoderWindow
{
	private byte[] _window;

	private int _bufPos;

	private int _bufEnd;

	private ushort[] _prev;

	private ushort[] _lookup;

	public int BytesAvailable => 0;

	public DeflateInput UnprocessedInput => null;

	public int FreeWindowSpace => 0;

	public void FlushWindow()
	{
	}

	private void ResetWindow()
	{
	}

	public void CopyBytes(byte[] inputBuffer, int startIndex, int count)
	{
	}

	public void MoveWindows()
	{
	}

	private uint HashValue(uint hash, byte b)
	{
		return 0u;
	}

	private uint InsertString(ref uint hash)
	{
		return 0u;
	}

	private void InsertStrings(ref uint hash, int matchLen)
	{
	}

	internal bool GetNextSymbolOrMatch(Match match)
	{
		return false;
	}

	private int FindMatch(int search, out int matchPos, int searchDepth, int niceLength)
	{
		matchPos = default(int);
		return 0;
	}
}
