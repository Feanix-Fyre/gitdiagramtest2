namespace System.Xml.Schema;

internal class XmlUntypedConverter : XmlListConverter
{
	private bool allowListToList;

	public static readonly XmlValueConverter Untyped;

	public static readonly XmlValueConverter UntypedList;

	protected XmlUntypedConverter()
		: base((XmlBaseConverter)null)
	{
	}

	protected XmlUntypedConverter(XmlUntypedConverter atomicConverter, bool allowListToList)
		: base((XmlBaseConverter)null)
	{
	}

	public override bool ToBoolean(string value)
	{
		return false;
	}

	public override bool ToBoolean(object value)
	{
		return false;
	}

	public override DateTime ToDateTime(string value)
	{
		return default(DateTime);
	}

	public override DateTime ToDateTime(object value)
	{
		return default(DateTime);
	}

	public override DateTimeOffset ToDateTimeOffset(string value)
	{
		return default(DateTimeOffset);
	}

	public override DateTimeOffset ToDateTimeOffset(object value)
	{
		return default(DateTimeOffset);
	}

	public override decimal ToDecimal(string value)
	{
		return default(decimal);
	}

	public override decimal ToDecimal(object value)
	{
		return default(decimal);
	}

	public override double ToDouble(string value)
	{
		return 0.0;
	}

	public override double ToDouble(object value)
	{
		return 0.0;
	}

	public override int ToInt32(string value)
	{
		return 0;
	}

	public override int ToInt32(object value)
	{
		return 0;
	}

	public override long ToInt64(string value)
	{
		return 0L;
	}

	public override long ToInt64(object value)
	{
		return 0L;
	}

	public override float ToSingle(string value)
	{
		return 0f;
	}

	public override float ToSingle(object value)
	{
		return 0f;
	}

	public override string ToString(bool value)
	{
		return null;
	}

	public override string ToString(DateTime value)
	{
		return null;
	}

	public override string ToString(DateTimeOffset value)
	{
		return null;
	}

	public override string ToString(decimal value)
	{
		return null;
	}

	public override string ToString(double value)
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

	public override string ToString(float value)
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

	public override object ChangeType(DateTime value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(decimal value, Type destinationType)
	{
		return null;
	}

	public override object ChangeType(double value, Type destinationType)
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

	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	private bool SupportsType(Type clrType)
	{
		return false;
	}
}
