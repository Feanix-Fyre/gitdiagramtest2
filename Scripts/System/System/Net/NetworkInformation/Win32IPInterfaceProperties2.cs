namespace System.Net.NetworkInformation;

internal class Win32IPInterfaceProperties2 : IPInterfaceProperties
{
	private readonly Win32_IP_ADAPTER_ADDRESSES addr;

	private readonly Win32_MIB_IFROW mib4;

	private readonly Win32_MIB_IFROW mib6;

	public override GatewayIPAddressInformationCollection GatewayAddresses => null;

	public override UnicastIPAddressInformationCollection UnicastAddresses => null;

	public Win32IPInterfaceProperties2(Win32_IP_ADAPTER_ADDRESSES addr, Win32_MIB_IFROW mib4, Win32_MIB_IFROW mib6)
	{
	}

	private static UnicastIPAddressInformationCollection Win32FromUnicast(IntPtr ptr)
	{
		return null;
	}
}
