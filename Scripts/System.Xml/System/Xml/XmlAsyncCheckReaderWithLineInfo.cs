namespace System.Xml;

internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo
{
	private readonly IXmlLineInfo readerAsIXmlLineInfo;

	public virtual int LineNumber => 0;

	public virtual int LinePosition => 0;

	public XmlAsyncCheckReaderWithLineInfo(XmlReader reader)
		: base(null)
	{
	}

	public virtual bool HasLineInfo()
	{
		return false;
	}
}
