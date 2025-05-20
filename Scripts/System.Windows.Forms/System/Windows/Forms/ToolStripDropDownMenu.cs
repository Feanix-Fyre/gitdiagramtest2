using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms.Layout;

namespace System.Windows.Forms;

/// <summary>Provides basic functionality for the <see cref="T:System.Windows.Forms.ContextMenuStrip" /> control. Although <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" /> and <see cref="T:System.Windows.Forms.ToolStripDropDown" /> replace and add functionality to the <see cref="T:System.Windows.Forms.Menu" /> control of previous versions, <see cref="T:System.Windows.Forms.Menu" /> is retained for both backward compatibility and future use if you choose.</summary>
[Designer("System.Windows.Forms.Design.ToolStripDropDownDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class ToolStripDropDownMenu : ToolStripDropDown
{
	private ToolStripLayoutStyle layout_style;

	private bool show_check_margin;

	private bool show_image_margin;

	/// <summary>Gets the rectangle that represents the display area of the <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" />.</summary>
	/// <returns>A <see cref="T:System.Drawing.Rectangle" /> that represents the display area.</returns>
	public override Rectangle DisplayRectangle => default(Rectangle);

	/// <summary>Passes a reference to the cached <see cref="P:System.Windows.Forms.Control.LayoutEngine" /> returned by the layout engine interface.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Layout.LayoutEngine" /> that represents the cached layout engine returned by the layout engine interface.</returns>
	public override LayoutEngine LayoutEngine => null;

	/// <summary>Gets or sets a value indicating whether space for a check mark is shown on the left edge of the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the check margin is shown; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	[DefaultValue(false)]
	public bool ShowCheckMargin => false;

	/// <summary>Gets or sets a value indicating whether space for an image is shown on the left edge of the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the image margin is shown; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	[DefaultValue(true)]
	public bool ShowImageMargin => false;

	/// <summary>Gets the internal spacing, in pixels, of the control.</summary>
	/// <returns>A <see langword="Padding" /> object representing the spacing.</returns>
	protected override Padding DefaultPadding => default(Padding);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" /> class.</summary>
	public ToolStripDropDownMenu()
	{
	}

	/// <summary>Creates a default <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> with the specified text, image, and event handler on a new <see cref="T:System.Windows.Forms.ToolStripDropDownMenu" />.</summary>
	/// <param name="text">The text to use for the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />. If the <paramref name="text" /> parameter is a hyphen (-), this method creates a <see cref="T:System.Windows.Forms.ToolStripSeparator" />.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to display on the <see cref="T:System.Windows.Forms.ToolStripMenuItem" />.</param>
	/// <param name="onClick">An event handler that raises the <see cref="E:System.Windows.Forms.ToolStripItem.Click" /> event when the <see cref="T:System.Windows.Forms.ToolStripMenuItem" /> is clicked.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripMenuItem" />, or a <see cref="T:System.Windows.Forms.ToolStripSeparator" /> if the <paramref name="text" /> parameter is a hyphen (-).</returns>
	protected internal override ToolStripItem CreateDefaultItem(string text, Image image, EventHandler onClick)
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripDropDown.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Layout" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.LayoutEventArgs" /> that contains the event data.</param>
	protected override void OnLayout(LayoutEventArgs e)
	{
	}

	/// <summary>Paints the background of the control.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	/// <summary>Resets the collection of displayed and overflow items after a layout is done.</summary>
	protected override void SetDisplayedItems()
	{
	}

	internal override Rectangle CalculateConnectedArea()
	{
		return default(Rectangle);
	}
}
