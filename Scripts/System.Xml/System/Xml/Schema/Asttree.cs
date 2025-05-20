using System.Collections;
using MS.Internal.Xml.XPath;

namespace System.Xml.Schema;

internal class Asttree
{
	private ArrayList _fAxisArray;

	private string _xpathexpr;

	private bool _isField;

	private XmlNamespaceManager _nsmgr;

	internal ArrayList SubtreeArray => null;

	public Asttree(string xPath, bool isField, XmlNamespaceManager nsmgr)
	{
	}

	private static bool IsNameTest(Axis ast)
	{
		return false;
	}

	internal static bool IsAttribute(Axis ast)
	{
		return false;
	}

	private static bool IsDescendantOrSelf(Axis ast)
	{
		return false;
	}

	internal static bool IsSelf(Axis ast)
	{
		return false;
	}

	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr)
	{
	}

	private void SetURN(Axis axis, XmlNamespaceManager nsmgr)
	{
	}
}
