namespace System;

internal static class IPv4AddressHelper
{
	internal static int ParseHostNumber(ReadOnlySpan<char> str, int start, int end)
	{
		return 0;
	}

	internal unsafe static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme)
	{
		return false;
	}

	private unsafe static bool ParseCanonical(ReadOnlySpan<char> name, byte* numbers, int start, int end)
	{
		return false;
	}

	internal unsafe static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile)
	{
		return false;
	}

	internal unsafe static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile)
	{
		return 0L;
	}

	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback)
	{
		return null;
	}

	private unsafe static bool Parse(string name, byte* numbers, int start, int end)
	{
		return false;
	}
}
