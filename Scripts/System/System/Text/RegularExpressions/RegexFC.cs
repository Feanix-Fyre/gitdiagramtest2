using System.Globalization;

namespace System.Text.RegularExpressions;

internal sealed class RegexFC
{
	private RegexCharClass _cc;

	public bool _nullable;

	public bool CaseInsensitive { get; private set; }

	public RegexFC(bool nullable)
	{
	}

	public RegexFC(char ch, bool not, bool nullable, bool caseInsensitive)
	{
	}

	public RegexFC(string charClass, bool nullable, bool caseInsensitive)
	{
	}

	public bool AddFC(RegexFC fc, bool concatenate)
	{
		return false;
	}

	public string GetFirstChars(CultureInfo culture)
	{
		return null;
	}
}
