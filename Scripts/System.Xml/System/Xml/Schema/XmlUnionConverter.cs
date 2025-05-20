namespace System.Xml.Schema;

internal class XmlUnionConverter : XmlBaseConverter
{
	private XmlValueConverter[] converters;

	private bool hasAtomicMember;

	private bool hasListMember;

	protected XmlUnionConverter(XmlSchemaType schemaType)
		: base((XmlSchemaType)null)
	{
	}

	public static XmlValueConverter Create(XmlSchemaType schemaType)
	{
		return null;
	}

	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}
}
