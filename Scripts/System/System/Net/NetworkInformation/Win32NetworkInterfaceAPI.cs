using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal class Win32NetworkInterfaceAPI : NetworkInterfaceFactory
{
	[PreserveSig]
	private static extern int GetAdaptersAddresses(uint family, uint flags, IntPtr reserved, IntPtr info, ref int size);

	private static Win32_IP_ADAPTER_ADDRESSES[] GetAdaptersAddresses()
	{
		return null;
	}

	public override NetworkInterface[] GetAllNetworkInterfaces()
	{
		return null;
	}
}
