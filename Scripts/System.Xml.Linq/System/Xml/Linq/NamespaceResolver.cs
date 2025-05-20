namespace System.Xml.Linq;

internal struct NamespaceResolver
{
	private class NamespaceDeclaration
	{
		public string prefix;

		public XNamespace ns;

		public int scope;

		public NamespaceDeclaration prev;
	}

	private int _scope;

	private NamespaceDeclaration _declaration;

	private NamespaceDeclaration _rover;

	public void PushScope()
	{
	}

	public void PopScope()
	{
	}

	public void Add(string prefix, XNamespace ns)
	{
	}

	public void AddFirst(string prefix, XNamespace ns)
	{
	}

	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
	{
		return null;
	}
}
