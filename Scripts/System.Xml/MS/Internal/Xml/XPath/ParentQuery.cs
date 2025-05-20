using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class ParentQuery : CacheAxisQuery
{
	public ParentQuery(Query qyInput, string Name, string Prefix, XPathNodeType Type)
		: base(null, null, null, default(XPathNodeType))
	{
	}

	private ParentQuery(ParentQuery other)
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
