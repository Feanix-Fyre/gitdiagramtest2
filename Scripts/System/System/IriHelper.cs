namespace System;

internal static class IriHelper
{
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery)
	{
		return false;
	}

	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery)
	{
		return false;
	}

	internal static bool CheckIsReserved(char ch, UriComponents component)
	{
		return false;
	}

	internal unsafe static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component)
	{
		return null;
	}
}
