using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class EmptyQuery : Query
{
	public override int CurrentPosition => 0;

	public override int Count => 0;

	public override QueryProps Properties => default(QueryProps);

	public override XPathResultType StaticType => default(XPathResultType);

	public override XPathNavigator Current => null;

	public override XPathNavigator Advance()
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}

	public override object Evaluate(XPathNodeIterator context)
	{
		return null;
	}

	public override void Reset()
	{
	}
}
