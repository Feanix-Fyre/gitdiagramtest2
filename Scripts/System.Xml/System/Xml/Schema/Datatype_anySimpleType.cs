namespace System.Xml.Schema;

internal class Datatype_anySimpleType : DatatypeImplementation
{
	private static readonly Type atomicValueType;

	private static readonly Type listValueType;

	internal override FacetsChecker FacetsChecker => null;

	public override Type ValueType => null;

	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal override Type ListValueType => null;

	public override XmlTokenizedType TokenizedType => default(XmlTokenizedType);

	internal override RestrictionFlags ValidRestrictionFlags => default(RestrictionFlags);

	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet => default(XmlSchemaWhiteSpace);

	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
	{
		return null;
	}

	internal override int Compare(object value1, object value2)
	{
		return 0;
	}

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
	{
		typedValue = null;
		return null;
	}
}
