using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.IO.Compression;

[StructLayout((LayoutKind)0, Size = 1)]
internal readonly struct ZipLocalFileHeader
{
	public static List<ZipGenericExtraField> GetExtraFields(BinaryReader reader)
	{
		return null;
	}

	public static bool TrySkipBlock(BinaryReader reader)
	{
		return false;
	}
}
