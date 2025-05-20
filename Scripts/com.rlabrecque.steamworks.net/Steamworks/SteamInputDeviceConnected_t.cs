using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
[CallbackIdentity(2801)]
public struct SteamInputDeviceConnected_t
{
	public const int k_iCallback = 2801;

	public InputHandle_t m_ulConnectedDeviceHandle;
}
