using System.Xml.XPath;

namespace System.Xml.Schema;

internal class XmlAnyConverter : XmlBaseConverter
{
	public static readonly XmlValueConverter Item;

	public static readonly XmlValueConverter AnyAtomic;

	protected XmlAnyConverter(XmlTypeCode typeCode)
		: base((XmlSchemaType)null)
	{
	}

	public override bool ToBoolean(object value)
	{
		return false;
	}

	public override DateTime ToDateTime(object value)
	{
		return default(DateTime);
	}

	public override DateTimeOffset ToDateTimeOffset(object value)
	{
		return default(DateTimeOffset);
	}

	public override decimal ToDecimal(object value)
	{
		return default(decimal);
	}

	public override double ToDouble(object value)
	{
		return 0.0;
	}

	public override int ToInt32(object value)
	{
		return 0;
	}

	public override long ToInt64(object value)
	{
		return 0L;
	}

	public override float ToSingle(object value)
	{
		return 0f;
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

	private XPathNavigator ToNavigator(XPathNavigator nav)
	{
		return null;
	}
}
