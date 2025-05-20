namespace System.Xml.Schema;

internal class XmlBooleanConverter : XmlBaseConverter
{
	protected XmlBooleanConverter(XmlSchemaType schemaType)
		: base((XmlSchemaType)null)
	{
	}

	public static XmlValueConverter Create(XmlSchemaType schemaType)
	{
		return null;
	}

	public override bool ToBoolean(string value)
	{
		return false;
	}

	public override bool ToBoolean(object value)
	{
		return false;
	}

	public override string ToString(bool value)
	{
		return null;
	}

	public override string ToString(object value, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	public override object ChangeType(bool value, Type destinationType)
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
