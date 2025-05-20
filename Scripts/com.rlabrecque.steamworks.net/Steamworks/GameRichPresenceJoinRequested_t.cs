using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 264)]
[CallbackIdentity(337)]
public struct GameRichPresenceJoinRequested_t
{
	public const int k_iCallback = 337;

	public CSteamID m_steamIDFriend;

	private byte[] m_rgchConnect_;

	public string m_rgchConnect
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
