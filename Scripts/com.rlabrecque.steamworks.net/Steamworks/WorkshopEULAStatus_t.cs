using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 20)]
[CallbackIdentity(3420)]
public struct WorkshopEULAStatus_t
{
	public const int k_iCallback = 3420;

	public EResult m_eResult;

	public AppId_t m_nAppID;

	public uint m_unVersion;

	public RTime32 m_rtAction;

	public bool m_bAccepted;

	public bool m_bNeedsAction;
}
