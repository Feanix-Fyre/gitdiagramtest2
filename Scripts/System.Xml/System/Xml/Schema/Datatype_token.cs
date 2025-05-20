namespace System.Xml.Schema;

internal class Datatype_token : Datatype_normalizedString
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet => default(XmlSchemaWhiteSpace);
}
