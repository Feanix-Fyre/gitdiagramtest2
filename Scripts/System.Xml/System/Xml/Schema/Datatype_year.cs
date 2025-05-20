namespace System.Xml.Schema;

internal class Datatype_year : Datatype_dateTimeBase
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal Datatype_year()
		: base(default(XsdDateTimeFlags))
	{
	}
}
