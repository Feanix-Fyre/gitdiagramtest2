using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

internal class Win32NetworkInterface
{
	private static Win32_FIXED_INFO fixedInfo;

	private static bool initialized;

	public static Win32_FIXED_INFO FixedInfo => default(Win32_FIXED_INFO);

	[PreserveSig]
	private static extern int GetNetworkParams(IntPtr ptr, ref int size);
}
