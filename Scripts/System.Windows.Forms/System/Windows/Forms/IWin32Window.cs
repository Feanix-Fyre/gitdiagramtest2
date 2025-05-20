using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides an interface to expose Win32 HWND handles.</summary>
[ComVisible(true)]
[Guid("458AB8A2-A1EA-4d7b-8EBE-DEE5D3D9442C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IWin32Window
{
	/// <summary>Gets the handle to the window represented by the implementer.</summary>
	/// <returns>A handle to the window represented by the implementer.</returns>
	IntPtr Handle { get; }
}
