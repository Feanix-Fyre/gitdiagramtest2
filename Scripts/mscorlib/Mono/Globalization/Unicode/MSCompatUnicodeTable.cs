using System;
using System.Globalization;

namespace Mono.Globalization.Unicode;

internal class MSCompatUnicodeTable
{
	public static int MaxExpansionLength;

	private unsafe static readonly byte* ignorableFlags;

	private unsafe static readonly byte* categories;

	private unsafe static readonly byte* level1;

	private unsafe static readonly byte* level2;

	private unsafe static readonly byte* level3;

	private unsafe static byte* cjkCHScategory;

	private unsafe static byte* cjkCHTcategory;

	private unsafe static byte* cjkJAcategory;

	private unsafe static byte* cjkKOcategory;

	private unsafe static byte* cjkCHSlv1;

	private unsafe static byte* cjkCHTlv1;

	private unsafe static byte* cjkJAlv1;

	private unsafe static byte* cjkKOlv1;

	private unsafe static byte* cjkKOlv2;

	private static readonly char[] tailoringArr;

	private static readonly TailoringInfo[] tailoringInfos;

	private static object forLock;

	public static readonly bool isReady;

	public static bool IsReady => false;

	public static TailoringInfo GetTailoringInfo(int lcid)
	{
		return null;
	}

	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals)
	{
	}

	private unsafe static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
	{
	}

	public static byte Category(int cp)
	{
		return 0;
	}

	public static byte Level1(int cp)
	{
		return 0;
	}

	public static byte Level2(int cp)
	{
		return 0;
	}

	public static byte Level3(int cp)
	{
		return 0;
	}

	public static bool IsIgnorable(int cp, byte flag)
	{
		return false;
	}

	public static bool IsIgnorableNonSpacing(int cp)
	{
		return false;
	}

	public static int ToKanaTypeInsensitive(int i)
	{
		return 0;
	}

	public static int ToWidthCompat(int i)
	{
		return 0;
	}

	public static bool HasSpecialWeight(char c)
	{
		return false;
	}

	public static bool IsHalfWidthKana(char c)
	{
		return false;
	}

	public static bool IsHiragana(char c)
	{
		return false;
	}

	public static bool IsJapaneseSmallLetter(char c)
	{
		return false;
	}

	private static IntPtr GetResource(string name)
	{
		return (IntPtr)0;
	}

	private unsafe static uint UInt32FromBytePtr(byte* raw, uint idx)
	{
		return 0u;
	}

	static MSCompatUnicodeTable()
	{
	}

	public unsafe static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
	{
	}

	private unsafe static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table)
	{
	}
}
