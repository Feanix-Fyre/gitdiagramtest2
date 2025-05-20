using System.Xml.XPath;

namespace MS.Internal.Xml.Cache;

internal abstract class XPathNodeHelper
{
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
	{
		pageNmsp = null;
		return 0;
	}

	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
	{
		pageNmsp = null;
		return 0;
	}

	public static bool GetFirstAttribute(ref XPathNode[] pageNode, ref int idxNode)
	{
		return false;
	}

	public static bool GetNextAttribute(ref XPathNode[] pageNode, ref int idxNode)
	{
		return false;
	}

	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode)
	{
		return false;
	}

	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode)
	{
		return false;
	}

	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode)
	{
		return false;
	}

	public static int GetLocation(XPathNode[] pageNode, int idxNode)
	{
		return 0;
	}

	public static bool GetElementChild(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName)
	{
		return false;
	}

	public static bool GetElementSibling(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName)
	{
		return false;
	}

	public static bool GetContentChild(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ)
	{
		return false;
	}

	public static bool GetContentSibling(ref XPathNode[] pageNode, ref int idxNode, XPathNodeType typ)
	{
		return false;
	}

	public static bool GetAttribute(ref XPathNode[] pageNode, ref int idxNode, string localName, string namespaceName)
	{
		return false;
	}

	public static bool GetElementFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, string localName, string namespaceName)
	{
		return false;
	}

	public static bool GetContentFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd, XPathNodeType typ)
	{
		return false;
	}

	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd)
	{
		return false;
	}

	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode)
	{
		return false;
	}

	private static void GetChild(ref XPathNode[] pageNode, ref int idxNode)
	{
	}
}
