namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.ChangeUICues" /> event.</summary>
public class UICuesEventArgs : EventArgs
{
	private UICues cues;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.UICuesEventArgs" /> class with the specified <see cref="T:System.Windows.Forms.UICues" />.</summary>
	/// <param name="uicues">A bitwise combination of the <see cref="T:System.Windows.Forms.UICues" /> values.</param>
	public UICuesEventArgs(UICues uicues)
	{
	}
}
