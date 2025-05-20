using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace System.Xml;

[DefaultMember("Item")]
internal class XmlAsyncCheckReader : XmlReader
{
	private readonly XmlReader coreReader;

	private Task lastTask;

	internal XmlReader CoreReader => null;

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

	public override bool CanResolveEntity => false;

	public override bool CanReadValueChunk => false;

	public override bool HasAttributes => false;

	internal override XmlNamespaceManager NamespaceManager => null;

	internal override IDtdInfo DtdInfo => null;

	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader)
	{
		return null;
	}

	public XmlAsyncCheckReader(XmlReader reader)
	{
	}

	private void CheckAsync()
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

	public override bool ReadAttributeValue()
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

	public override int ReadValueChunk(char[] buffer, int index, int count)
	{
		return 0;
	}

	public override string ReadString()
	{
		return null;
	}

	public override XmlNodeType MoveToContent()
	{
		return default(XmlNodeType);
	}

	public override void ReadStartElement()
	{
	}

	public override string ReadElementString()
	{
		return null;
	}

	public override void ReadEndElement()
	{
	}

	public override bool IsStartElement(string localname, string ns)
	{
		return false;
	}

	public override bool ReadToFollowing(string name)
	{
		return false;
	}

	public override string ReadInnerXml()
	{
		return null;
	}

	protected override void Dispose(bool disposing)
	{
	}
}
