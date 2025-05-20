using System.Collections.Generic;

namespace System.IO.Compression;

internal struct ZipCentralDirectoryFileHeader
{
	public byte VersionMadeByCompatibility;

	public byte VersionMadeBySpecification;

	public ushort VersionNeededToExtract;

	public ushort GeneralPurposeBitFlag;

	public ushort CompressionMethod;

	public uint LastModified;

	public uint Crc32;

	public long CompressedSize;

	public long UncompressedSize;

	public ushort FilenameLength;

	public ushort ExtraFieldLength;

	public ushort FileCommentLength;

	public int DiskNumberStart;

	public ushort InternalFileAttributes;

	public uint ExternalFileAttributes;

	public long RelativeOffsetOfLocalHeader;

	public byte[] Filename;

	public byte[] FileComment;

	public List<ZipGenericExtraField> ExtraFields;

	public static bool TryReadBlock(BinaryReader reader, bool saveExtraFieldsAndComments, out ZipCentralDirectoryFileHeader header)
	{
		header = default(ZipCentralDirectoryFileHeader);
		return false;
	}
}
