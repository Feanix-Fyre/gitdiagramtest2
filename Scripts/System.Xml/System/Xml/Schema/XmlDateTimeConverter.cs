namespace System.Xml.Schema;

internal class XmlDateTimeConverter : XmlBaseConverter
{
	protected XmlDateTimeConverter(XmlSchemaType schemaType)
		: base((XmlSchemaType)null)
	{
	}

	public static XmlValueConverter Create(XmlSchemaType schemaType)
	{
		return null;
	}

	public override DateTime ToDateTime(DateTimeOffset value)
	{
		return default(DateTime);
	}

	public override DateTime ToDateTime(string value)
	{
		return default(DateTime);
	}

	public override DateTime ToDateTime(object value)
	{
		return default(DateTime);
	}

	public override DateTimeOffset ToDateTimeOffset(DateTime value)
	{
		return default(DateTimeOffset);
	}

	public override DateTimeOffset ToDateTimeOffset(string value)
	{
		return default(DateTimeOffset);
	}

	public override DateTimeOffset ToDateTimeOffset(object value)
	{
		return default(DateTimeOffset);
	}

	public override string ToString(DateTime value)
	{
		return null;
	}

	public override string ToString(DateTimeOffset value)
	{
		return null;
	}

	public override string ToString(object value, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	public override object ChangeType(DateTime value, Type destinationType)
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
