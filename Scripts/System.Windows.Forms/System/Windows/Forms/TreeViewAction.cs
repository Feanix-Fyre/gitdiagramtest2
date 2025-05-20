namespace System.Windows.Forms;

/// <summary>Specifies the action that raised a <see cref="T:System.Windows.Forms.TreeViewEventArgs" /> event.</summary>
public enum TreeViewAction
{
	/// <summary>The action that caused the event is unknown.</summary>
	Unknown = 0,
	/// <summary>The event was caused by a keystroke.</summary>
	ByKeyboard = 1,
	/// <summary>The event was caused by a mouse operation.</summary>
	ByMouse = 2,
	/// <summary>The event was caused by the <see cref="T:System.Windows.Forms.TreeNode" /> collapsing.</summary>
	Collapse = 3,
	/// <summary>The event was caused by the <see cref="T:System.Windows.Forms.TreeNode" /> expanding.</summary>
	Expand = 4
}
