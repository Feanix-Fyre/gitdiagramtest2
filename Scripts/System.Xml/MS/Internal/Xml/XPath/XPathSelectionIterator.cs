using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class XPathSelectionIterator : ResetableIterator
{
	private XPathNavigator _nav;

	private Query _query;

	private int _position;

	public override int Count => 0;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	internal XPathSelectionIterator(XPathNavigator nav, Query query)
	{
	}

	protected XPathSelectionIterator(XPathSelectionIterator it)
	{
	}

	public override void Reset()
	{
	}

	public override bool MoveNext()
	{
		return false;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
