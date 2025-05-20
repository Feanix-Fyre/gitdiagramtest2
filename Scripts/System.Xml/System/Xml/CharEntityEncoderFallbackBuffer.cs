using System.Text;

namespace System.Xml;

internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
{
	private CharEntityEncoderFallback parent;

	private string charEntity;

	private int charEntityIndex;

	public override int Remaining => 0;

	internal CharEntityEncoderFallbackBuffer(CharEntityEncoderFallback parent)
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

	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate)
	{
		return 0;
	}
}
