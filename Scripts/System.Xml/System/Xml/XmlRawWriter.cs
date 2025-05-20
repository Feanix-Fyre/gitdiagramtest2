namespace System.Xml;

internal abstract class XmlRawWriter : XmlWriter
{
	protected XmlRawWriterBase64Encoder base64Encoder;

	protected IXmlNamespaceResolver resolver;

	public override WriteState WriteState => default(WriteState);

	internal virtual IXmlNamespaceResolver NamespaceResolver
	{
		set
		{
		}
	}

	internal virtual bool SupportsNamespaceDeclarationInChunks => false;

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

	public override void WriteEndElement()
	{
	}

	public override void WriteFullEndElement()
	{
	}

	public override void WriteBase64(byte[] buffer, int index, int count)
	{
	}

	public override string LookupPrefix(string ns)
	{
		return null;
	}

	public override void WriteCData(string text)
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

	public override void WriteChars(char[] buffer, int index, int count)
	{
	}

	public override void WriteRaw(char[] buffer, int index, int count)
	{
	}

	public override void WriteRaw(string data)
	{
	}

	public override void WriteValue(string value)
	{
	}

	public override void WriteAttributes(XmlReader reader, bool defattr)
	{
	}

	public override void WriteNode(XmlReader reader, bool defattr)
	{
	}

	internal virtual void WriteXmlDeclaration(XmlStandalone standalone)
	{
	}

	internal virtual void WriteXmlDeclaration(string xmldecl)
	{
	}

	internal abstract void StartElementContent();

	internal virtual void OnRootElement(ConformanceLevel conformanceLevel)
	{
	}

	internal abstract void WriteEndElement(string prefix, string localName, string ns);

	internal virtual void WriteFullEndElement(string prefix, string localName, string ns)
	{
	}

	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	internal virtual void WriteStartNamespaceDeclaration(string prefix)
	{
	}

	internal virtual void WriteEndNamespaceDeclaration()
	{
	}

	internal virtual void WriteEndBase64()
	{
	}

	internal virtual void Close(WriteState currentState)
	{
	}
}
