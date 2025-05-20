using System.IO;

namespace System.Xml;

internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter
{
	private int indentLevel;

	private int endBlockPos;

	private string indentChars;

	private bool newLineOnAttributes;

	public HtmlUtf8RawTextWriterIndent(Stream stream, XmlWriterSettings settings)
		: base(null, null)
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

	internal override void WriteEndElement(string prefix, string localName, string ns)
	{
	}

	public override void WriteStartAttribute(string prefix, string localName, string ns)
	{
	}

	protected override void FlushBuffer()
	{
	}

	private void Init(XmlWriterSettings settings)
	{
	}

	private void WriteIndent()
	{
	}
}
