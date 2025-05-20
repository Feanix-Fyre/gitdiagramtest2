namespace System.Xml.Schema;

internal class Datatype_List : Datatype_anySimpleType
{
	private DatatypeImplementation itemType;

	private int minListSize;

	public override Type ValueType => null;

	public override XmlTokenizedType TokenizedType => default(XmlTokenizedType);

	internal override Type ListValueType => null;

	internal override FacetsChecker FacetsChecker => null;

	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal override RestrictionFlags ValidRestrictionFlags => default(RestrictionFlags);

	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
	{
		return null;
	}

	internal Datatype_List(DatatypeImplementation type, int minListSize)
	{
	}

	internal override int Compare(object value1, object value2)
	{
		return 0;
	}

	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue)
	{
		typedValue = null;
		return null;
	}

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
	{
		typedValue = null;
		return null;
	}
}
