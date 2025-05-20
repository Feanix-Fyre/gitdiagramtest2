namespace System.Xml.Schema;

internal class Datatype_yearMonth : Datatype_dateTimeBase
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal Datatype_yearMonth()
		: base(default(XsdDateTimeFlags))
	{
	}
}
