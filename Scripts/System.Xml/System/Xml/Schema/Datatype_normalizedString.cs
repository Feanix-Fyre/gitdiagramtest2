namespace System.Xml.Schema;

internal class Datatype_normalizedString : Datatype_string
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet => default(XmlSchemaWhiteSpace);

	internal override bool HasValueFacets => false;
}
