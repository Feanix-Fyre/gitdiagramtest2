using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class NamespaceQuery : BaseAxisQuery
{
	private bool _onNamespace;

	public NamespaceQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type)
		: base((Query)null)
	{
	}

	private NamespaceQuery(NamespaceQuery other)
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

	public override bool matches(XPathNavigator e)
	{
		return false;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
