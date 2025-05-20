using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms.Layout;

namespace System.Windows.Forms;

/// <summary>Manages the overflow behavior of a <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class ToolStripOverflow : ToolStripDropDown, IDisposable, IComponent
{
	private LayoutEngine layout_engine;

	/// <summary>Gets all of the items on the <see cref="T:System.Windows.Forms.ToolStrip" />, whether they are currently being displayed or not.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> containing all of the items.</returns>
	public override ToolStripItemCollection Items => null;

	/// <summary>Passes a reference to the cached <see cref="P:System.Windows.Forms.Control.LayoutEngine" /> returned by the layout engine interface.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.Layout.LayoutEngine" /> that represents the cached layout engine returned by the layout engine interface.</returns>
	public override LayoutEngine LayoutEngine => null;

	/// <summary>Gets all of the items that are currently being displayed on the <see cref="T:System.Windows.Forms.ToolStrip" />.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.ToolStripItemCollection" /> that includes all items on this <see cref="T:System.Windows.Forms.ToolStrip" />.</returns>
	protected internal override ToolStripItemCollection DisplayedItems => null;

	internal ToolStrip ParentToolStrip => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripOverflow" /> class derived from a base <see cref="T:System.Windows.Forms.ToolStripItem" />.</summary>
	/// <param name="parentItem">The <see cref="T:System.Windows.Forms.ToolStripItem" /> from which to derive this <see cref="T:System.Windows.Forms.ToolStripOverflow" /> instance.</param>
	public ToolStripOverflow(ToolStripItem parentItem)
	{
	}

	/// <summary>Retrieves the size of a rectangular area into which a control can be fitted.</summary>
	/// <param name="constrainingSize">The custom-sized area for a control.</param>
	/// <returns>An ordered pair of type <see cref="T:System.Drawing.Size" /> representing the width and height of a rectangle.</returns>
	public override Size GetPreferredSize(Size constrainingSize)
	{
		return default(Size);
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.Control.Layout" /> event.</summary>
	/// <param name="e">A <see cref="T:System.Windows.Forms.LayoutEventArgs" /> that contains the event data.</param>
	[MonoInternalNote("This should stack in rows of ~3, but for now 1 column will work.")]
	protected override void OnLayout(LayoutEventArgs e)
	{
	}

	/// <summary>Resets the collection of displayed and overflow items after a layout is done.</summary>
	protected override void SetDisplayedItems()
	{
	}
}
