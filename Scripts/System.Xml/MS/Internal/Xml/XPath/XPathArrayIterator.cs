using System.Collections;
using System.Diagnostics;
using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

[DebuggerDisplay("Position={CurrentPosition}, Current={debuggerDisplayProxy, nq}")]
internal class XPathArrayIterator : ResetableIterator
{
	protected IList list;

	protected int index;

	public override XPathNavigator Current => null;

	public override int CurrentPosition => 0;

	public override int Count => 0;

	public XPathArrayIterator(XPathArrayIterator it)
	{
	}

	public XPathArrayIterator(XPathNodeIterator nodeIterator)
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

	public override IEnumerator GetEnumerator()
	{
		return null;
	}
}
