namespace System.Net.NetworkInformation;

internal struct Win32_SOCKET_ADDRESS
{
	public IntPtr Sockaddr;

	public int SockaddrLength;

	public IPAddress GetIPAddress()
	{
		return null;
	}
}
