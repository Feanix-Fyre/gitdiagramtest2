using System.Xml.XPath;

namespace MS.Internal.Xml.Cache;

internal class XPathDocumentElementChildIterator : XPathDocumentBaseIterator
{
	private string _localName;

	private string _namespaceUri;

	public XPathDocumentElementChildIterator(XPathDocumentNavigator parent, string name, string namespaceURI)
		: base((XPathDocumentNavigator)null)
	{
	}

	public XPathDocumentElementChildIterator(XPathDocumentElementChildIterator iter)
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
