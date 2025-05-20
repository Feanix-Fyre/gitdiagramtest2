using System.Xml.XPath;

namespace System.Xml;

internal class DocumentXPathNodeIterator_AllElemChildren : DocumentXPathNodeIterator_ElemDescendants
{
	internal DocumentXPathNodeIterator_AllElemChildren(DocumentXPathNavigator nav)
		: base((DocumentXPathNavigator)null)
	{
	}

	internal DocumentXPathNodeIterator_AllElemChildren(DocumentXPathNodeIterator_AllElemChildren other)
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
