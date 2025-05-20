using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 128)]
[CallbackIdentity(332)]
public struct GameServerChangeRequested_t
{
	public const int k_iCallback = 332;

	private byte[] m_rgchServer_;

	private byte[] m_rgchPassword_;

	public string m_rgchServer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string m_rgchPassword
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
