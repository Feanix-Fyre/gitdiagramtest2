namespace System.IO.Enumeration;

public static class FileSystemName
{
	private static readonly char[] s_wildcardChars;

	private static readonly char[] s_simpleWildcardChars;

	public static string TranslateWin32Expression(string expression)
	{
		return null;
	}

	public static bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
	{
		return false;
	}

	public static bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = true)
	{
		return false;
	}

	private static bool MatchPattern(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards)
	{
		return false;
	}
}
