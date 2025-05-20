using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.QueryContinueDrag" /> event.</summary>
[ComVisible(true)]
public class QueryContinueDragEventArgs : EventArgs
{
	internal int key_state;

	internal bool escape_pressed;

	internal DragAction drag_action;

	/// <summary>Gets or sets the status of a drag-and-drop operation.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.DragAction" /> value.</returns>
	public DragAction Action => default(DragAction);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.QueryContinueDragEventArgs" /> class.</summary>
	/// <param name="keyState">The current state of the SHIFT, CTRL, and ALT keys.</param>
	/// <param name="escapePressed">
	///   <see langword="true" /> if the ESC key was pressed; otherwise, <see langword="false" />.</param>
	/// <param name="action">A <see cref="T:System.Windows.Forms.DragAction" /> value.</param>
	public QueryContinueDragEventArgs(int keyState, bool escapePressed, DragAction action)
	{
	}
}
