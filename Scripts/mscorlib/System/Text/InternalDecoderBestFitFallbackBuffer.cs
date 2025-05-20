namespace System.Text;

internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer
{
	private char _cBestFit;

	private int _iCount;

	private int _iSize;

	private InternalDecoderBestFitFallback _oFallback;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject => null;

	public override int Remaining => 0;

	public InternalDecoderBestFitFallbackBuffer(InternalDecoderBestFitFallback fallback)
	{
	}

	public override bool Fallback(byte[] bytesUnknown, int index)
	{
		return false;
	}

	public override char GetNextChar()
	{
		return '\0';
	}

	public override void Reset()
	{
	}

	internal unsafe override int InternalFallback(byte[] bytes, byte* pBytes)
	{
		return 0;
	}

	private char TryBestFit(byte[] bytesCheck)
	{
		return '\0';
	}
}
