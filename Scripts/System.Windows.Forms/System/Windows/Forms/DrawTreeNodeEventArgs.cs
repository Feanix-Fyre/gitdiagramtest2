using System.Drawing;

namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.TreeView.DrawNode" /> event.</summary>
public class DrawTreeNodeEventArgs : EventArgs
{
	private Rectangle bounds;

	private bool draw_default;

	private Graphics graphics;

	private TreeNode node;

	private TreeNodeStates state;

	/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Windows.Forms.TreeNode" /> should be drawn by the operating system rather than being owner drawn.</summary>
	/// <returns>
	///   <see langword="true" /> if the node should be drawn by the operating system; <see langword="false" /> if the node will be drawn in the event handler. The default value is <see langword="false" />.</returns>
	public bool DrawDefault => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.DrawTreeNodeEventArgs" /> class.</summary>
	/// <param name="graphics">The <see cref="T:System.Drawing.Graphics" /> surface on which to draw.</param>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> to draw.</param>
	/// <param name="bounds">The <see cref="T:System.Drawing.Rectangle" /> within which to draw.</param>
	/// <param name="state">A bitwise combination of the <see cref="T:System.Windows.Forms.TreeNodeStates" /> values indicating the current state of the <see cref="T:System.Windows.Forms.TreeNode" /> to draw.</param>
	public DrawTreeNodeEventArgs(Graphics graphics, TreeNode node, Rectangle bounds, TreeNodeStates state)
	{
	}
}
