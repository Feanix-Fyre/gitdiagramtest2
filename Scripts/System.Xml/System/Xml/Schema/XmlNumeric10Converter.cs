namespace System.Xml.Schema;

internal class XmlNumeric10Converter : XmlBaseConverter
{
	protected XmlNumeric10Converter(XmlSchemaType schemaType)
		: base((XmlSchemaType)null)
	{
	}

	public static XmlValueConverter Create(XmlSchemaType schemaType)
	{
		return null;
	}

	public override decimal ToDecimal(string value)
	{
		return default(decimal);
	}

	public override decimal ToDecimal(object value)
	{
		return default(decimal);
	}

	public override int ToInt32(long value)
	{
		return 0;
	}

	public override int ToInt32(string value)
	{
		return 0;
	}

	public override int ToInt32(object value)
	{
		return 0;
	}

	public override long ToInt64(int value)
	{
		return 0L;
	}

	public override long ToInt64(string value)
	{
		return 0L;
	}

	public override long ToInt64(object value)
	{
		return 0L;
	}

	public override string ToString(decimal value)
	{
		return null;
	}

	public override string ToString(int value)
	{
		return null;
	}

	public override string ToString(long value)
	{
		return null;
	}

	public override string ToString(object value, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	public override object ChangeType(decimal value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(int value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(long value, Type destinationType)
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

	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}
}
