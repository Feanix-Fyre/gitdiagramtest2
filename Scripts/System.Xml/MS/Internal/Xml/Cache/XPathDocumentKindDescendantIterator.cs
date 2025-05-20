using System.Xml.XPath;

namespace MS.Internal.Xml.Cache;

internal class XPathDocumentKindDescendantIterator : XPathDocumentBaseIterator
{
	private XPathDocumentNavigator _end;

	private XPathNodeType _typ;

	private bool _matchSelf;

	public XPathDocumentKindDescendantIterator(XPathDocumentNavigator root, XPathNodeType typ, bool matchSelf)
		: base((XPathDocumentNavigator)null)
	{
	}

	public XPathDocumentKindDescendantIterator(XPathDocumentKindDescendantIterator iter)
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
