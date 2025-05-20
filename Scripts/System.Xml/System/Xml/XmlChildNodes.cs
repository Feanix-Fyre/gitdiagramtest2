using System.Collections;

namespace System.Xml;

internal class XmlChildNodes : XmlNodeList
{
	private XmlNode container;

	public override int Count => 0;

	public XmlChildNodes(XmlNode container)
	{
	}

	public override XmlNode Item(int i)
	{
		return null;
	}

	public override IEnumerator GetEnumerator()
	{
		return null;
	}
}
