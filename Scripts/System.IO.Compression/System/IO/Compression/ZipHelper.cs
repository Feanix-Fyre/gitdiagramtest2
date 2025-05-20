namespace System.IO.Compression;

internal static class ZipHelper
{
	private static readonly DateTime s_invalidDateIndicator;

	internal static bool RequiresUnicode(string test)
	{
		return false;
	}

	internal static void ReadBytes(Stream stream, byte[] buffer, int bytesToRead)
	{
	}

	internal static DateTime DosTimeToDateTime(uint dateTime)
	{
		return default(DateTime);
	}

	internal static uint DateTimeToDosTime(DateTime dateTime)
	{
		return 0u;
	}

	internal static bool SeekBackwardsToSignature(Stream stream, uint signatureToFind)
	{
		return false;
	}

	internal static void AdvanceToPosition(this Stream stream, long position)
	{
	}

	private static bool SeekBackwardsAndRead(Stream stream, byte[] buffer, out int bufferPointer)
	{
		bufferPointer = default(int);
		return false;
	}
}
