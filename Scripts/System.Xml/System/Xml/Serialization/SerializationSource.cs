namespace System.Xml.Serialization;

internal abstract class SerializationSource
{
	private Type[] includedTypes;

	private string namspace;

	private bool canBeGenerated;

	public SerializationSource(string namspace, Type[] includedTypes)
	{
	}

	protected bool BaseEquals(SerializationSource other)
	{
		return false;
	}
}
