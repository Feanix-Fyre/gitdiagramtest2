using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class IDQuery : CacheOutputQuery
{
	public IDQuery(Query arg)
		: base((Query)null)
	{
	}

	private IDQuery(IDQuery other)
		: base((Query)null)
	{
	}

	public override object Evaluate(XPathNodeIterator context)
	{
		return null;
	}

	private void ProcessIds(XPathNavigator contextNode, string val)
	{
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
