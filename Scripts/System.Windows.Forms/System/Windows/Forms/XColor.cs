using System.Runtime.InteropServices;

namespace System.Windows.Forms;

[StructLayout((LayoutKind)0, Pack = 2, Size = 16)]
internal struct XColor
{
	internal IntPtr pixel;

	internal ushort red;

	internal ushort green;

	internal ushort blue;

	internal byte flags;

	internal byte pad;
}
