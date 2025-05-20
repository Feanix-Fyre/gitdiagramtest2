using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class XPathEmptyIterator : ResetableIterator
{
	public static XPathEmptyIterator Instance;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	public override int Count => 0;

	private XPathEmptyIterator()
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

	public override void Reset()
	{
	}
}
