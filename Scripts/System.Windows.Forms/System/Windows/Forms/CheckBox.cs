using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms;

/// <summary>Represents a Windows <see cref="T:System.Windows.Forms.CheckBox" />.</summary>
[DefaultProperty("Checked")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ToolboxItem("System.Windows.Forms.Design.AutoSizeToolboxItem,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ComVisible(true)]
[DefaultEvent("CheckedChanged")]
[DefaultBindingProperty("CheckState")]
public class CheckBox : ButtonBase
{
	internal Appearance appearance;

	internal bool auto_check;

	internal ContentAlignment check_alignment;

	internal CheckState check_state;

	internal bool three_state;

	private static object AppearanceChangedEvent;

	private static object CheckStateChangedEvent;

	private new EventHandler DoubleClick;

	/// <summary>Gets or sets the value that determines the appearance of a <see cref="T:System.Windows.Forms.CheckBox" /> control.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.Appearance" /> values. The default value is <see cref="F:System.Windows.Forms.Appearance.Normal" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.Appearance" /> values.</exception>
	[Localizable(true)]
	[DefaultValue(Appearance.Normal)]
	public Appearance Appearance => default(Appearance);

	/// <summary>Gets or sets the horizontal and vertical alignment of the check mark on a <see cref="T:System.Windows.Forms.CheckBox" /> control.</summary>
	/// <returns>One of the <see cref="T:System.Drawing.ContentAlignment" /> values. The default value is <see langword="MiddleLeft" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Drawing.ContentAlignment" /> enumeration values.</exception>
	[DefaultValue(ContentAlignment.MiddleLeft)]
	[Bindable(true)]
	[Localizable(true)]
	public ContentAlignment CheckAlign => default(ContentAlignment);

	/// <summary>Gets or set a value indicating whether the <see cref="T:System.Windows.Forms.CheckBox" /> is in the checked state.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.CheckBox" /> is in the checked state; otherwise, <see langword="false" />. The default value is <see langword="false" />.  
	///
	///  If the <see cref="P:System.Windows.Forms.CheckBox.ThreeState" /> property is set to <see langword="true" />, the <see cref="P:System.Windows.Forms.CheckBox.Checked" /> property will return <see langword="true" /> for either a <see langword="Checked" /> or <see langword="Indeterminate" /><see cref="P:System.Windows.Forms.CheckBox.CheckState" />.</returns>
	[Bindable(true)]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(false)]
	[SettingsBindable(true)]
	public bool Checked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the state of the <see cref="T:System.Windows.Forms.CheckBox" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.CheckState" /> enumeration values. The default value is <see langword="Unchecked" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The value assigned is not one of the <see cref="T:System.Windows.Forms.CheckState" /> enumeration values.</exception>
	[Bindable(true)]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(CheckState.Unchecked)]
	public CheckState CheckState
	{
		get
		{
			return default(CheckState);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the alignment of the text on the <see cref="T:System.Windows.Forms.CheckBox" /> control.</summary>
	/// <returns>One of the <see cref="T:System.Drawing.ContentAlignment" /> values. The default is <see cref="F:System.Drawing.ContentAlignment.MiddleLeft" />.</returns>
	[Localizable(true)]
	[DefaultValue(ContentAlignment.MiddleLeft)]
	public override ContentAlignment TextAlign
	{
		get
		{
			return default(ContentAlignment);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.CheckBox" /> will allow three check states rather than two.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.CheckBox" /> is able to display three check states; otherwise, <see langword="false" />. The default value is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool ThreeState => false;

	/// <summary>Gets the required creation parameters when the control handle is created.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation parameters when the handle to the control is created.</returns>
	protected override CreateParams CreateParams => null;

	/// <summary>Gets the default size of the control.</summary>
	/// <returns>The default size.</returns>
	protected override Size DefaultSize => default(Size);

	/// <summary>Occurs when the value of the <see cref="P:System.Windows.Forms.CheckBox.Checked" /> property changes.</summary>
	public event EventHandler CheckedChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.CheckBox" /> class.</summary>
	public CheckBox()
	{
	}

	internal override void Draw(PaintEventArgs pe)
	{
	}

	internal override Size GetPreferredSizeCore(Size proposedSize)
	{
		return default(Size);
	}

	internal override void HaveDoubleClick()
	{
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Windows.Forms.CheckBox" /> control.</summary>
	/// <returns>A string that states the control type and the state of the <see cref="P:System.Windows.Forms.CheckBox.CheckState" /> property.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.CheckBox.CheckedChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnCheckedChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.CheckBox.CheckStateChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnCheckStateChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Click" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnClick(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.HandleCreated" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnHandleCreated(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="M:System.Windows.Forms.ButtonBase.OnKeyUp(System.Windows.Forms.KeyEventArgs)" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.KeyEventArgs" /> that contains the event data.</param>
	protected override void OnKeyDown(KeyEventArgs e)
	{
	}

	/// <summary>Raises the OnMouseUp event.</summary>
	/// <param name="mevent">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseUp(MouseEventArgs mevent)
	{
	}

	/// <summary>Processes a mnemonic character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed as a mnemonic by the control; otherwise, <see langword="false" />.</returns>
	protected override bool ProcessMnemonic(char charCode)
	{
		return false;
	}
}
