using System.Xml.XPath;

namespace MS.Internal.Xml.Cache;

internal class XPathDocumentKindChildIterator : XPathDocumentBaseIterator
{
	private XPathNodeType _typ;

	public XPathDocumentKindChildIterator(XPathDocumentNavigator parent, XPathNodeType typ)
		: base((XPathDocumentNavigator)null)
	{
	}

	public XPathDocumentKindChildIterator(XPathDocumentKindChildIterator iter)
		: base((XPathDocumentNavigator)null)
	{
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}

	public override bool MoveNext()
	{
		return false;
	}
}
