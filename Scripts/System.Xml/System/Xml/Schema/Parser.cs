namespace System.Xml.Schema;

internal sealed class Parser
{
	private SchemaType schemaType;

	private XmlNameTable nameTable;

	private SchemaNames schemaNames;

	private ValidationEventHandler eventHandler;

	private XmlNamespaceManager namespaceManager;

	private XmlReader reader;

	private PositionInfo positionInfo;

	private bool isProcessNamespaces;

	private int schemaXmlDepth;

	private int markupDepth;

	private SchemaBuilder builder;

	private XmlSchema schema;

	private SchemaInfo xdrSchema;

	private XmlResolver xmlResolver;

	private XmlDocument dummyDocument;

	private bool processMarkup;

	private XmlNode parentNode;

	private XmlNamespaceManager annotationNSManager;

	private string xmlns;

	private XmlCharType xmlCharType;

	public XmlSchema XmlSchema => null;

	internal XmlResolver XmlResolver
	{
		set
		{
		}
	}

	public SchemaInfo XdrSchema => null;

	public Parser(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler)
	{
	}

	public SchemaType Parse(XmlReader reader, string targetNamespace)
	{
		return default(SchemaType);
	}

	public void StartParsing(XmlReader reader, string targetNamespace)
	{
	}

	private bool CheckSchemaRoot(SchemaType rootType, out string code)
	{
		code = null;
		return false;
	}

	public SchemaType FinishParsing()
	{
		return default(SchemaType);
	}

	public bool ParseReaderNode()
	{
		return false;
	}

	private void ProcessAppInfoDocMarkup(bool root)
	{
	}

	private XmlElement LoadElementNode(bool root)
	{
		return null;
	}

	private XmlAttribute CreateXmlNsAttribute(string prefix, string value)
	{
		return null;
	}

	private XmlAttribute LoadAttributeNode()
	{
		return null;
	}

	private XmlEntityReference LoadEntityReferenceInAttribute()
	{
		return null;
	}
}
