namespace System.Xml.Schema;

internal class XmlNumeric2Converter : XmlBaseConverter
{
	protected XmlNumeric2Converter(XmlSchemaType schemaType)
		: base((XmlSchemaType)null)
	{
	}

	public static XmlValueConverter Create(XmlSchemaType schemaType)
	{
		return null;
	}

	public override double ToDouble(string value)
	{
		return 0.0;
	}

	public override double ToDouble(object value)
	{
		return 0.0;
	}

	public override float ToSingle(double value)
	{
		return 0f;
	}

	public override float ToSingle(string value)
	{
		return 0f;
	}

	public override float ToSingle(object value)
	{
		return 0f;
	}

	public override string ToString(double value)
	{
		return null;
	}

	public override string ToString(float value)
	{
		return null;
	}

	public override string ToString(object value, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	public override object ChangeType(double value, Type destinationType)
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
