using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class FollowingQuery : BaseAxisQuery
{
	private XPathNavigator _input;

	private XPathNodeIterator _iterator;

	public FollowingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest)
		: base((Query)null)
	{
	}

	private FollowingQuery(FollowingQuery other)
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
