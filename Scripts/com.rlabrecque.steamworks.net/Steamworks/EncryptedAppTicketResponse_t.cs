using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 4)]
[CallbackIdentity(154)]
public struct EncryptedAppTicketResponse_t
{
	public const int k_iCallback = 154;

	public EResult m_eResult;
}
