namespace System.IO.Compression;

internal struct Zip64EndOfCentralDirectoryRecord
{
	public ulong SizeOfThisRecord;

	public ushort VersionMadeBy;

	public ushort VersionNeededToExtract;

	public uint NumberOfThisDisk;

	public uint NumberOfDiskWithStartOfCD;

	public ulong NumberOfEntriesOnThisDisk;

	public ulong NumberOfEntriesTotal;

	public ulong SizeOfCentralDirectory;

	public ulong OffsetOfCentralDirectory;

	public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryRecord zip64EOCDRecord)
	{
		zip64EOCDRecord = default(Zip64EndOfCentralDirectoryRecord);
		return false;
	}

	public static void WriteBlock(Stream stream, long numberOfEntries, long startOfCentralDirectory, long sizeOfCentralDirectory)
	{
	}
}
