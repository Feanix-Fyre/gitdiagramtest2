using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Schema;

internal class XmlListConverter : XmlBaseConverter
{
	protected XmlValueConverter atomicConverter;

	protected XmlListConverter(XmlBaseConverter atomicConverter)
		: base((XmlSchemaType)null)
	{
	}

	protected XmlListConverter(XmlBaseConverter atomicConverter, Type clrTypeDefault)
		: base((XmlSchemaType)null)
	{
	}

	protected XmlListConverter(XmlSchemaType schemaType)
		: base((XmlSchemaType)null)
	{
	}

	public static XmlValueConverter Create(XmlValueConverter atomicConverter)
	{
		return null;
	}

	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	private bool IsListType(Type type)
	{
		return false;
	}

	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	private IList ToList(object list, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	private List<string> StringAsList(string value)
	{
		return null;
	}

	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver)
	{
		return null;
	}

	private new Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType)
	{
		return null;
	}
}
