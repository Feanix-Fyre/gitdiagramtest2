namespace System.Xml.Schema;

internal class SchemaNamespaceManager : XmlNamespaceManager
{
	private XmlSchemaObject node;

	public SchemaNamespaceManager(XmlSchemaObject node)
	{
	}

	public override string LookupNamespace(string prefix)
	{
		return null;
	}

	public override string LookupPrefix(string ns)
	{
		return null;
	}
}
