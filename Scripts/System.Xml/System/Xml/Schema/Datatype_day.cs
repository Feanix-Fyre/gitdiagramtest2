namespace System.Xml.Schema;

internal class Datatype_day : Datatype_dateTimeBase
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal Datatype_day()
		: base(default(XsdDateTimeFlags))
	{
	}
}
