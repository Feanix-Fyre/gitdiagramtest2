using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 2572)]
[CallbackIdentity(168)]
public struct GetTicketForWebApiResponse_t
{
	public const int k_iCallback = 168;

	public HAuthTicket m_hAuthTicket;

	public EResult m_eResult;

	public int m_cubTicket;

	public byte[] m_rgubTicket;
}
