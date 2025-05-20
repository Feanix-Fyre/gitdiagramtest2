using System.Collections;

namespace System.Xml.Schema;

internal class SymbolsDictionary
{
	private int last;

	private Hashtable names;

	private Hashtable wildcards;

	private ArrayList particles;

	private object particleLast;

	private bool isUpaEnforced;

	public int Count => 0;

	public bool IsUpaEnforced
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int this[XmlQualifiedName name] => 0;

	public int AddName(XmlQualifiedName name, object particle)
	{
		return 0;
	}

	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal)
	{
	}

	private void AddWildcard(string wildcard, object particle)
	{
	}

	public ICollection GetNamespaceListSymbols(NamespaceList list)
	{
		return null;
	}

	public bool Exists(XmlQualifiedName name)
	{
		return false;
	}

	public object GetParticle(int symbol)
	{
		return null;
	}

	public string NameOf(int symbol)
	{
		return null;
	}
}
