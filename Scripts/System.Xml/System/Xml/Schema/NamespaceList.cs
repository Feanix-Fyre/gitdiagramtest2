using System.Collections;

namespace System.Xml.Schema;

internal class NamespaceList
{
	public enum ListType
	{
		Any = 0,
		Other = 1,
		Set = 2
	}

	private ListType type;

	private Hashtable set;

	private string targetNamespace;

	public ListType Type => default(ListType);

	public string Excluded => null;

	public ICollection Enumerate => null;

	public NamespaceList()
	{
	}

	public NamespaceList(string namespaces, string targetNamespace)
	{
	}

	public NamespaceList Clone()
	{
		return null;
	}

	public virtual bool Allows(string ns)
	{
		return false;
	}

	public bool Allows(XmlQualifiedName qname)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public static bool IsSubset(NamespaceList sub, NamespaceList super)
	{
		return false;
	}

	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat)
	{
		return null;
	}

	private NamespaceList CompareSetToOther(NamespaceList other)
	{
		return null;
	}

	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat)
	{
		return null;
	}

	private void RemoveNamespace(string tns)
	{
	}
}
