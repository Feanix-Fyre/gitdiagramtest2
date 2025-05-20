using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.Control.KeyDown" /> or <see cref="E:System.Windows.Forms.Control.KeyUp" /> event.</summary>
[ComVisible(true)]
public class KeyEventArgs : EventArgs
{
	private Keys key_data;

	private bool event_handled;

	private bool supress_key_press;

	/// <summary>Gets a value indicating whether the ALT key was pressed.</summary>
	/// <returns>
	///   <see langword="true" /> if the ALT key was pressed; otherwise, <see langword="false" />.</returns>
	public virtual bool Alt => false;

	/// <summary>Gets a value indicating whether the CTRL key was pressed.</summary>
	/// <returns>
	///   <see langword="true" /> if the CTRL key was pressed; otherwise, <see langword="false" />.</returns>
	public bool Control => false;

	/// <summary>Gets or sets a value indicating whether the event was handled.</summary>
	/// <returns>
	///   <see langword="true" /> to bypass the control's default handling; otherwise, <see langword="false" /> to also pass the event along to the default control handler.</returns>
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

	/// <summary>Gets the keyboard code for a <see cref="E:System.Windows.Forms.Control.KeyDown" /> or <see cref="E:System.Windows.Forms.Control.KeyUp" /> event.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Keys" /> value that is the key code for the event.</returns>
	public Keys KeyCode => default(Keys);

	/// <summary>Gets the key data for a <see cref="E:System.Windows.Forms.Control.KeyDown" /> or <see cref="E:System.Windows.Forms.Control.KeyUp" /> event.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Keys" /> representing the key code for the key that was pressed, combined with modifier flags that indicate which combination of CTRL, SHIFT, and ALT keys was pressed at the same time.</returns>
	public Keys KeyData => default(Keys);

	/// <summary>Gets the modifier flags for a <see cref="E:System.Windows.Forms.Control.KeyDown" /> or <see cref="E:System.Windows.Forms.Control.KeyUp" /> event. The flags indicate which combination of CTRL, SHIFT, and ALT keys was pressed.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Keys" /> value representing one or more modifier flags.</returns>
	public Keys Modifiers => default(Keys);

	/// <summary>Gets or sets a value indicating whether the key event should be passed on to the underlying control.</summary>
	/// <returns>
	///   <see langword="true" /> if the key event should not be sent to the control; otherwise, <see langword="false" />.</returns>
	public bool SuppressKeyPress => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.KeyEventArgs" /> class.</summary>
	/// <param name="keyData">A <see cref="T:System.Windows.Forms.Keys" /> representing the key that was pressed, combined with any modifier flags that indicate which CTRL, SHIFT, and ALT keys were pressed at the same time. Possible values are obtained be applying the bitwise OR (|) operator to constants from the <see cref="T:System.Windows.Forms.Keys" /> enumeration.</param>
	public KeyEventArgs(Keys keyData)
	{
	}
}
