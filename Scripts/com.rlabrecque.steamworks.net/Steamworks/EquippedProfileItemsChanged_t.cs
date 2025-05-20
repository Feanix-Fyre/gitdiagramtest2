using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
[CallbackIdentity(350)]
public struct EquippedProfileItemsChanged_t
{
	public const int k_iCallback = 350;

	public CSteamID m_steamID;
}
