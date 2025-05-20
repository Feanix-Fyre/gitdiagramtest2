using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 264)]
[CallbackIdentity(4611)]
public struct GetVideoURLResult_t
{
	public const int k_iCallback = 4611;

	public EResult m_eResult;

	public AppId_t m_unVideoAppID;

	private byte[] m_rgchURL_;

	public string m_rgchURL
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
