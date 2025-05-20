namespace System.Xml.Schema;

internal class Datatype_positiveInteger : Datatype_nonNegativeInteger
{
	private static readonly FacetsChecker numeric10FacetsChecker;

	internal override FacetsChecker FacetsChecker => null;

	public override XmlTypeCode TypeCode => default(XmlTypeCode);
}
