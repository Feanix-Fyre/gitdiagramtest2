namespace System.Xml.Serialization;

internal class XmlTypeSerializationSource : SerializationSource
{
	private string attributeOverridesHash;

	private Type type;

	private string rootHash;

	public XmlTypeSerializationSource(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes)
		: base(null, null)
	{
	}

	public override bool Equals(object o)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
