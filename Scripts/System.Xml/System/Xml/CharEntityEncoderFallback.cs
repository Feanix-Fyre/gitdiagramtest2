using System.Text;

namespace System.Xml;

internal class CharEntityEncoderFallback : EncoderFallback
{
	private CharEntityEncoderFallbackBuffer fallbackBuffer;

	private int[] textContentMarks;

	private int endMarkPos;

	private int curMarkPos;

	private int startOffset;

	public override int MaxCharCount => 0;

	internal int StartOffset
	{
		set
		{
		}
	}

	internal CharEntityEncoderFallback()
	{
	}

	public override EncoderFallbackBuffer CreateFallbackBuffer()
	{
		return null;
	}

	internal void Reset(int[] textContentMarks, int endMarkPos)
	{
	}

	internal bool CanReplaceAt(int index)
	{
		return false;
	}
}
