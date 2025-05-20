using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal abstract class DescendantBaseQuery : BaseAxisQuery
{
	protected bool matchSelf;

	protected bool abbrAxis;

	public DescendantBaseQuery(Query qyParent, string Name, string Prefix, XPathNodeType Type, bool matchSelf, bool abbrAxis)
		: base((Query)null)
	{
	}

	public DescendantBaseQuery(DescendantBaseQuery other)
		: base((Query)null)
	{
	}
}
