using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 32)]
[CallbackIdentity(3405)]
public struct ItemInstalled_t
{
	public const int k_iCallback = 3405;

	public AppId_t m_unAppID;

	public PublishedFileId_t m_nPublishedFileId;

	public UGCHandle_t m_hLegacyContent;

	public ulong m_unManifestID;
}
