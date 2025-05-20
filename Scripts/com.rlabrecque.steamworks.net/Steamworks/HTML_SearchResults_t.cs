using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 12)]
[CallbackIdentity(4509)]
public struct HTML_SearchResults_t
{
	public const int k_iCallback = 4509;

	public HHTMLBrowser unBrowserHandle;

	public uint unResults;

	public uint unCurrentMatch;
}
