using System.Xml.XPath;

namespace MS.Internal.Xml.Cache;

internal abstract class XPathDocumentBaseIterator : XPathNodeIterator
{
	protected XPathDocumentNavigator ctxt;

	protected int pos;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	protected XPathDocumentBaseIterator(XPathDocumentNavigator ctxt)
	{
	}

	protected XPathDocumentBaseIterator(XPathDocumentBaseIterator iter)
	{
	}
}
