using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;

namespace System.Xml;

internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver
{
	private enum ValidatingReaderState
	{
		None = 0,
		Init = 1,
		Read = 2,
		OnDefaultAttribute = -1,
		OnReadAttributeValue = -2,
		OnAttribute = 3,
		ClearAttributes = 4,
		ParseInlineSchema = 5,
		ReadAhead = 6,
		OnReadBinaryContent = 7,
		ReaderClosed = 8,
		EOF = 9,
		Error = 10
	}

	private XmlReader coreReader;

	private IXmlNamespaceResolver coreReaderNSResolver;

	private IXmlNamespaceResolver thisNSResolver;

	private XmlSchemaValidator validator;

	private XmlResolver xmlResolver;

	private ValidationEventHandler validationEvent;

	private ValidatingReaderState validationState;

	private XmlValueGetter valueGetter;

	private XmlNamespaceManager nsManager;

	private bool manageNamespaces;

	private bool processInlineSchema;

	private bool replayCache;

	private ValidatingReaderNodeData cachedNode;

	private AttributePSVIInfo attributePSVI;

	private int attributeCount;

	private int coreReaderAttributeCount;

	private int currentAttrIndex;

	private AttributePSVIInfo[] attributePSVINodes;

	private ArrayList defaultAttributes;

	private Parser inlineSchemaParser;

	private object atomicValue;

	private XmlSchemaInfo xmlSchemaInfo;

	private string originalAtomicValueString;

	private XmlNameTable coreReaderNameTable;

	private XsdCachingReader cachingReader;

	private ValidatingReaderNodeData textNode;

	private string NsXmlNs;

	private string NsXs;

	private string NsXsi;

	private string XsiType;

	private string XsiNil;

	private string XsdSchema;

	private string XsiSchemaLocation;

	private string XsiNoNamespaceSchemaLocation;

	private XmlCharType xmlCharType;

	private IXmlLineInfo lineInfo;

	private ReadContentAsBinaryHelper readBinaryHelper;

	private ValidatingReaderState savedState;

	private static Type TypeOfString;

	public override XmlReaderSettings Settings => null;

	public override XmlNodeType NodeType => default(XmlNodeType);

	public override string Name => null;

	public override string LocalName => null;

	public override string NamespaceURI => null;

	public override string Prefix => null;

	public override string Value => null;

	public override int Depth => 0;

	public override string BaseURI => null;

	public override bool IsEmptyElement => false;

	public override bool IsDefault => false;

	public override char QuoteChar => '\0';

	public override XmlSpace XmlSpace => default(XmlSpace);

	public override string XmlLang => null;

	public override IXmlSchemaInfo SchemaInfo => null;

	public override Type ValueType => null;

	public override int AttributeCount => 0;

	public override bool EOF => false;

	public override ReadState ReadState => default(ReadState);

	public override XmlNameTable NameTable => null;

	bool IXmlSchemaInfo.IsDefault => false;

	bool IXmlSchemaInfo.IsNil => false;

	XmlSchemaValidity IXmlSchemaInfo.Validity => default(XmlSchemaValidity);

	XmlSchemaSimpleType IXmlSchemaInfo.MemberType => null;

	XmlSchemaType IXmlSchemaInfo.SchemaType => null;

	XmlSchemaElement IXmlSchemaInfo.SchemaElement => null;

	XmlSchemaAttribute IXmlSchemaInfo.SchemaAttribute => null;

	public int LineNumber => 0;

	public int LinePosition => 0;

	private XmlSchemaInfo AttributeSchemaInfo => null;

	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType)
	{
	}

	internal XsdValidatingReader(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings)
	{
	}

	private void Init()
	{
	}

	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType)
	{
	}

	public override string GetAttribute(string name)
	{
		return null;
	}

	public override string GetAttribute(string name, string namespaceURI)
	{
		return null;
	}

	public override string GetAttribute(int i)
	{
		return null;
	}

	public override bool MoveToAttribute(string name)
	{
		return false;
	}

	public override void MoveToAttribute(int i)
	{
	}

	public override bool MoveToFirstAttribute()
	{
		return false;
	}

	public override bool MoveToNextAttribute()
	{
		return false;
	}

	public override bool MoveToElement()
	{
		return false;
	}

	public override bool Read()
	{
		return false;
	}

	public override void Close()
	{
	}

	public override void Skip()
	{
	}

	public override string LookupNamespace(string prefix)
	{
		return null;
	}

	public override void ResolveEntity()
	{
	}

	public override bool ReadAttributeValue()
	{
		return false;
	}

	public bool HasLineInfo()
	{
		return false;
	}

	IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
	{
		return null;
	}

	string IXmlNamespaceResolver.LookupNamespace(string prefix)
	{
		return null;
	}

	string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
	{
		return null;
	}

	private object GetStringValue()
	{
		return null;
	}

	private void ProcessReaderEvent()
	{
	}

	private void ProcessElementEvent()
	{
	}

	private void ProcessEndElementEvent()
	{
	}

	private void ValidateAttributes()
	{
	}

	private void ClearAttributesInfo()
	{
	}

	private AttributePSVIInfo GetAttributePSVI(string name)
	{
		return null;
	}

	private AttributePSVIInfo GetAttributePSVI(string localName, string ns)
	{
		return null;
	}

	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition)
	{
		return null;
	}

	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition)
	{
		return null;
	}

	private AttributePSVIInfo AddAttributePSVI(int attIndex)
	{
		return null;
	}

	private bool IsXSDRoot(string localName, string ns)
	{
		return false;
	}

	private void ProcessInlineSchema()
	{
	}

	private void ReadAheadForMemberType()
	{
	}

	private void GetIsDefault()
	{
	}

	private void GetMemberType()
	{
	}

	private XsdCachingReader GetCachingReader()
	{
		return null;
	}

	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth)
	{
		return null;
	}

	internal void CachingCallBack(XsdCachingReader cachingReader)
	{
	}

	private string GetOriginalAtomicValueStringOfElement()
	{
		return null;
	}
}
