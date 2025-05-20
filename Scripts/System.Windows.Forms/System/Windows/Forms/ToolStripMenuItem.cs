using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Windows.Forms.Design;

namespace System.Windows.Forms;

/// <summary>Represents a selectable option displayed on a <see cref="T:System.Windows.Forms.MenuStrip" /> or <see cref="T:System.Windows.Forms.ContextMenuStrip" />. Although <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> replaces and adds functionality to the <see cref="T:System.Windows.Forms.MenuItem" /> control of previous versions, <see cref="T:System.Windows.Forms.MenuItem" /> is retained for both backward compatibility and future use if you choose.</summary>
[DesignerSerializer("System.Windows.Forms.Design.ToolStripMenuItemCodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip | ToolStripItemDesignerAvailability.ContextMenuStrip)]
public class ToolStripMenuItem : ToolStripDropDownItem
{
	private CheckState checked_state;

	private bool check_on_click;

	private bool close_on_mouse_release;

	private string shortcut_display_string;

	private Keys shortcut_keys;

	private bool show_shortcut_keys;

	private Form mdi_client_form;

	private static object CheckedChangedEvent;

	private static object CheckStateChangedEvent;

	private static object UIACheckOnClickChangedEvent;

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> is checked.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> is checked or is in an indeterminate state; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[Bindable(true)]
	[RefreshProperties(RefreshProperties.All)]
	[DefaultValue(false)]
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

	/// <summary>Gets or sets a value indicating whether a <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> is in the checked, unchecked, or indeterminate state.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.CheckState" /> values. The default is <see langword="Unchecked" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The <see cref="P:System.Windows.Forms.ToolStripMenuItem.CheckState" /> property is not set to one of the <see cref="T:System.Windows.Forms.CheckState" /> values.</exception>
	[DefaultValue(CheckState.Unchecked)]
	[Bindable(true)]
	[RefreshProperties(RefreshProperties.All)]
	public CheckState CheckState
	{
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating whether the control is enabled.</summary>
	/// <returns>
	///   <see langword="true" /> if the control is enabled; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	public override bool Enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> appears on a multiple document interface (MDI) window list.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> appears on a MDI window list; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public bool IsMdiWindowListEntry => false;

	/// <summary>Gets or sets the shortcut keys associated with the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</summary>
	/// <returns>One of the <see cref="T:System.Windows.Forms.Keys" /> values. The default is <see cref="F:System.Windows.Forms.Keys.None" />.</returns>
	/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">The property was not set to one of the <see cref="T:System.Windows.Forms.Keys" /> values.</exception>
	[Localizable(true)]
	[DefaultValue(Keys.None)]
	public Keys ShortcutKeys
	{
		get
		{
			return default(Keys);
		}
		set
		{
		}
	}

	/// <summary>Gets the spacing between the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> and an adjacent item.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> value representing the spacing.</returns>
	protected internal override Padding DefaultMargin => default(Padding);

	/// <summary>Gets the internal spacing within the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> value representing the spacing.</returns>
	protected override Padding DefaultPadding => default(Padding);

	/// <summary>Gets the default size of the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</summary>
	/// <returns>The <see cref="T:System.Drawing.Size" /> of the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />, measured in pixels. The default is 100 pixels horizontally.</returns>
	protected override Size DefaultSize => default(Size);

	internal Form MdiClientForm
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> class.</summary>
	public ToolStripMenuItem()
		: base(null, null, null, null)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> class that displays the specified text and image and that does the specified action when the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> is clicked.</summary>
	/// <param name="text">The text to display on the menu item.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to display on the control.</param>
	/// <param name="onClick">An event handler that raises the <see cref="E:System.Windows.Forms.Control.Click" /> event when the control is clicked.</param>
	public ToolStripMenuItem(string text, Image image, EventHandler onClick)
		: base(null, null, null, null)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> class with the specified name that displays the specified text and image that does the specified action when the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> is clicked.</summary>
	/// <param name="text">The text to display on the menu item.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to display on the control.</param>
	/// <param name="onClick">An event handler that raises the <see cref="E:System.Windows.Forms.Control.Click" /> event when the control is clicked.</param>
	/// <param name="name">The name of the menu item.</param>
	public ToolStripMenuItem(string text, Image image, EventHandler onClick, string name)
		: base(null, null, null, null)
	{
	}

	/// <summary>Creates a generic <see cref="T:System.Windows.Forms.ToolStripDropDown" /> for which events can be defined.</summary>
	/// <returns>A generic <see cref="T:System.Windows.Forms.ToolStripDropDown" /> for which can be defined.</returns>
	protected override ToolStripDropDown CreateDefaultDropDown()
	{
		return null;
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripMenuItem.CheckedChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnCheckedChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripMenuItem.CheckStateChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnCheckStateChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnClick(EventArgs e)
	{
	}

	/// <summary>Raised in response to the <see cref="M:System.Windows.Forms.ToolStripDropDownItem.HideDropDown" /> method.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnDropDownHide(EventArgs e)
	{
	}

	/// <summary>Raised in response to the <see cref="M:System.Windows.Forms.ToolStripDropDownItem.ShowDropDown" /> method.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnDropDownShow(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseDown(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseEnter(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnMouseLeave(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.MouseUp" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
	protected override void OnMouseUp(MouseEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripItem.OwnerChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnOwnerChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnPaint(PaintEventArgs e)
	{
	}

	/// <summary>Processes a command key.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, which represents the window message to process.</param>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed by the control; otherwise, <see langword="false" />.</returns>
	protected internal override bool ProcessCmdKey(ref Message m, Keys keyData)
	{
		return false;
	}

	private Control GetTopLevelControl()
	{
		return null;
	}

	/// <summary>Processes a mnemonic character.</summary>
	/// <param name="charCode">The character to process.</param>
	/// <returns>
	///   <see langword="true" /> if the character was processed as a mnemonic by the control; otherwise, <see langword="false" />.</returns>
	protected internal override bool ProcessMnemonic(char charCode)
	{
		return false;
	}

	/// <summary>Sets the size and location of the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</summary>
	/// <param name="rect">A <see cref="T:System.Drawing.Rectangle" /> that represents the size and location of the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</param>
	protected internal override void SetBounds(Rectangle rect)
	{
	}

	internal override Size CalculatePreferredSize(Size constrainingSize)
	{
		return default(Size);
	}

	internal string GetShortcutDisplayString()
	{
		return null;
	}

	internal void HandleAutoExpansion()
	{
	}

	internal override void HandleClick(EventArgs e)
	{
	}
}
