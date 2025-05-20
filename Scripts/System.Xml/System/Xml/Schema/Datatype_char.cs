namespace System.Xml.Schema;

internal class Datatype_char : Datatype_anySimpleType
{
	private static readonly Type atomicValueType;

	private static readonly Type listValueType;

	public override Type ValueType => null;

	internal override Type ListValueType => null;

	internal override RestrictionFlags ValidRestrictionFlags => default(RestrictionFlags);

	internal override int Compare(object value1, object value2)
	{
		return 0;
	}

	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
	{
		return null;
	}

	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
	{
		typedValue = null;
		return null;
	}
}
