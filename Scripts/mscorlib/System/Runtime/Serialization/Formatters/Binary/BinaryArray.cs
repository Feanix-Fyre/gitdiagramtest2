namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class BinaryArray
{
	internal int objectId;

	internal int rank;

	internal int[] lengthA;

	internal int[] lowerBoundA;

	internal BinaryTypeEnum binaryTypeEnum;

	internal object typeInformation;

	internal int assemId;

	private BinaryHeaderEnum binaryHeaderEnum;

	internal BinaryArrayTypeEnum binaryArrayTypeEnum;

	internal BinaryArray()
	{
	}

	internal BinaryArray(BinaryHeaderEnum binaryHeaderEnum)
	{
	}

	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId)
	{
	}

	public void Write(__BinaryWriter sout)
	{
	}

	public void Read(__BinaryParser input)
	{
	}
}
