using System.IO;

namespace System.Xml;

internal class XmlAutoDetectWriter : XmlRawWriter
{
	private XmlRawWriter wrapped;

	private OnRemoveWriter onRemove;

	private XmlWriterSettings writerSettings;

	private XmlEventCache eventCache;

	private TextWriter textWriter;

	private Stream strm;

	internal override IXmlNamespaceResolver NamespaceResolver
	{
		set
		{
		}
	}

	internal override bool SupportsNamespaceDeclarationInChunks => false;

	private XmlAutoDetectWriter(XmlWriterSettings writerSettings)
	{
	}

	public XmlAutoDetectWriter(TextWriter textWriter, XmlWriterSettings writerSettings)
	{
	}

	public XmlAutoDetectWriter(Stream strm, XmlWriterSettings writerSettings)
	{
	}

	public override void WriteDocType(string name, string pubid, string sysid, string subset)
	{
	}

	public override void WriteStartElement(string prefix, string localName, string ns)
	{
	}

	public override void WriteStartAttribute(string prefix, string localName, string ns)
	{
	}

	public override void WriteEndAttribute()
	{
	}

	public override void WriteCData(string text)
	{
	}

	public override void WriteComment(string text)
	{
	}

	public override void WriteProcessingInstruction(string name, string text)
	{
	}

	public override void WriteWhitespace(string ws)
	{
	}

	public override void WriteString(string text)
	{
	}

	public override void WriteChars(char[] buffer, int index, int count)
	{
	}

	public override void WriteRaw(char[] buffer, int index, int count)
	{
	}

	public override void WriteRaw(string data)
	{
	}

	public override void WriteEntityRef(string name)
	{
	}

	public override void WriteCharEntity(char ch)
	{
	}

	public override void WriteSurrogateCharEntity(char lowChar, char highChar)
	{
	}

	public override void WriteBase64(byte[] buffer, int index, int count)
	{
	}

	public override void WriteBinHex(byte[] buffer, int index, int count)
	{
	}

	public override void Close()
	{
	}

	public override void Flush()
	{
	}

	public override void WriteValue(string value)
	{
	}

	internal override void WriteXmlDeclaration(XmlStandalone standalone)
	{
	}

	internal override void WriteXmlDeclaration(string xmldecl)
	{
	}

	internal override void StartElementContent()
	{
	}

	internal override void WriteEndElement(string prefix, string localName, string ns)
	{
	}

	internal override void WriteFullEndElement(string prefix, string localName, string ns)
	{
	}

	internal override void WriteNamespaceDeclaration(string prefix, string ns)
	{
	}

	internal override void WriteStartNamespaceDeclaration(string prefix)
	{
	}

	internal override void WriteEndNamespaceDeclaration()
	{
	}

	private static bool IsHtmlTag(string tagName)
	{
		return false;
	}

	private void EnsureWrappedWriter(XmlOutputMethod outMethod)
	{
	}

	private bool TextBlockCreatesWriter(string textBlock)
	{
		return false;
	}

	private void CreateWrappedWriter(XmlOutputMethod outMethod)
	{
	}
}
