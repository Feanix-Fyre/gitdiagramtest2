using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal sealed class Win32NetworkInterface2 : NetworkInterface
{
	private Win32_IP_ADAPTER_ADDRESSES addr;

	private Win32_MIB_IFROW mib4;

	private Win32_MIB_IFROW mib6;

	private Win32IPv4InterfaceStatistics ip4stats;

	private IPInterfaceProperties ip_if_props;

	public override NetworkInterfaceType NetworkInterfaceType => default(NetworkInterfaceType);

	public override OperationalStatus OperationalStatus => default(OperationalStatus);

	[PreserveSig]
	private static extern int GetIfEntry(ref Win32_MIB_IFROW row);

	internal Win32NetworkInterface2(Win32_IP_ADAPTER_ADDRESSES addr)
	{
	}

	public override IPInterfaceProperties GetIPProperties()
	{
		return null;
	}
}
