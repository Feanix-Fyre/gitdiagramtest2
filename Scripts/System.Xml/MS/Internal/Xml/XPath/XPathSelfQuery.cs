using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class XPathSelfQuery : BaseAxisQuery
{
	public XPathSelfQuery(Query qyInput, string Name, string Prefix, XPathNodeType Type)
		: base((Query)null)
	{
	}

	private XPathSelfQuery(XPathSelfQuery other)
		: base((Query)null)
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
