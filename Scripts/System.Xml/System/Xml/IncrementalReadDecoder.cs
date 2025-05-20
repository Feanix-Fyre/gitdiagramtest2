namespace System.Xml;

internal abstract class IncrementalReadDecoder
{
	internal abstract bool IsFull { get; }

	internal abstract int Decode(char[] chars, int startPos, int len);
}
