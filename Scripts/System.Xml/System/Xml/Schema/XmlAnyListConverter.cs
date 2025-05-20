namespace System.Xml.Schema;

internal class XmlAnyListConverter : XmlListConverter
{
	public static readonly XmlValueConverter ItemList;

	public static readonly XmlValueConverter AnyAtomicList;

	protected XmlAnyListConverter(XmlBaseConverter atomicConverter)
		: base((XmlBaseConverter)null)
	{
	}

	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}
}
