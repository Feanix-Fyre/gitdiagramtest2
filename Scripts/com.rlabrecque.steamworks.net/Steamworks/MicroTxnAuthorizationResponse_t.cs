using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 24)]
[CallbackIdentity(152)]
public struct MicroTxnAuthorizationResponse_t
{
	public const int k_iCallback = 152;

	public uint m_unAppID;

	public ulong m_ulOrderID;

	public byte m_bAuthorized;
}
