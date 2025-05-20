namespace System.IO.Compression;

internal struct ZipEndOfCentralDirectoryBlock
{
	public uint Signature;

	public ushort NumberOfThisDisk;

	public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory;

	public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk;

	public ushort NumberOfEntriesInTheCentralDirectory;

	public uint SizeOfCentralDirectory;

	public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber;

	public byte[] ArchiveComment;

	public static void WriteBlock(Stream stream, long numberOfEntries, long startOfCentralDirectory, long sizeOfCentralDirectory, byte[] archiveComment)
	{
	}

	public static bool TryReadBlock(BinaryReader reader, out ZipEndOfCentralDirectoryBlock eocdBlock)
	{
		eocdBlock = default(ZipEndOfCentralDirectoryBlock);
		return false;
	}
}
