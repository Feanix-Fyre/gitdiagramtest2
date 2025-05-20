using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 256)]
[CallbackIdentity(164)]
public struct GameWebCallback_t
{
	public const int k_iCallback = 164;

	private byte[] m_szURL_;

	public string m_szURL
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
