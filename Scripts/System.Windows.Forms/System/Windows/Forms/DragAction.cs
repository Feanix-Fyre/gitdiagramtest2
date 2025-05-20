using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Specifies how and if a drag-and-drop operation should continue.</summary>
[ComVisible(true)]
public enum DragAction
{
	/// <summary>The operation will continue.</summary>
	Continue = 0,
	/// <summary>The operation will stop with a drop.</summary>
	Drop = 1,
	/// <summary>The operation is canceled with no drop message.</summary>
	Cancel = 2
}
