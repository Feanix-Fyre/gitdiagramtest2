using System.Collections.Generic;
using System.Xml.Schema;

namespace System.Xml;

internal class XmlNodeReaderNavigator
{
	internal struct VirtualAttribute
	{
		internal string name;

		internal string value;

		internal VirtualAttribute(string name, string value)
		{
			this.name = null;
			this.value = null;
		}
	}

	private XmlNode curNode;

	private XmlNode elemNode;

	private XmlNode logNode;

	private int attrIndex;

	private int logAttrIndex;

	private XmlNameTable nameTable;

	private XmlDocument doc;

	private int nAttrInd;

	private int nDeclarationAttrCount;

	private int nDocTypeAttrCount;

	private int nLogLevel;

	private int nLogAttrInd;

	private bool bLogOnAttrVal;

	private bool bCreatedOnAttribute;

	internal VirtualAttribute[] decNodeAttributes;

	internal VirtualAttribute[] docTypeNodeAttributes;

	private bool bOnAttrVal;

	public XmlNodeType NodeType => default(XmlNodeType);

	public string NamespaceURI => null;

	public string Name => null;

	public string LocalName => null;

	internal bool CreatedOnAttribute => false;

	public string Prefix => null;

	public string Value => null;

	public string BaseURI => null;

	public XmlSpace XmlSpace => default(XmlSpace);

	public string XmlLang => null;

	public bool IsEmptyElement => false;

	public bool IsDefault => false;

	public IXmlSchemaInfo SchemaInfo => null;

	public XmlNameTable NameTable => null;

	public int AttributeCount => 0;

	private bool IsOnDeclOrDocType => false;

	public XmlDocument Document => null;

	public XmlNodeReaderNavigator(XmlNode node)
	{
	}

	private bool IsLocalNameEmpty(XmlNodeType nt)
	{
		return false;
	}

	private void CheckIndexCondition(int attributeIndex)
	{
	}

	private void InitDecAttr()
	{
	}

	public string GetDeclarationAttr(XmlDeclaration decl, string name)
	{
		return null;
	}

	public string GetDeclarationAttr(int i)
	{
		return null;
	}

	public int GetDecAttrInd(string name)
	{
		return 0;
	}

	private void InitDocTypeAttr()
	{
	}

	public string GetDocumentTypeAttr(XmlDocumentType docType, string name)
	{
		return null;
	}

	public string GetDocumentTypeAttr(int i)
	{
		return null;
	}

	public int GetDocTypeAttrInd(string name)
	{
		return 0;
	}

	private string GetAttributeFromElement(XmlElement elem, string name)
	{
		return null;
	}

	public string GetAttribute(string name)
	{
		return null;
	}

	private string GetAttributeFromElement(XmlElement elem, string name, string ns)
	{
		return null;
	}

	public string GetAttribute(string name, string ns)
	{
		return null;
	}

	public string GetAttribute(int attributeIndex)
	{
		return null;
	}

	public void LogMove(int level)
	{
	}

	public void RollBackMove(ref int level)
	{
	}

	public void ResetToAttribute(ref int level)
	{
	}

	public void ResetMove(ref int level, ref XmlNodeType nt)
	{
	}

	public bool MoveToAttribute(string name)
	{
		return false;
	}

	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns)
	{
		return false;
	}

	public bool MoveToAttribute(string name, string namespaceURI)
	{
		return false;
	}

	public void MoveToAttribute(int attributeIndex)
	{
	}

	public bool MoveToNextAttribute(ref int level)
	{
		return false;
	}

	public bool MoveToParent()
	{
		return false;
	}

	public bool MoveToFirstChild()
	{
		return false;
	}

	private bool MoveToNextSibling(XmlNode node)
	{
		return false;
	}

	public bool MoveToNext()
	{
		return false;
	}

	public bool MoveToElement()
	{
		return false;
	}

	public string LookupNamespace(string prefix)
	{
		return null;
	}

	internal string DefaultLookupNamespace(string prefix)
	{
		return null;
	}

	internal string LookupPrefix(string namespaceName)
	{
		return null;
	}

	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
	{
		return null;
	}

	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt)
	{
		return false;
	}
}
