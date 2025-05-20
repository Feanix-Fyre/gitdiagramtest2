namespace System.Xml;

internal class XmlRawWriterBase64Encoder : Base64Encoder
{
	private XmlRawWriter rawWriter;

	internal XmlRawWriterBase64Encoder(XmlRawWriter rawWriter)
	{
	}

	internal override void WriteChars(char[] chars, int index, int count)
	{
	}
}
