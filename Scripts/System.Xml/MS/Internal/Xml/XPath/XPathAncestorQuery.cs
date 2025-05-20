using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class XPathAncestorQuery : CacheAxisQuery
{
	private bool _matchSelf;

	public override int CurrentPosition => 0;

	public override QueryProps Properties => default(QueryProps);

	public XPathAncestorQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest, bool matchSelf)
		: base(null, null, null, default(XPathNodeType))
	{
	}

	private XPathAncestorQuery(XPathAncestorQuery other)
		: base(null, null, null, default(XPathNodeType))
	{
	}

	public override object Evaluate(XPathNodeIterator context)
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
