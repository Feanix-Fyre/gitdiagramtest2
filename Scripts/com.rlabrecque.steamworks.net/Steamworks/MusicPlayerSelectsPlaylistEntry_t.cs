using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout((LayoutKind)0, Pack = 8, Size = 4)]
[CallbackIdentity(4013)]
public struct MusicPlayerSelectsPlaylistEntry_t
{
	public const int k_iCallback = 4013;

	public int nID;
}
