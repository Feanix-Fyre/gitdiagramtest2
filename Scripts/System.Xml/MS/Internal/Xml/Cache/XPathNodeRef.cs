namespace MS.Internal.Xml.Cache;

internal struct XPathNodeRef
{
	private XPathNode[] _page;

	private int _idx;

	public XPathNode[] Page => null;

	public int Index => 0;

	public XPathNodeRef(XPathNode[] page, int idx)
	{
		_page = null;
		_idx = 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
