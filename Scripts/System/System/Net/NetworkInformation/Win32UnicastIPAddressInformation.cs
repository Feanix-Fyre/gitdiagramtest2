using System.Net.Sockets;

namespace System.Net.NetworkInformation;

internal class Win32UnicastIPAddressInformation : UnicastIPAddressInformation
{
	private Win32_IP_ADAPTER_UNICAST_ADDRESS info;

	private IPAddress ipv4Mask;

	public override IPAddress Address => null;

	public Win32UnicastIPAddressInformation(Win32_IP_ADAPTER_UNICAST_ADDRESS info)
	{
	}

	private static IPAddress PrefixLengthToSubnetMask(byte prefixLength, AddressFamily family)
	{
		return null;
	}
}
