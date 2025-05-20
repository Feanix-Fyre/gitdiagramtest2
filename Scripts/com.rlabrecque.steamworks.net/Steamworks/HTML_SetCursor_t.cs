using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 8)]
[CallbackIdentity(4522)]
public struct HTML_SetCursor_t
{
	public const int k_iCallback = 4522;

	public HHTMLBrowser unBrowserHandle;

	public uint eMouseCursor;
}
