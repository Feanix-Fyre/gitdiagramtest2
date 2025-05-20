using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 40)]
[CallbackIdentity(2803)]
public struct SteamInputConfigurationLoaded_t
{
	public const int k_iCallback = 2803;

	public AppId_t m_unAppID;

	public InputHandle_t m_ulDeviceHandle;

	public CSteamID m_ulMappingCreator;

	public uint m_unMajorRevision;

	public uint m_unMinorRevision;

	public bool m_bUsesSteamInputAPI;

	public bool m_bUsesGamepadAPI;
}
