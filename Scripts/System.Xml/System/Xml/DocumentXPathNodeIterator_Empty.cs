using System.Xml.XPath;

namespace System.Xml;

internal sealed class DocumentXPathNodeIterator_Empty : XPathNodeIterator
{
	private XPathNavigator nav;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	public override int Count => 0;

	internal DocumentXPathNodeIterator_Empty(DocumentXPathNavigator nav)
	{
	}

	internal DocumentXPathNodeIterator_Empty(DocumentXPathNodeIterator_Empty other)
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
