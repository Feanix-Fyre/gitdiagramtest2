using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.HelpRequested" /> event.</summary>
[ComVisible(true)]
public class HelpEventArgs : EventArgs
{
	private Point mouse_position;

	private bool event_handled;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.HelpEventArgs" /> class.</summary>
	/// <param name="mousePos">The coordinates of the mouse pointer.</param>
	public HelpEventArgs(Point mousePos)
	{
	}
}
