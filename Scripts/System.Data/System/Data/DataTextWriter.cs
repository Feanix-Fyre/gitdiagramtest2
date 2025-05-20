using System.IO;
using System.Xml;

namespace System.Data;

internal sealed class DataTextWriter : XmlWriter
{
	private XmlWriter _xmltextWriter;

	internal Stream BaseStream => null;

	public override WriteState WriteState => default(WriteState);

	internal static XmlWriter CreateWriter(XmlWriter xw)
	{
		return null;
	}

	private DataTextWriter(XmlWriter w)
	{
	}

	public override void WriteStartDocument()
	{
	}

	public override void WriteStartDocument(bool standalone)
	{
	}

	public override void WriteEndDocument()
	{
	}

	public override void WriteDocType(string name, string pubid, string sysid, string subset)
	{
	}

	public override void WriteStartElement(string prefix, string localName, string ns)
	{
	}

	public override void WriteEndElement()
	{
	}

	public override void WriteFullEndElement()
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

	public override void WriteEntityRef(string name)
	{
	}

	public override void WriteCharEntity(char ch)
	{
	}

	public override void WriteWhitespace(string ws)
	{
	}

	public override void WriteString(string text)
	{
	}

	public override void WriteSurrogateCharEntity(char lowChar, char highChar)
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

	public override void WriteBinHex(byte[] buffer, int index, int count)
	{
	}

	public override void Close()
	{
	}

	public override void Flush()
	{
	}

	public override string LookupPrefix(string ns)
	{
		return null;
	}
}
