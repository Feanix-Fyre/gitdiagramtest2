namespace System.Xml.Schema;

internal class Datatype_NCName : Datatype_Name
{
	public override XmlTypeCode TypeCode => default(XmlTypeCode);

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
	{
		typedValue = null;
		return null;
	}
}
