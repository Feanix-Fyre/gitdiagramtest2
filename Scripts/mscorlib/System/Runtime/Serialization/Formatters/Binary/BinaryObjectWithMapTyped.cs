namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryObjectWithMapTyped
{
	internal BinaryHeaderEnum binaryHeaderEnum;

	internal int objectId;

	internal string name;

	internal int numMembers;

	internal string[] memberNames;

	internal BinaryTypeEnum[] binaryTypeEnumA;

	internal object[] typeInformationA;

	internal int[] memberAssemIds;

	internal int assemId;

	internal BinaryObjectWithMapTyped()
	{
	}

	internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
	{
	}

	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId)
	{
	}

	public void Write(__BinaryWriter sout)
	{
	}

	public void Read(__BinaryParser input)
	{
	}
}
