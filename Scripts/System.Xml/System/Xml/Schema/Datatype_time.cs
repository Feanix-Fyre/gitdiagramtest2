namespace System.Xml.Schema;

internal class Datatype_time : Datatype_dateTimeBase
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal Datatype_time()
		: base(default(XsdDateTimeFlags))
	{
	}
}
