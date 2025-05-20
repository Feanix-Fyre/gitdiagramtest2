namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObjectWithMap
{
	internal BinaryHeaderEnum binaryHeaderEnum;

	internal int objectId;

	internal string name;

	internal int numMembers;

	internal string[] memberNames;

	internal int assemId;

	internal BinaryObjectWithMap()
	{
	}

	internal BinaryObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
	{
	}

	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId)
	{
	}

	public void Write(__BinaryWriter sout)
	{
	}

	public void Read(__BinaryParser input)
	{
	}

	public void Dump()
	{
	}
}
