using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 4)]
[CallbackIdentity(739)]
public struct FilterTextDictionaryChanged_t
{
	public const int k_iCallback = 739;

	public int m_eLanguage;
}
