namespace System.Xml;

internal struct LineInfo
{
	internal int lineNo;

	internal int linePos;

	public LineInfo(int lineNo, int linePos)
	{
		this.lineNo = 0;
		this.linePos = 0;
	}

	public void Set(int lineNo, int linePos)
	{
	}
}
