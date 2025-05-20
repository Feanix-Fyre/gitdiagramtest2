namespace System.Xml.Schema;

internal class Datatype_string : Datatype_anySimpleType
{
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet => default(XmlSchemaWhiteSpace);

	internal override FacetsChecker FacetsChecker => null;

	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	public override XmlTokenizedType TokenizedType => default(XmlTokenizedType);

	internal override RestrictionFlags ValidRestrictionFlags => default(RestrictionFlags);

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
