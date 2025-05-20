using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 64)]
public struct SteamNetConnectionRealTimeLaneStatus_t
{
	public int m_cbPendingUnreliable;

	public int m_cbPendingReliable;

	public int m_cbSentUnackedReliable;

	public int _reservePad1;

	public SteamNetworkingMicroseconds m_usecQueueTime;

	public uint[] reserved;
}
