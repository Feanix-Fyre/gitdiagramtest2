using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 16)]
[CallbackIdentity(4514)]
public struct HTML_JSAlert_t
{
	public const int k_iCallback = 4514;

	public HHTMLBrowser unBrowserHandle;

	public string pchMessage;
}
