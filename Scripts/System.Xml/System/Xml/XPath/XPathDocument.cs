using System.Collections.Generic;
using MS.Internal.Xml.Cache;

namespace System.Xml.XPath;

/// <summary>Provides a fast, read-only, in-memory representation of an XML document by using the XPath data model.</summary>
public class XPathDocument
{
	private XPathNode[] pageText;

	private XPathNode[] pageRoot;

	private XPathNode[] pageXmlNmsp;

	private int idxText;

	private int idxRoot;

	private int idxXmlNmsp;

	private XmlNameTable nameTable;

	private bool hasLineInfo;

	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp;

	private Dictionary<string, XPathNodeRef> idValueMap;

	internal XmlNameTable NameTable => null;

	internal bool HasLineInfo => false;

	internal int GetCollapsedTextNode(out XPathNode[] pageText)
	{
		pageText = null;
		return 0;
	}

	internal int GetRootNode(out XPathNode[] pageRoot)
	{
		pageRoot = null;
		return 0;
	}

	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp)
	{
		pageXmlNmsp = null;
		return 0;
	}

	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
	{
		pageNmsp = null;
		return 0;
	}

	internal int LookupIdElement(string id, out XPathNode[] pageElem)
	{
		pageElem = null;
		return 0;
	}
}
