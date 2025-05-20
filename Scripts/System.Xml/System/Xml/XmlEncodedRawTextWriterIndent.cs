using System.IO;

namespace System.Xml;

internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter
{
	protected int indentLevel;

	protected bool newLineOnAttributes;

	protected string indentChars;

	protected bool mixedContent;

	private BitStack mixedContentStack;

	protected ConformanceLevel conformanceLevel;

	public XmlEncodedRawTextWriterIndent(TextWriter writer, XmlWriterSettings settings)
		: base(null)
	{
	}

	public XmlEncodedRawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		: base(null)
	{
	}

	public override void WriteDocType(string name, string pubid, string sysid, string subset)
	{
	}

	public override void WriteStartElement(string prefix, string localName, string ns)
	{
	}

	internal override void StartElementContent()
	{
	}

	internal override void OnRootElement(ConformanceLevel currentConformanceLevel)
	{
	}

	internal override void WriteEndElement(string prefix, string localName, string ns)
	{
	}

	internal override void WriteFullEndElement(string prefix, string localName, string ns)
	{
	}

	public override void WriteStartAttribute(string prefix, string localName, string ns)
	{
	}

	public override void WriteCData(string text)
	{
	}

	public override void WriteComment(string text)
	{
	}

	public override void WriteProcessingInstruction(string target, string text)
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

	public override void WriteBase64(byte[] buffer, int index, int count)
	{
	}

	private void Init(XmlWriterSettings settings)
	{
	}

	private void WriteIndent()
	{
	}
}
