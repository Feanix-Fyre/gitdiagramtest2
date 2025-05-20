using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
[CallbackIdentity(4624)]
public struct GetOPFSettingsResult_t
{
	public const int k_iCallback = 4624;

	public EResult m_eResult;

	public AppId_t m_unVideoAppID;
}
