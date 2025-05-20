namespace System.Xml.Schema;

internal class Datatype_QNameXdr : Datatype_anySimpleType
{
	private static readonly Type atomicValueType;

	private static readonly Type listValueType;

	public override XmlTokenizedType TokenizedType => default(XmlTokenizedType);

	public override Type ValueType => null;

	internal override Type ListValueType => null;

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
	{
		return null;
	}
}
