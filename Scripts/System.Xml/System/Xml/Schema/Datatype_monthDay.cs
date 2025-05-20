namespace System.Xml.Schema;

internal class Datatype_monthDay : Datatype_dateTimeBase
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal Datatype_monthDay()
		: base(default(XsdDateTimeFlags))
	{
	}
}
