namespace System.Xml.Schema;

internal class Datatype_negativeInteger : Datatype_nonPositiveInteger
{
	private static readonly FacetsChecker numeric10FacetsChecker;

	internal override FacetsChecker FacetsChecker => null;

	public override XmlTypeCode TypeCode => default(XmlTypeCode);
}
