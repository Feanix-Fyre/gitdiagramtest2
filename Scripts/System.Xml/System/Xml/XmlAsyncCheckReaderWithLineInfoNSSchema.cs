using System.Xml.Schema;

namespace System.Xml;

internal class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo
{
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo;

	XmlSchemaValidity IXmlSchemaInfo.Validity => default(XmlSchemaValidity);

	bool IXmlSchemaInfo.IsDefault => false;

	bool IXmlSchemaInfo.IsNil => false;

	XmlSchemaSimpleType IXmlSchemaInfo.MemberType => null;

	XmlSchemaType IXmlSchemaInfo.SchemaType => null;

	XmlSchemaElement IXmlSchemaInfo.SchemaElement => null;

	XmlSchemaAttribute IXmlSchemaInfo.SchemaAttribute => null;

	public XmlAsyncCheckReaderWithLineInfoNSSchema(XmlReader reader)
		: base(null)
	{
	}
}
