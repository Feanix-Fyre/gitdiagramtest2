using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class PrecedingQuery : BaseAxisQuery
{
	private XPathNodeIterator _workIterator;

	private ClonableStack<XPathNavigator> _ancestorStk;

	public override QueryProps Properties => default(QueryProps);

	public PrecedingQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest)
		: base((Query)null)
	{
	}

	private PrecedingQuery(PrecedingQuery other)
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
