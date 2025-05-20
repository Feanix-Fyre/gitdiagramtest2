using System.Xml.XPath;

namespace System.Xml;

internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName : DocumentXPathNodeIterator_ElemDescendants
{
	private string nsAtom;

	internal DocumentXPathNodeIterator_ElemChildren_NoLocalName(DocumentXPathNavigator nav, string nsAtom)
		: base((DocumentXPathNavigator)null)
	{
	}

	internal DocumentXPathNodeIterator_ElemChildren_NoLocalName(DocumentXPathNodeIterator_ElemChildren_NoLocalName other)
		: base((DocumentXPathNavigator)null)
	{
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}

	protected override bool Match(XmlNode node)
	{
		return false;
	}
}
