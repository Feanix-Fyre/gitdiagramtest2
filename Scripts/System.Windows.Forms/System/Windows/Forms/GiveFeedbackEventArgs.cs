using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.GiveFeedback" /> event, which occurs during a drag operation.</summary>
[ComVisible(true)]
public class GiveFeedbackEventArgs : EventArgs
{
	internal DragDropEffects effect;

	internal bool use_default_cursors;

	/// <summary>Gets or sets whether drag operation should use the default cursors that are associated with drag-drop effects.</summary>
	/// <returns>
	///   <see langword="true" /> if the default pointers are used; otherwise, <see langword="false" />.</returns>
	public bool UseDefaultCursors => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.GiveFeedbackEventArgs" /> class.</summary>
	/// <param name="effect">The type of drag-and-drop operation. Possible values are obtained by applying the bitwise OR (|) operation to the constants defined in the <see cref="T:System.Windows.Forms.DragDropEffects" />.</param>
	/// <param name="useDefaultCursors">
	///   <see langword="true" /> if default pointers are used; otherwise, <see langword="false" />.</param>
	public GiveFeedbackEventArgs(DragDropEffects effect, bool useDefaultCursors)
	{
	}
}
