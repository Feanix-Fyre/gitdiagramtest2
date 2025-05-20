namespace System.Net.NetworkInformation;

internal struct Win32_IP_ADDR_STRING
{
	public IntPtr Next;

	public string IpAddress;

	public string IpMask;

	public uint Context;
}
