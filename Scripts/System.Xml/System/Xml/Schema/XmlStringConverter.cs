namespace System.Xml.Schema;

internal class XmlStringConverter : XmlBaseConverter
{
	protected XmlStringConverter(XmlSchemaType schemaType)
		: base((XmlSchemaType)null)
	{
	}

	public static XmlValueConverter Create(XmlSchemaType schemaType)
	{
		return null;
	}

	public override string ToString(object value, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}
}
