using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 20)]
[CallbackIdentity(351)]
public struct EquippedProfileItems_t
{
	public const int k_iCallback = 351;

	public EResult m_eResult;

	public CSteamID m_steamID;

	public bool m_bHasAnimatedAvatar;

	public bool m_bHasAvatarFrame;

	public bool m_bHasProfileModifier;

	public bool m_bHasProfileBackground;

	public bool m_bHasMiniProfileBackground;
}
