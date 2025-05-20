namespace MS.Internal.Xml.Cache;

internal sealed class XPathNodePageInfo
{
	private int _pageNum;

	private int _nodeCount;

	private XPathNode[] _pageNext;

	public int PageNumber => 0;

	public int NodeCount => 0;

	public XPathNode[] NextPage => null;
}
