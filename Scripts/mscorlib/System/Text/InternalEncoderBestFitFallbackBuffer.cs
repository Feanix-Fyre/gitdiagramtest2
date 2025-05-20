namespace System.Text;

internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer
{
	private char _cBestFit;

	private InternalEncoderBestFitFallback _oFallback;

	private int _iCount;

	private int _iSize;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject => null;

	public override int Remaining => 0;

	public InternalEncoderBestFitFallbackBuffer(InternalEncoderBestFitFallback fallback)
	{
	}

	public override bool Fallback(char charUnknown, int index)
	{
		return false;
	}

	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
	{
		return false;
	}

	public override char GetNextChar()
	{
		return '\0';
	}

	public override bool MovePrevious()
	{
		return false;
	}

	public override void Reset()
	{
	}

	private char TryBestFit(char cUnknown)
	{
		return '\0';
	}
}
