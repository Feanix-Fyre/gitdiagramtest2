using System.Collections.Generic;

namespace System.IO.Compression;

internal struct ZipGenericExtraField
{
	private ushort _tag;

	private ushort _size;

	private byte[] _data;

	public ushort Tag => 0;

	public ushort Size => 0;

	public byte[] Data => null;

	public void WriteBlock(Stream stream)
	{
	}

	public static bool TryReadBlock(BinaryReader reader, long endExtraField, out ZipGenericExtraField field)
	{
		field = default(ZipGenericExtraField);
		return false;
	}

	public static List<ZipGenericExtraField> ParseExtraField(Stream extraFieldData)
	{
		return null;
	}

	public static int TotalSize(List<ZipGenericExtraField> fields)
	{
		return 0;
	}

	public static void WriteAllBlocks(List<ZipGenericExtraField> fields, Stream stream)
	{
	}
}
