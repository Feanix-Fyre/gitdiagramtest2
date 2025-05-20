namespace System.Xml.Linq;

internal struct ElementWriter
{
	private XmlWriter _writer;

	private NamespaceResolver _resolver;

	public ElementWriter(XmlWriter writer)
	{
		_writer = null;
		_resolver = default(NamespaceResolver);
	}

	public void WriteElement(XElement e)
	{
	}

	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace)
	{
		return null;
	}

	private void PushAncestors(XElement e)
	{
	}

	private void PushElement(XElement e)
	{
	}

	private void WriteEndElement()
	{
	}

	private void WriteFullEndElement()
	{
	}

	private void WriteStartElement(XElement e)
	{
	}
}
