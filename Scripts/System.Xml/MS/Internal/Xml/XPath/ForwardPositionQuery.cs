using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class ForwardPositionQuery : CacheOutputQuery
{
	public ForwardPositionQuery(Query input)
		: base((Query)null)
	{
	}

	protected ForwardPositionQuery(ForwardPositionQuery other)
		: base((Query)null)
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
