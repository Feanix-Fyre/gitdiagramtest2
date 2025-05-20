using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 4)]
[CallbackIdentity(3410)]
public struct StartPlaytimeTrackingResult_t
{
	public const int k_iCallback = 3410;

	public EResult m_eResult;
}
