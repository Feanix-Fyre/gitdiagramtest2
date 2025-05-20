using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 280)]
[CallbackIdentity(3401)]
public struct SteamUGCQueryCompleted_t
{
	public const int k_iCallback = 3401;

	public UGCQueryHandle_t m_handle;

	public EResult m_eResult;

	public uint m_unNumResultsReturned;

	public uint m_unTotalMatchingResults;

	public bool m_bCachedData;

	private byte[] m_rgchNextCursor_;

	public string m_rgchNextCursor
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
