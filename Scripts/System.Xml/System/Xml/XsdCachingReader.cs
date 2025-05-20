using System.Reflection;

namespace System.Xml;

[DefaultMember("Item")]
internal class XsdCachingReader : XmlReader, IXmlLineInfo
{
	private enum CachingReaderState
	{
		None = 0,
		Init = 1,
		Record = 2,
		Replay = 3,
		ReaderClosed = 4,
		Error = 5
	}

	private XmlReader coreReader;

	private XmlNameTable coreReaderNameTable;

	private ValidatingReaderNodeData[] contentEvents;

	private ValidatingReaderNodeData[] attributeEvents;

	private ValidatingReaderNodeData cachedNode;

	private CachingReaderState cacheState;

	private int contentIndex;

	private int attributeCount;

	private bool returnOriginalStringValues;

	private CachingEventHandler cacheHandler;

	private int currentAttrIndex;

	private int currentContentIndex;

	private bool readAhead;

	private IXmlLineInfo lineInfo;

	private ValidatingReaderNodeData textNode;

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

	public override int AttributeCount => 0;

	public override bool EOF => false;

	public override ReadState ReadState => default(ReadState);

	public override XmlNameTable NameTable => null;

	int IXmlLineInfo.LineNumber => 0;

	int IXmlLineInfo.LinePosition => 0;

	internal XsdCachingReader(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod)
	{
	}

	private void Init()
	{
	}

	internal void Reset(XmlReader reader)
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

	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos)
	{
		return null;
	}

	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue)
	{
	}

	internal void RecordEndElementNode()
	{
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

	bool IXmlLineInfo.HasLineInfo()
	{
		return false;
	}

	internal void SetToReplayMode()
	{
	}

	internal XmlReader GetCoreReader()
	{
		return null;
	}

	internal IXmlLineInfo GetLineInfo()
	{
		return null;
	}

	private void ClearAttributesInfo()
	{
	}

	private ValidatingReaderNodeData AddAttribute(int attIndex)
	{
		return null;
	}

	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType)
	{
		return null;
	}

	private void RecordAttributes()
	{
	}

	private int GetAttributeIndexWithoutPrefix(string name)
	{
		return 0;
	}

	private int GetAttributeIndexWithPrefix(string name)
	{
		return 0;
	}

	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth)
	{
		return null;
	}
}
