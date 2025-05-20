namespace System.IO.Compression;

internal struct Zip64EndOfCentralDirectoryLocator
{
	public uint NumberOfDiskWithZip64EOCD;

	public ulong OffsetOfZip64EOCD;

	public uint TotalNumberOfDisks;

	public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryLocator zip64EOCDLocator)
	{
		zip64EOCDLocator = default(Zip64EndOfCentralDirectoryLocator);
		return false;
	}

	public static void WriteBlock(Stream stream, long zip64EOCDRecordStart)
	{
	}
}
