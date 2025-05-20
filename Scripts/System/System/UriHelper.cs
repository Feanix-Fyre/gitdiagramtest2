namespace System;

internal static class UriHelper
{
	private static readonly char[] HexUpperChars;

	internal unsafe static bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase)
	{
		return false;
	}

	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd)
	{
		return null;
	}

	private unsafe static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos)
	{
		return null;
	}

	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
	{
		return null;
	}

	internal unsafe static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery)
	{
		return null;
	}

	internal unsafe static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing)
	{
	}

	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos)
	{
	}

	internal static char EscapedAscii(char digit, char next)
	{
		return '\0';
	}

	internal static bool IsNotSafeForUnescape(char ch)
	{
		return false;
	}

	private static bool IsReservedUnreservedOrHash(char c)
	{
		return false;
	}

	internal static bool IsUnreserved(char c)
	{
		return false;
	}

	internal static bool Is3986Unreserved(char c)
	{
		return false;
	}
}
