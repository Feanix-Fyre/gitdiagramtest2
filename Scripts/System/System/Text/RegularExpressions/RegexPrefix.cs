namespace System.Text.RegularExpressions;

internal readonly struct RegexPrefix
{
	internal bool CaseInsensitive { get; }

	internal static RegexPrefix Empty { get; }

	internal string Prefix { get; }

	internal RegexPrefix(string prefix, bool ci)
	{
		CaseInsensitive = false;
		Prefix = null;
	}
}
