namespace System.IO.Compression;

internal static class FastEncoderStatics
{
	internal static readonly byte[] FastEncoderTreeStructureData;

	internal static readonly byte[] BFinalFastEncoderTreeStructureData;

	internal static readonly uint[] FastEncoderLiteralCodeInfo;

	internal static readonly uint[] FastEncoderDistanceCodeInfo;

	internal static readonly uint[] BitMask;

	internal static readonly byte[] ExtraLengthBits;

	internal static readonly byte[] ExtraDistanceBits;

	private static readonly byte[] s_distLookup;

	private static byte[] CreateDistanceLookup()
	{
		return null;
	}

	internal static int GetSlot(int pos)
	{
		return 0;
	}

	public static uint BitReverse(uint code, int length)
	{
		return 0u;
	}
}
