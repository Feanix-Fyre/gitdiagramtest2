using System.Collections;
using System.Collections.Generic;

namespace System.Text.RegularExpressions;

internal sealed class RegexReplacement
{
	private const int Specials = 4;

	public const int LeftPortion = -1;

	public const int RightPortion = -2;

	public const int LastGroup = -3;

	public const int WholeString = -4;

	private readonly List<string> _strings;

	private readonly List<int> _rules;

	public string Pattern { get; }

	public RegexReplacement(string rep, RegexNode concat, Hashtable _caps)
	{
	}

	public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions)
	{
		return null;
	}

	private void ReplacementImpl(StringBuilder sb, Match match)
	{
	}

	private void ReplacementImplRTL(List<string> al, Match match)
	{
	}

	public string Replace(Regex regex, string input, int count, int startat)
	{
		return null;
	}
}
