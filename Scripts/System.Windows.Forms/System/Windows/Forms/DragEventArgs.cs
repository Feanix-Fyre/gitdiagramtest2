using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.DragDrop" />, <see cref="E:System.Windows.Forms.Control.DragEnter" />, or <see cref="E:System.Windows.Forms.Control.DragOver" /> event.</summary>
[ComVisible(true)]
public class DragEventArgs : EventArgs
{
	internal int x;

	internal int y;

	internal int keystate;

	internal DragDropEffects allowed_effect;

	internal DragDropEffects current_effect;

	internal IDataObject data_object;

	/// <summary>Gets which drag-and-drop operations are allowed by the originator (or source) of the drag event.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DragDropEffects" /> values.</returns>
	public DragDropEffects AllowedEffect => default(DragDropEffects);

	/// <summary>Gets the <see cref="T:System.Windows.Forms.IDataObject" /> that contains the data associated with this event.</summary>
	/// <returns>The data associated with this event.</returns>
	public IDataObject Data => null;

	/// <summary>Gets or sets the target drop effect in a drag-and-drop operation.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DragDropEffects" /> values.</returns>
	public DragDropEffects Effect => default(DragDropEffects);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DragEventArgs" /> class.</summary>
	/// <param name="data">The data associated with this event.</param>
	/// <param name="keyState">The current state of the SHIFT, CTRL, and ALT keys.</param>
	/// <param name="x">The x-coordinate of the mouse cursor in pixels.</param>
	/// <param name="y">The y-coordinate of the mouse cursor in pixels.</param>
	/// <param name="allowedEffect">One of the <see cref="T:System.Windows.Forms.DragDropEffects" /> values.</param>
	/// <param name="effect">One of the <see cref="T:System.Windows.Forms.DragDropEffects" /> values.</param>
	public DragEventArgs(IDataObject data, int keyState, int x, int y, DragDropEffects allowedEffect, DragDropEffects effect)
	{
	}
}
