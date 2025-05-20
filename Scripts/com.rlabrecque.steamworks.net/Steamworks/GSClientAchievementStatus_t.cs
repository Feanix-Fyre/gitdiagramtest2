using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 144)]
[CallbackIdentity(206)]
public struct GSClientAchievementStatus_t
{
	public const int k_iCallback = 206;

	public ulong m_SteamID;

	private byte[] m_pchAchievement_;

	public bool m_bUnlocked;

	public string m_pchAchievement
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
