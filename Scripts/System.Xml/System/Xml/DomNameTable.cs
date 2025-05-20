using System.Xml.Schema;

namespace System.Xml;

internal class DomNameTable
{
	private XmlName[] entries;

	private int count;

	private int mask;

	private XmlDocument ownerDocument;

	private XmlNameTable nameTable;

	public DomNameTable(XmlDocument document)
	{
	}

	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
	{
		return null;
	}

	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo)
	{
		return null;
	}

	private void Grow()
	{
	}
}
