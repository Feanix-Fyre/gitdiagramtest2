using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class ContextQuery : Query
{
	protected XPathNavigator contextNode;

	public override XPathNavigator Current => null;

	public override XPathResultType StaticType => default(XPathResultType);

	public override int CurrentPosition => 0;

	public override int Count => 0;

	public override QueryProps Properties => default(QueryProps);

	public ContextQuery()
	{
	}

	protected ContextQuery(ContextQuery other)
	{
	}

	public override void Reset()
	{
	}

	public override object Evaluate(XPathNodeIterator context)
	{
		return null;
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
