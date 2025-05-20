namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectMapInfo
{
	internal int objectId;

	private int numMembers;

	private string[] memberNames;

	private Type[] memberTypes;

	internal ObjectMapInfo(int objectId, int numMembers, string[] memberNames, Type[] memberTypes)
	{
	}

	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes)
	{
		return false;
	}
}
