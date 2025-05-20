using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.KeyPress" /> event.</summary>
[ComVisible(true)]
public class KeyPressEventArgs : EventArgs
{
	private char key_char;

	private bool event_handled;

	/// <summary>Gets or sets a value indicating whether the <see cref="E:System.Windows.Forms.Control.KeyPress" /> event was handled.</summary>
	/// <returns>
	///   <see langword="true" /> if the event is handled; otherwise, <see langword="false" />.</returns>
	public bool Handled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the character corresponding to the key pressed.</summary>
	/// <returns>The ASCII character that is composed. For example, if the user presses SHIFT + K, this property returns an uppercase K.</returns>
	public char KeyChar => '\0';

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.KeyPressEventArgs" /> class.</summary>
	/// <param name="keyChar">The ASCII character corresponding to the key the user pressed.</param>
	public KeyPressEventArgs(char keyChar)
	{
	}
}
