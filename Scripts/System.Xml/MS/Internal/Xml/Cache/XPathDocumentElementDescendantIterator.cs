using System.Xml.XPath;

namespace MS.Internal.Xml.Cache;

internal class XPathDocumentElementDescendantIterator : XPathDocumentBaseIterator
{
	private XPathDocumentNavigator _end;

	private string _localName;

	private string _namespaceUri;

	private bool _matchSelf;

	public XPathDocumentElementDescendantIterator(XPathDocumentNavigator root, string name, string namespaceURI, bool matchSelf)
		: base((XPathDocumentNavigator)null)
	{
	}

	public XPathDocumentElementDescendantIterator(XPathDocumentElementDescendantIterator iter)
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
