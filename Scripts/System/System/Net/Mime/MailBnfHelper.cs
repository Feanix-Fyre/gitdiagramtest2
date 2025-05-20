namespace System.Net.Mime;

internal static class MailBnfHelper
{
	internal static readonly bool[] Atext;

	internal static readonly bool[] Qtext;

	internal static readonly bool[] Dtext;

	internal static readonly bool[] Ftext;

	internal static readonly bool[] Ttext;

	internal static readonly bool[] Ctext;

	internal static readonly int Ascii7bitMaxValue;

	internal static readonly char Quote;

	internal static readonly char Space;

	internal static readonly char Tab;

	internal static readonly char CR;

	internal static readonly char LF;

	internal static readonly char StartComment;

	internal static readonly char EndComment;

	internal static readonly char Backslash;

	internal static readonly char At;

	internal static readonly char EndAngleBracket;

	internal static readonly char StartAngleBracket;

	internal static readonly char StartSquareBracket;

	internal static readonly char EndSquareBracket;

	internal static readonly char Comma;

	internal static readonly char Dot;

	private static readonly char[] s_colonSeparator;

	private static string[] s_months;

	private static bool[] CreateCharactersAllowedInAtoms()
	{
		return null;
	}

	private static bool[] CreateCharactersAllowedInQuotedStrings()
	{
		return null;
	}

	private static bool[] CreateCharactersAllowedInDomainLiterals()
	{
		return null;
	}

	private static bool[] CreateCharactersAllowedInHeaderNames()
	{
		return null;
	}

	private static bool[] CreateCharactersAllowedInTokens()
	{
		return null;
	}

	private static bool[] CreateCharactersAllowedInComments()
	{
		return null;
	}

	internal static bool IsAllowedWhiteSpace(char c)
	{
		return false;
	}
}
