using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 160)]
[CallbackIdentity(1223)]
public struct SteamNetworkingFakeIPResult_t
{
	public const int k_iCallback = 1223;

	public EResult m_eResult;

	public SteamNetworkingIdentity m_identity;

	public uint m_unIP;

	public ushort[] m_unPorts;
}
