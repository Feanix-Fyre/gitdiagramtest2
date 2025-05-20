using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class DescendantQuery : DescendantBaseQuery
{
	private XPathNodeIterator _nodeIterator;

	internal DescendantQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis)
		: base(null, null, null, default(XPathNodeType), matchSelf: false, abbrAxis: false)
	{
	}

	public DescendantQuery(DescendantQuery other)
		: base(null, null, null, default(XPathNodeType), matchSelf: false, abbrAxis: false)
	{
	}

	public override void Reset()
	{
	}

	public override XPathNavigator Advance()
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
