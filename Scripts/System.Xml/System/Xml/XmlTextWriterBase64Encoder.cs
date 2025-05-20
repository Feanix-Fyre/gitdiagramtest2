namespace System.Xml;

internal class XmlTextWriterBase64Encoder : Base64Encoder
{
	private XmlTextEncoder xmlTextEncoder;

	internal XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder)
	{
	}

	internal override void WriteChars(char[] chars, int index, int count)
	{
	}
}
