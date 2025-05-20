using System.Globalization;

namespace Mono.Globalization.Unicode;

internal class SimpleCollator : ISimpleCollator
{
	internal struct Context
	{
		public readonly CompareOptions Option;

		public unsafe readonly byte* NeverMatchFlags;

		public unsafe readonly byte* AlwaysMatchFlags;

		public unsafe byte* Buffer1;

		public unsafe byte* Buffer2;

		public int PrevCode;

		public unsafe byte* PrevSortKey;

		public unsafe Context(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1)
		{
			Option = default(CompareOptions);
			NeverMatchFlags = null;
			AlwaysMatchFlags = null;
			Buffer1 = null;
			Buffer2 = null;
			PrevCode = 0;
			PrevSortKey = null;
		}
	}

	private struct PreviousInfo
	{
		public int Code;

		public unsafe byte* SortKey;

		public unsafe PreviousInfo(bool dummy)
		{
			Code = 0;
			SortKey = null;
		}
	}

	private struct Escape
	{
		public string Source;

		public int Index;

		public int Start;

		public int End;

		public int Optional;
	}

	private enum ExtenderType
	{
		None = 0,
		Simple = 1,
		Voiced = 2,
		Conditional = 3,
		Buggy = 4
	}

	private static SimpleCollator invariant;

	private readonly TextInfo textInfo;

	private readonly CodePointIndexer cjkIndexer;

	private readonly Contraction[] contractions;

	private readonly Level2Map[] level2Maps;

	private readonly byte[] unsafeFlags;

	private unsafe readonly byte* cjkCatTable;

	private unsafe readonly byte* cjkLv1Table;

	private unsafe readonly byte* cjkLv2Table;

	private readonly CodePointIndexer cjkLv2Indexer;

	private readonly int lcid;

	private readonly bool frenchSort;

	public SimpleCollator(CultureInfo culture)
	{
	}

	private unsafe void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table)
	{
	}

	private static CultureInfo GetNeutralCulture(CultureInfo info)
	{
		return null;
	}

	private byte Category(int cp)
	{
		return 0;
	}

	private byte Level1(int cp)
	{
		return 0;
	}

	private byte Level2(int cp, ExtenderType ext)
	{
		return 0;
	}

	private static bool IsHalfKana(int cp, CompareOptions opt)
	{
		return false;
	}

	private Contraction GetContraction(string s, int start, int end)
	{
		return null;
	}

	private Contraction GetContraction(string s, int start, int end, Contraction[] clist)
	{
		return null;
	}

	private Contraction GetTailContraction(string s, int start, int end)
	{
		return null;
	}

	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist)
	{
		return null;
	}

	private int FilterOptions(int i, CompareOptions opt)
	{
		return 0;
	}

	private ExtenderType GetExtenderType(int i)
	{
		return default(ExtenderType);
	}

	private static byte ToDashTypeValue(ExtenderType ext, CompareOptions opt)
	{
		return 0;
	}

	private int FilterExtender(int i, ExtenderType ext, CompareOptions opt)
	{
		return 0;
	}

	private static bool IsIgnorable(int i, CompareOptions opt)
	{
		return false;
	}

	private bool IsSafe(int i)
	{
		return false;
	}

	public SortKey GetSortKey(string s, CompareOptions options)
	{
		return null;
	}

	public SortKey GetSortKey(string s, int start, int length, CompareOptions options)
	{
		return null;
	}

	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt)
	{
	}

	private void FillSortKeyRaw(int i, ExtenderType ext, SortKeyBuffer buf, CompareOptions opt)
	{
	}

	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf)
	{
	}

	int ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
	{
		return 0;
	}

	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options)
	{
		return 0;
	}

	private unsafe void ClearBuffer(byte* buffer, int size)
	{
	}

	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref Context ctx)
	{
		targetConsumed = default(bool);
		sourceConsumed = default(bool);
		return 0;
	}

	private int CompareFlagPair(bool b1, bool b2)
	{
		return 0;
	}

	public bool IsPrefix(string src, string target, CompareOptions opt)
	{
		return false;
	}

	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt)
	{
		return false;
	}

	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref Context ctx)
	{
		return false;
	}

	public bool IsSuffix(string src, string target, CompareOptions opt)
	{
		return false;
	}

	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt)
	{
		return false;
	}

	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable)
	{
		testWasUnable = default(bool);
		return 0;
	}

	public int IndexOf(string s, string target, int start, int length, CompareOptions opt)
	{
		return 0;
	}

	private int IndexOfOrdinal(string s, string target, int start, int length)
	{
		return 0;
	}

	private int IndexOfOrdinal(string s, char target, int start, int length)
	{
		return 0;
	}

	private unsafe int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref Context ctx)
	{
		return 0;
	}

	private unsafe int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref Context ctx)
	{
		return 0;
	}

	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt)
	{
		return 0;
	}

	private int LastIndexOfOrdinal(string s, string target, int start, int length)
	{
		return 0;
	}

	private unsafe int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref Context ctx)
	{
		return 0;
	}

	private unsafe int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref Context ctx)
	{
		return 0;
	}

	private unsafe bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref Context ctx)
	{
		return false;
	}

	private unsafe bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx)
	{
		return false;
	}

	private unsafe bool MatchesPrimitive(CompareOptions opt, byte* source, int si, ExtenderType ext, byte* target, int ti, bool noLv4)
	{
		return false;
	}

	private unsafe bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref Context ctx)
	{
		return false;
	}

	private unsafe bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx)
	{
		return false;
	}
}
