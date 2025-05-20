using System.Xml.XPath;

namespace System.Xml;

internal abstract class DocumentXPathNodeIterator_ElemDescendants : XPathNodeIterator
{
	private DocumentXPathNavigator nav;

	private int level;

	private int position;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	internal DocumentXPathNodeIterator_ElemDescendants(DocumentXPathNavigator nav)
	{
	}

	internal DocumentXPathNodeIterator_ElemDescendants(DocumentXPathNodeIterator_ElemDescendants other)
	{
	}

	protected abstract bool Match(XmlNode node);

	protected void SetPosition(int pos)
	{
	}

	public override bool MoveNext()
	{
		return false;
	}
}
