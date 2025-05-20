using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class ChildrenQuery : BaseAxisQuery
{
	private XPathNodeIterator _iterator;

	public ChildrenQuery(Query qyInput, string name, string prefix, XPathNodeType type)
		: base((Query)null)
	{
	}

	protected ChildrenQuery(ChildrenQuery other)
		: base((Query)null)
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
