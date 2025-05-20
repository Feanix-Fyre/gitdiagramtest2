namespace System.Xml.Schema;

internal class Datatype_nonNegativeInteger : Datatype_integer
{
	private static readonly FacetsChecker numeric10FacetsChecker;

	internal override FacetsChecker FacetsChecker => null;

	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal override bool HasValueFacets => false;
}
