using System.Collections.Generic;

namespace System.Globalization;

internal static class EncodingTable
{
	internal static InternalEncodingDataItem[] encodingDataPtr;

	internal static InternalCodePageDataItem[] codePageDataPtr;

	private static int lastEncodingItem;

	private static Dictionary<string, int> hashByName;

	private static Dictionary<int, CodePageDataItem> hashByCodePage;

	private static int GetNumEncodingItems()
	{
		return 0;
	}

	private static InternalEncodingDataItem ENC(string name, ushort cp)
	{
		return default(InternalEncodingDataItem);
	}

	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags)
	{
		return default(InternalCodePageDataItem);
	}

	static EncodingTable()
	{
	}

	private static int internalGetCodePageFromName(string name)
	{
		return 0;
	}

	internal static int GetCodePageFromName(string name)
	{
		return 0;
	}

	internal static CodePageDataItem GetCodePageDataItem(int codepage)
	{
		return null;
	}
}
