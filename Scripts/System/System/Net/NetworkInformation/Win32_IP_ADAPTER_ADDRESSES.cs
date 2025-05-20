using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation;

[StructLayout((LayoutKind)0, CharSet = CharSet.Unicode)]
internal struct Win32_IP_ADAPTER_ADDRESSES
{
	public AlignmentUnion Alignment;

	public IntPtr Next;

	public string AdapterName;

	public IntPtr FirstUnicastAddress;

	public IntPtr FirstAnycastAddress;

	public IntPtr FirstMulticastAddress;

	public IntPtr FirstDnsServerAddress;

	public string DnsSuffix;

	public string Description;

	public string FriendlyName;

	public byte[] PhysicalAddress;

	public uint PhysicalAddressLength;

	public uint Flags;

	public uint Mtu;

	public NetworkInterfaceType IfType;

	public OperationalStatus OperStatus;

	public int Ipv6IfIndex;

	public uint[] ZoneIndices;

	public IntPtr FirstPrefix;

	public ulong TransmitLinkSpeed;

	public ulong ReceiveLinkSpeed;

	public IntPtr FirstWinsServerAddress;

	public IntPtr FirstGatewayAddress;

	public uint Ipv4Metric;

	public uint Ipv6Metric;

	public ulong Luid;

	public Win32_SOCKET_ADDRESS Dhcpv4Server;

	public uint CompartmentId;

	public ulong NetworkGuid;

	public int ConnectionType;

	public int TunnelType;

	public Win32_SOCKET_ADDRESS Dhcpv6Server;

	public byte[] Dhcpv6ClientDuid;

	public ulong Dhcpv6ClientDuidLength;

	public ulong Dhcpv6Iaid;

	public IntPtr FirstDnsSuffix;
}
