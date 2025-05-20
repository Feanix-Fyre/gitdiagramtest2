using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class ReversePositionQuery : ForwardPositionQuery
{
	public override int CurrentPosition => 0;

	public override QueryProps Properties => default(QueryProps);

	public ReversePositionQuery(Query input)
		: base((Query)null)
	{
	}

	private ReversePositionQuery(ReversePositionQuery other)
		: base((Query)null)
	{
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
