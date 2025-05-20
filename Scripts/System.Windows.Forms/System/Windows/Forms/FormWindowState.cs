using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Specifies how a form window is displayed.</summary>
[ComVisible(true)]
public enum FormWindowState
{
	/// <summary>A default sized window.</summary>
	Normal = 0,
	/// <summary>A minimized window.</summary>
	Minimized = 1,
	/// <summary>A maximized window.</summary>
	Maximized = 2
}
