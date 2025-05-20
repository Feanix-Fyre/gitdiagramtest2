namespace System.Xml;

internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
{
	internal override bool IsFull => false;

	internal override int Decode(char[] chars, int startPos, int len)
	{
		return 0;
	}
}
