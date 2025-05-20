namespace System;

internal static class IPv6AddressHelper
{
	internal static (int, int) FindCompressionRange(ReadOnlySpan<ushort> numbers)
	{
		return default((int, int));
	}

	internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<ushort> numbers)
	{
		return false;
	}

	internal unsafe static bool IsValidStrict(char* name, int start, ref int end)
	{
		return false;
	}

	internal unsafe static void Parse(ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId)
	{
	}

	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId)
	{
		return null;
	}

	private static bool IsLoopback(ReadOnlySpan<ushort> numbers)
	{
		return false;
	}

	private unsafe static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress)
	{
		return false;
	}

	internal unsafe static bool IsValid(char* name, int start, ref int end)
	{
		return false;
	}
}
