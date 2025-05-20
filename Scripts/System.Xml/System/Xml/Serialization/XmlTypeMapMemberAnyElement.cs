namespace System.Xml.Serialization;

internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable
{
	public bool IsDefaultAny => false;

	public bool IsElementDefined(string name, string ns)
	{
		return false;
	}
}
