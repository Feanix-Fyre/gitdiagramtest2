using System.Collections;

namespace System.Xml;

internal class XmlNodeListEnumerator : IEnumerator
{
	private XPathNodeList list;

	private int index;

	private bool valid;

	public object Current => null;

	public XmlNodeListEnumerator(XPathNodeList list)
	{
	}

	public void Reset()
	{
	}

	public bool MoveNext()
	{
		return false;
	}
}
