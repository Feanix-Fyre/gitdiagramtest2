using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexBoyerMoore
{
	public readonly int[] Positive;

	public readonly int[] NegativeASCII;

	public readonly int[][] NegativeUnicode;

	public readonly string Pattern;

	public readonly int LowASCII;

	public readonly int HighASCII;

	public readonly bool RightToLeft;

	public readonly bool CaseInsensitive;

	private readonly CultureInfo _culture;

	public RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture)
	{
	}

	private bool MatchPattern(string text, int index)
	{
		return false;
	}

	public bool IsMatch(string text, int index, int beglimit, int endlimit)
	{
		return false;
	}

	public int Scan(string text, int index, int beglimit, int endlimit)
	{
		return 0;
	}
}
