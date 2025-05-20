using System.Runtime.InteropServices;

namespace System.Windows.Forms;

[Serializable]
[StructLayout((LayoutKind)0)]
internal class XIMCallback
{
	public IntPtr client_data;

	public XIMProc callback;

	[NonSerialized]
	private GCHandle gch;

	public XIMCallback(IntPtr clientData, XIMProc proc)
	{
	}

	~XIMCallback()
	{
	}
}
