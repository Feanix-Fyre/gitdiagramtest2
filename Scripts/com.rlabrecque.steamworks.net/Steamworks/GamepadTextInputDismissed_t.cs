using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 12)]
[CallbackIdentity(714)]
public struct GamepadTextInputDismissed_t
{
	public const int k_iCallback = 714;

	public bool m_bSubmitted;

	public uint m_unSubmittedText;

	public AppId_t m_unAppID;
}
