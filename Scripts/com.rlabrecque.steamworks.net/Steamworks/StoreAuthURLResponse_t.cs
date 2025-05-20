using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 512)]
[CallbackIdentity(165)]
public struct StoreAuthURLResponse_t
{
	public const int k_iCallback = 165;

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
