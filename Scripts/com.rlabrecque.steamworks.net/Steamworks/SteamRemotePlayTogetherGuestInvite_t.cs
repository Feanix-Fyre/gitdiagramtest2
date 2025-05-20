using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 1024)]
[CallbackIdentity(5703)]
public struct SteamRemotePlayTogetherGuestInvite_t
{
	public const int k_iCallback = 5703;

	private byte[] m_szConnectURL_;

	public string m_szConnectURL
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
