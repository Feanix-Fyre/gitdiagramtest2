using System.Text;

namespace System.Net;

internal class IPAddressParser
{
	internal static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse)
	{
		return null;
	}

	internal static string IPv4AddressToString(uint address)
	{
		return null;
	}

	internal static void IPv4AddressToString(uint address, StringBuilder destination)
	{
	}

	private unsafe static int IPv4AddressToStringHelper(uint address, char* addressString)
	{
		return 0;
	}

	internal static string IPv6AddressToString(ushort[] address, uint scopeId)
	{
		return null;
	}

	internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId)
	{
		return null;
	}

	private unsafe static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset)
	{
	}

	public static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address)
	{
		address = default(long);
		return false;
	}

	public unsafe static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope)
	{
		scope = default(uint);
		return false;
	}

	private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer)
	{
	}

	private static void AppendHex(ushort value, StringBuilder buffer)
	{
	}

	private static uint ExtractIPv4Address(ushort[] address)
	{
		return 0u;
	}

	private static ushort Reverse(ushort number)
	{
		return 0;
	}
}
