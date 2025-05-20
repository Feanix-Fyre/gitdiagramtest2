namespace System.Xml;

internal class XmlLoader
{
	private XmlDocument doc;

	private XmlReader reader;

	private bool preserveWhitespace;

	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace)
	{
	}

	private void LoadDocSequence(XmlDocument parentDoc)
	{
	}

	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader)
	{
		return null;
	}

	private XmlNode LoadNode(bool skipOverWhitespace)
	{
		return null;
	}

	private XmlAttribute LoadAttributeNode()
	{
		return null;
	}

	private XmlAttribute LoadDefaultAttribute()
	{
		return null;
	}

	private void LoadAttributeValue(XmlNode parent, bool direct)
	{
	}

	private XmlEntityReference LoadEntityReferenceNode(bool direct)
	{
		return null;
	}

	private XmlDeclaration LoadDeclarationNode()
	{
		return null;
	}

	private XmlDocumentType LoadDocumentTypeNode()
	{
		return null;
	}

	private XmlNode LoadNodeDirect()
	{
		return null;
	}

	private XmlAttribute LoadAttributeNodeDirect()
	{
		return null;
	}

	internal void ParseDocumentType(XmlDocumentType dtNode)
	{
	}

	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver)
	{
	}

	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode)
	{
	}

	private XmlParserContext GetContext(XmlNode node)
	{
		return null;
	}

	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt)
	{
		return null;
	}

	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext)
	{
	}

	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext)
	{
	}

	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs)
	{
	}

	private string EntitizeName(string name)
	{
		return null;
	}

	internal void ExpandEntity(XmlEntity ent)
	{
	}

	internal void ExpandEntityReference(XmlEntityReference eref)
	{
	}

	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc)
	{
		return null;
	}

	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone)
	{
		version = null;
		encoding = null;
		standalone = null;
	}

	internal static Exception UnexpectedNodeType(XmlNodeType nodetype)
	{
		return null;
	}
}
