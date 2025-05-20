namespace System.Xml;

internal class ReadContentAsBinaryHelper
{
	private enum State
	{
		None = 0,
		InReadContent = 1,
		InReadElementContent = 2
	}

	private XmlReader reader;

	private State state;

	private int valueOffset;

	private bool isEnd;

	internal void Finish()
	{
	}

	internal void Reset()
	{
	}

	private bool MoveToNextContentNode(bool moveIfOnContentNode)
	{
		return false;
	}
}
