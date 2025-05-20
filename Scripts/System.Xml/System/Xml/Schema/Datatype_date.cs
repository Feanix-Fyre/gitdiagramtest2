namespace System.Xml.Schema;

internal class Datatype_date : Datatype_dateTimeBase
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal Datatype_date()
		: base(default(XsdDateTimeFlags))
	{
	}
}
