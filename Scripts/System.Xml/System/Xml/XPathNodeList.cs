using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;

namespace System.Xml;

internal class XPathNodeList : XmlNodeList
{
	private List<XmlNode> list;

	private XPathNodeIterator nodeIterator;

	private bool done;

	private static readonly object[] nullparams;

	public override int Count => 0;

	public XPathNodeList(XPathNodeIterator nodeIterator)
	{
	}

	private XmlNode GetNode(XPathNavigator n)
	{
		return null;
	}

	internal int ReadUntil(int index)
	{
		return 0;
	}

	public override XmlNode Item(int index)
	{
		return null;
	}

	public override IEnumerator GetEnumerator()
	{
		return null;
	}
}
