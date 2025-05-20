using System.Xml.XPath;

namespace System.Xml;

internal class DocumentXPathNodeIterator_ElemChildren : DocumentXPathNodeIterator_ElemDescendants
{
	protected string localNameAtom;

	protected string nsAtom;

	internal DocumentXPathNodeIterator_ElemChildren(DocumentXPathNavigator nav, string localNameAtom, string nsAtom)
		: base((DocumentXPathNavigator)null)
	{
	}

	internal DocumentXPathNodeIterator_ElemChildren(DocumentXPathNodeIterator_ElemChildren other)
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
