using System.Drawing;
using System.Windows.Forms.Design;

namespace System.Windows.Forms;

/// <summary>Hosts a <see cref="T:System.Windows.Forms.ToolStripDropDown" /> that displays items that overflow the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.None)]
public class ToolStripOverflowButton : ToolStripDropDownButton
{
	/// <summary>Gets a value indicating whether the <see cref="T:System.Windows.Forms.ToolStripOverflowButton" /> has items that overflow the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Windows.Forms.ToolStripOverflowButton" /> has overflow items; otherwise, <see langword="false" />.</returns>
	public override bool HasDropDownItems => false;

	/// <summary>Gets the space, in pixels, that is specified by default between controls.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Padding" /> value representing the space between controls.</returns>
	protected internal override Padding DefaultMargin => default(Padding);

	internal ToolStripOverflowButton(ToolStrip ts)
	{
	}

	/// <summary>Retrieves the size of a rectangular area into which a control can fit.</summary>
	/// <param name="constrainingSize">The custom-sized area for a control.</param>
	/// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>
	public override Size GetPreferredSize(Size constrainingSize)
	{
		return default(Size);
	}

	/// <summary>Creates an empty <see cref="T:System.Windows.Forms.ToolStripDropDown" /> that can be dropped down and to which events can be attached.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripDropDown" /> control.</returns>
	protected override ToolStripDropDown CreateDefaultDropDown()
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.</summary>
	/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected override void OnPaint(PaintEventArgs e)
	{
	}

	/// <summary>Sets the size and location of the <see cref="T:System.Windows.Forms.ToolStripOverflowButton" />.</summary>
	/// <param name="bounds">A <see cref="T:System.Drawing.Rectangle" /> representing the size and location of the <see cref="T:System.Windows.Forms.ToolStripOverflowButton" />.</param>
	protected internal override void SetBounds(Rectangle bounds)
	{
	}
}
