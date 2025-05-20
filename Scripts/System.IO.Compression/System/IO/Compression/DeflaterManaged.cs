namespace System.IO.Compression;

internal sealed class DeflaterManaged
{
	private enum DeflaterState
	{
		NotStarted = 0,
		SlowDownForIncompressible1 = 1,
		SlowDownForIncompressible2 = 2,
		StartingSmallData = 3,
		CompressThenCheck = 4,
		CheckingForIncompressible = 5,
		HandlingSmallData = 6
	}

	private readonly FastEncoder _deflateEncoder;

	private readonly CopyEncoder _copyEncoder;

	private readonly DeflateInput _input;

	private readonly OutputBuffer _output;

	private DeflaterState _processingState;

	private DeflateInput _inputFromHistory;

	internal bool NeedsInput()
	{
		return false;
	}

	internal void SetInput(byte[] inputBuffer, int startIndex, int count)
	{
	}

	internal int GetDeflateOutput(byte[] outputBuffer)
	{
		return 0;
	}

	internal bool Finish(byte[] outputBuffer, out int bytesRead)
	{
		bytesRead = default(int);
		return false;
	}

	private bool UseCompressed(double ratio)
	{
		return false;
	}

	private void FlushInputWindows()
	{
	}

	private void WriteFinal()
	{
	}

	public void Dispose()
	{
	}
}
