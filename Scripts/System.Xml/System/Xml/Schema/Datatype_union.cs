namespace System.Xml.Schema;

internal class Datatype_union : Datatype_anySimpleType
{
	private static readonly Type atomicValueType;

	private static readonly Type listValueType;

	private XmlSchemaSimpleType[] types;

	public override Type ValueType => null;

	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal override FacetsChecker FacetsChecker => null;

	internal override Type ListValueType => null;

	internal override RestrictionFlags ValidRestrictionFlags => default(RestrictionFlags);

	internal XmlSchemaSimpleType[] BaseMemberTypes => null;

	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
	{
		return null;
	}

	internal Datatype_union(XmlSchemaSimpleType[] types)
	{
	}

	internal override int Compare(object value1, object value2)
	{
		return 0;
	}

	internal bool HasAtomicMembers()
	{
		return false;
	}

	internal bool IsUnionBaseOf(DatatypeImplementation derivedType)
	{
		return false;
	}

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
	{
		typedValue = null;
		return null;
	}

	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
	{
		typedValue = null;
		return null;
	}
}
