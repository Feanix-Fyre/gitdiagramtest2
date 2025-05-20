namespace System.Xml.Schema;

internal class Datatype_anyAtomicType : Datatype_anySimpleType
{
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet => default(XmlSchemaWhiteSpace);

	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
	{
		return null;
	}
}
