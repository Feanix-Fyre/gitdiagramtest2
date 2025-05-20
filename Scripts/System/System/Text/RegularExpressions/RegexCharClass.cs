using System.Collections.Generic;
using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexCharClass
{
	private readonly struct LowerCaseMapping
	{
		public readonly char ChMin;

		public readonly char ChMax;

		public readonly int LcOp;

		public readonly int Data;

		internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
		{
			ChMin = '\0';
			ChMax = '\0';
			LcOp = 0;
			Data = 0;
		}
	}

	private sealed class SingleRangeComparer : IComparer<SingleRange>
	{
		public static readonly SingleRangeComparer Instance;

		private SingleRangeComparer()
		{
		}

		public int Compare(SingleRange x, SingleRange y)
		{
			return 0;
		}
	}

	private readonly struct SingleRange
	{
		public readonly char First;

		public readonly char Last;

		internal SingleRange(char first, char last)
		{
			First = '\0';
			Last = '\0';
		}
	}

	private static readonly string s_internalRegexIgnoreCase;

	private static readonly string s_space;

	private static readonly string s_notSpace;

	private static readonly string s_word;

	private static readonly string s_notWord;

	public static readonly string SpaceClass;

	public static readonly string NotSpaceClass;

	public static readonly string WordClass;

	public static readonly string NotWordClass;

	public static readonly string DigitClass;

	public static readonly string NotDigitClass;

	private static readonly Dictionary<string, string> s_definedCategories;

	private static readonly string[][] s_propTable;

	private static readonly LowerCaseMapping[] s_lcTable;

	private List<SingleRange> _rangelist;

	private StringBuilder _categories;

	private bool _canonical;

	private bool _negate;

	private RegexCharClass _subtractor;

	public bool CanMerge => false;

	public bool Negate
	{
		set
		{
		}
	}

	public RegexCharClass()
	{
	}

	private RegexCharClass(bool negate, List<SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
	{
	}

	public void AddChar(char c)
	{
	}

	public void AddCharClass(RegexCharClass cc)
	{
	}

	private void AddSet(string set)
	{
	}

	public void AddSubtraction(RegexCharClass sub)
	{
	}

	public void AddRange(char first, char last)
	{
	}

	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
	{
	}

	private void AddCategory(string category)
	{
	}

	public void AddLowercase(CultureInfo culture)
	{
	}

	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
	{
	}

	public void AddWord(bool ecma, bool negate)
	{
	}

	public void AddSpace(bool ecma, bool negate)
	{
	}

	public void AddDigit(bool ecma, bool negate, string pattern)
	{
	}

	public static char SingletonChar(string set)
	{
		return '\0';
	}

	public static bool IsMergeable(string charClass)
	{
		return false;
	}

	public static bool IsEmpty(string charClass)
	{
		return false;
	}

	public static bool IsSingleton(string set)
	{
		return false;
	}

	public static bool IsSingletonInverse(string set)
	{
		return false;
	}

	private static bool IsSubtraction(string charClass)
	{
		return false;
	}

	private static bool IsNegated(string set)
	{
		return false;
	}

	public static bool IsECMAWordChar(char ch)
	{
		return false;
	}

	public static bool IsWordChar(char ch)
	{
		return false;
	}

	public static bool CharInClass(char ch, string set)
	{
		return false;
	}

	private static bool CharInClassRecursive(char ch, string set, int start)
	{
		return false;
	}

	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
	{
		return false;
	}

	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
	{
		return false;
	}

	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i)
	{
		return false;
	}

	private static string NegateCategory(string category)
	{
		return null;
	}

	public static RegexCharClass Parse(string charClass)
	{
		return null;
	}

	private static RegexCharClass ParseRecursive(string charClass, int start)
	{
		return null;
	}

	private int RangeCount()
	{
		return 0;
	}

	public string ToStringClass()
	{
		return null;
	}

	private SingleRange GetRangeAt(int i)
	{
		return default(SingleRange);
	}

	private void Canonicalize()
	{
	}

	private static string SetFromProperty(string capname, bool invert, string pattern)
	{
		return null;
	}
}
