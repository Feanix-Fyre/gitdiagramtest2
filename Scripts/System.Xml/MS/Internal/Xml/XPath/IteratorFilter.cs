using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class IteratorFilter : XPathNodeIterator
{
	private XPathNodeIterator _innerIterator;

	private string _name;

	private int _position;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	internal IteratorFilter(XPathNodeIterator innerIterator, string name)
	{
	}

	private IteratorFilter(IteratorFilter it)
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
