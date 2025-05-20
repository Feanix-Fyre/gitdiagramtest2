namespace System.Xml.Schema;

internal class ChameleonKey
{
	internal string targetNS;

	internal Uri chameleonLocation;

	internal XmlSchema originalSchema;

	private int hashCode;

	public ChameleonKey(string ns, XmlSchema originalSchema)
	{
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
