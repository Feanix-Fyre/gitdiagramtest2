using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides basic functionality for controls that display a <see cref="T:System.Windows.Forms.ToolStripDropDown" /> when a <see cref="T:System.Windows.Forms.ToolStripDropDownButton" />, <see cref="T:System.Windows.Forms.ToolStripMenuItem" />, or <see cref="T:System.Windows.Forms.ToolStripSplitButton" /> control is clicked.</summary>
[Designer("System.Windows.Forms.Design.ToolStripMenuItemDesigner, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.IDesigner")]
[DefaultProperty("DropDownItems")]
public abstract class ToolStripDropDownItem : ToolStripItem
{
	internal ToolStripDropDown drop_down;

	private static object DropDownClosedEvent;

	private static object DropDownItemClickedEvent;

	private static object DropDownOpenedEvent;

	private static object DropDownOpeningEvent;

	/// <summary>Gets or sets the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> that will be displayed when this <see cref="T:System.Windows.Forms.ToolStripDropDownItem" /> is clicked.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripDropDown" /> that is associated with the <see cref="T:System.Windows.Forms.ToolStripDropDownItem" />.</returns>
	[TypeConverter(typeof(ReferenceConverter))]
	public ToolStripDropDown DropDown => null;

	/// <summary>Gets the collection of items in the <see cref="T:System.Windows.Forms.ToolStripDropDown" /> that is associated with this <see cref="T:System.Windows.Forms.ToolStripDropDownItem" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> of controls.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public ToolStripItemCollection DropDownItems => null;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ToolStripDropDownItem" /> has <see cref="T:System.Windows.Forms.ToolStripDropDown" /> controls associated with it.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripDropDownItem" /> has <see cref="T:System.Windows.Forms.ToolStripDropDown" /> controls; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	public virtual bool HasDropDownItems => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ToolStripDropDownItem" /> is in the pressed state.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripDropDownItem" /> is in the pressed state; otherwise, <see langword="false" />.</returns>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public override bool Pressed => false;

	/// <summary>Gets the screen coordinates, in pixels, of the upper-left corner of the <see cref="T:System.Windows.Forms.ToolStripDropDownItem" />.</summary>
	/// <returns>A <see langword="Point" /> representing the x and y screen coordinates, in pixels.</returns>
	protected internal virtual Point DropDownLocation => default(Point);

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripDropDownItem" /> class with the specified display text, image, action to take when the drop-down control is clicked, and control name.</summary>
	/// <param name="text">The display text of the drop-down control.</param>
	/// <param name="image">The <see cref="T:System.Drawing.Image" /> to be displayed on the control.</param>
	/// <param name="onClick">The action to take when the drop-down control is clicked.</param>
	/// <param name="name">The name of the control.</param>
	protected ToolStripDropDownItem(string text, Image image, EventHandler onClick, string name)
	{
	}

	/// <summary>Makes a visible <see cref="T:System.Windows.Forms.ToolStripDropDown" /> hidden.</summary>
	public void HideDropDown()
	{
	}

	/// <summary>Displays the <see cref="T:System.Windows.Forms.ToolStripDropDownItem" /> control associated with this <see cref="T:System.Windows.Forms.ToolStripDropDownItem" />.</summary>
	/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Windows.Forms.ToolStripDropDownItem" /> is the same as the parent <see cref="T:System.Windows.Forms.ToolStrip" />.</exception>
	public void ShowDropDown()
	{
	}

	/// <summary>Creates a generic <see cref="T:System.Windows.Forms.ToolStripDropDown" /> for which events can be defined.</summary>
	/// <returns>The created <see cref="T:System.Windows.Forms.ToolStripDropDown" /> object.</returns>
	protected virtual ToolStripDropDown CreateDefaultDropDown()
	{
		return null;
	}

	/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Windows.Forms.ToolStripDropDownItem" /> and optionally releases the managed resources.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	/// <summary>Occurs when the <see cref="P:System.Windows.Forms.ToolStripItem.Bounds" /> property changes.</summary>
	protected override void OnBoundsChanged()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripDropDownItem.DropDownClosed" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected internal virtual void OnDropDownClosed(EventArgs e)
	{
	}

	/// <summary>Raised in response to the <see cref="M:System.Windows.Forms.ToolStripDropDownItem.HideDropDown" /> method.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnDropDownHide(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripDropDownItem.DropDownItemClicked" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.ToolStripItemClickedEventArgs" /> that contains the event data.</param>
	protected internal virtual void OnDropDownItemClicked(ToolStripItemClickedEventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripDropDownItem.DropDownOpened" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected internal virtual void OnDropDownOpened(EventArgs e)
	{
	}

	/// <summary>Raised in response to the <see cref="M:System.Windows.Forms.ToolStripDropDownItem.ShowDropDown" /> method.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected virtual void OnDropDownShow(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.ToolStripDropDown.FontChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnFontChanged(EventArgs e)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.RightToLeftChanged" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnRightToLeftChanged(EventArgs e)
	{
	}

	/// <summary>Processes a command key.</summary>
	/// <param name="m">A <see cref="T:System.Windows.Forms.Message" />, passed by reference, that represents the window message to process.</param>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	protected internal override bool ProcessCmdKey(ref Message m, Keys keyData)
	{
		return false;
	}

	/// <summary>Processes a dialog key.</summary>
	/// <param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys" /> values that represents the key to process.</param>
	/// <returns>
	///   <see langword="true" /> if the key was processed by the item; otherwise, <see langword="false" />.</returns>
	protected internal override bool ProcessDialogKey(Keys keyData)
	{
		return false;
	}

	internal override void Dismiss(ToolStripDropDownCloseReason reason)
	{
	}

	internal override void HandleClick(EventArgs e)
	{
	}

	internal void HideDropDown(ToolStripDropDownCloseReason reason)
	{
	}

	private void DropDown_ItemAdded(object sender, ToolStripItemEventArgs e)
	{
	}
}
