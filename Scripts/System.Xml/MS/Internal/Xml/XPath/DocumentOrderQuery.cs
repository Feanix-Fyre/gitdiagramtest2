using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class DocumentOrderQuery : CacheOutputQuery
{
	public DocumentOrderQuery(Query qyParent)
		: base((Query)null)
	{
	}

	private DocumentOrderQuery(DocumentOrderQuery other)
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
