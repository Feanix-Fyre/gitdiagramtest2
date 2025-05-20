using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class AttributeQuery : BaseAxisQuery
{
	private bool _onAttribute;

	public AttributeQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type)
		: base((Query)null)
	{
	}

	private AttributeQuery(AttributeQuery other)
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
