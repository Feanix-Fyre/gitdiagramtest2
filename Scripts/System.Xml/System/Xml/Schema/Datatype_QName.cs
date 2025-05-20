namespace System.Xml.Schema;

internal class Datatype_QName : Datatype_anySimpleType
{
	private static readonly Type atomicValueType;

	private static readonly Type listValueType;

	internal override FacetsChecker FacetsChecker => null;

	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	public override XmlTokenizedType TokenizedType => default(XmlTokenizedType);

	internal override RestrictionFlags ValidRestrictionFlags => default(RestrictionFlags);

	public override Type ValueType => null;

	internal override Type ListValueType => null;

	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet => default(XmlSchemaWhiteSpace);

	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
	{
		return null;
	}

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
	{
		typedValue = null;
		return null;
	}
}
