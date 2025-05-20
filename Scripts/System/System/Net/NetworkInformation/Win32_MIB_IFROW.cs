namespace System.Net.NetworkInformation;

internal struct Win32_MIB_IFROW
{
	public char[] Name;

	public int Index;

	public NetworkInterfaceType Type;

	public int Mtu;

	public uint Speed;

	public int PhysAddrLen;

	public byte[] PhysAddr;

	public uint AdminStatus;

	public uint OperStatus;

	public uint LastChange;

	public int InOctets;

	public int InUcastPkts;

	public int InNUcastPkts;

	public int InDiscards;

	public int InErrors;

	public int InUnknownProtos;

	public int OutOctets;

	public int OutUcastPkts;

	public int OutNUcastPkts;

	public int OutDiscards;

	public int OutErrors;

	public int OutQLen;

	public int DescrLen;

	public byte[] Descr;
}
