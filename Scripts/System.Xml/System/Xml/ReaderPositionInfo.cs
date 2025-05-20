namespace System.Xml;

internal class ReaderPositionInfo : PositionInfo
{
	private IXmlLineInfo lineInfo;

	public override int LineNumber => 0;

	public override int LinePosition => 0;

	public ReaderPositionInfo(IXmlLineInfo lineInfo)
	{
	}

	public override bool HasLineInfo()
	{
		return false;
	}
}
