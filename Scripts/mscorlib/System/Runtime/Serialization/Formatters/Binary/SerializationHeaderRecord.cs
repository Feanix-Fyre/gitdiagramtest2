namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class SerializationHeaderRecord
{
	internal int binaryFormatterMajorVersion;

	internal int binaryFormatterMinorVersion;

	internal BinaryHeaderEnum binaryHeaderEnum;

	internal int topId;

	internal int headerId;

	internal int majorVersion;

	internal int minorVersion;

	internal SerializationHeaderRecord()
	{
	}

	internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion)
	{
	}

	public void Write(__BinaryWriter sout)
	{
	}

	private static int GetInt32(byte[] buffer, int index)
	{
		return 0;
	}

	public void Read(__BinaryParser input)
	{
	}

	public void Dump()
	{
	}
}
