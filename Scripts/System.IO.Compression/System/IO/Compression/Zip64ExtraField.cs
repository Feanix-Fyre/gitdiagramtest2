using System.Collections.Generic;

namespace System.IO.Compression;

internal struct Zip64ExtraField
{
	private ushort _size;

	private long? _uncompressedSize;

	private long? _compressedSize;

	private long? _localHeaderOffset;

	private int? _startDiskNumber;

	public ushort TotalSize => 0;

	public long? UncompressedSize
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long? CompressedSize
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long? LocalHeaderOffset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int? StartDiskNumber => null;

	private void UpdateSize()
	{
	}

	public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
	{
		return default(Zip64ExtraField);
	}

	private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block)
	{
		zip64Block = default(Zip64ExtraField);
		return false;
	}

	public static Zip64ExtraField GetAndRemoveZip64Block(List<ZipGenericExtraField> extraFields, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
	{
		return default(Zip64ExtraField);
	}

	public static void RemoveZip64Blocks(List<ZipGenericExtraField> extraFields)
	{
	}

	public void WriteBlock(Stream stream)
	{
	}
}
