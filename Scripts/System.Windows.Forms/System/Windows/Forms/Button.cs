using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a Windows button control.</summary>
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Designer("System.Windows.Forms.Design.ButtonBaseDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
public class Button : ButtonBase, IButtonControl
{
	private DialogResult dialog_result;

	/// <summary>Gets or sets a value that is returned to the parent form when the button is clicked.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.DialogResult" /> values. The default value is <see langword="None" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.DialogResult" /> values.</exception>
	[MWFCategory("Behavior")]
	[DefaultValue(DialogResult.None)]
	public virtual DialogResult DialogResult
	{
		get
		{
			return default(DialogResult);
		}
		set
		{
		}
	}

	/// <summary>Gets a <see cref="T:System.Windows.Forms.CreateParams" /> on the base class when creating a window.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> object on the base class when creating a window.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.Button" /> class.</summary>
	public Button()
	{
	}

	/// <summary>Notifies the <see cref="T:System.Windows.Forms.Button" /> whether it is the default button so that it can adjust its appearance accordingly.</summary>
	/// <param name="value">
	///   <see langword="true" /> if the button is to have the appearance of the default button; otherwise, <see langword="false" />.</param>
	public virtual void NotifyDefault(bool value)
	{
	}

	/// <summary>Generates a <see cref="E:System.Windows.Forms.Control.Click" /> event for a button.</summary>
	public void PerformClick()
	{
	}

	/// <summary>Returns a <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any. This method should not be overridden.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the name of the <see cref="T:System.ComponentModel.Component" />, if any, or <see langword="null" /> if the <see cref="T:System.ComponentModel.Component" /> is unnamed.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Click" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnClick(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.Control.OnMouseEnter(System.EventArgs)" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseEnter(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.Control.OnMouseLeave(System.EventArgs)" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.ButtonBase.OnMouseUp(System.Windows.Forms.MouseEventArgs)" /> event.</summary>
	/// <param name="mevent">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseUp(MouseEventArgs mevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnTextChanged(EventArgs e)
	{
	}

	/// <summary>Processes a mnemonic character.</summary>
	/// <param name="charCode">The mnemonic character entered.</param>
	/// <returns>
	///   <see langword="true" /> if the mnemonic was processed; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessMnemonic(char charCode)
	{
		return false;
	}

	/// <summary>Processes Windows messages.</summary>
	/// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
	protected override void WndProc(ref Message m)
	{
	}

	internal override void Draw(PaintEventArgs pevent)
	{
	}

	internal override Size GetPreferredSizeCore(Size proposedSize)
	{
		return default(Size);
	}
}
