using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.ToolStripRenderer.RenderGrip" /> event.</summary>
public class ToolStripSeparatorRenderEventArgs : ToolStripItemRenderEventArgs
{
	private bool vertical;

	/// <summary>Gets a value indicating whether the display style for the grip is vertical.</summary>
	/// <returns>
	///   <see langword="true" /> if the display style for the <see cref="T:System.Windows.Forms.ToolStripSeparator" /> is vertical; otherwise, <see langword="false" />.</returns>
	public bool Vertical => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ToolStripSeparatorRenderEventArgs" /> class.</summary>
	/// <param name="g">The <see cref="T:System.Drawing.Graphics" /> to paint with.</param>
	/// <param name="separator">The <see cref="T:System.Windows.Forms.ToolStripSeparator" /> to be painted.</param>
	/// <param name="vertical">A value indicating whether or not the <see cref="T:System.Windows.Forms.ToolStripSeparator" /> is to be drawn vertically.</param>
	public ToolStripSeparatorRenderEventArgs(Graphics g, ToolStripSeparator separator, bool vertical)
		: base(null, null)
	{
	}
}
