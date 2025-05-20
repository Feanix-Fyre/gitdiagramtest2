namespace System.Xml.Schema;

internal class Datatype_month : Datatype_dateTimeBase
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal Datatype_month()
		: base(default(XsdDateTimeFlags))
	{
	}
}
