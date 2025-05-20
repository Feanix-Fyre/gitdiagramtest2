namespace System;

internal class DomainNameHelper
{
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback)
	{
		return null;
	}

	internal unsafe static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
	{
		return false;
	}

	internal unsafe static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
	{
		return false;
	}

	internal unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
	{
		return null;
	}

	internal unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost)
	{
		return null;
	}

	private static bool IsIdnAce(string input, int index)
	{
		return false;
	}

	private unsafe static bool IsIdnAce(char* input, int index)
	{
		return false;
	}

	internal unsafe static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end)
	{
		return null;
	}

	internal unsafe static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
	{
		return null;
	}

	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical)
	{
		return false;
	}

	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical)
	{
		return false;
	}
}
