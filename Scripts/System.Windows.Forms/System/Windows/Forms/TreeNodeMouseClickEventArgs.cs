namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.TreeView.NodeMouseClick" /> and <see cref="E:System.Windows.Forms.TreeView.NodeMouseDoubleClick" /> events.</summary>
public class TreeNodeMouseClickEventArgs : MouseEventArgs
{
	private TreeNode node;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.TreeNodeMouseClickEventArgs" /> class.</summary>
	/// <param name="node">The node that was clicked.</param>
	/// <param name="button">One of the <see cref="T:System.Windows.Forms.MouseButtons" /> members.</param>
	/// <param name="clicks">The number of clicks that occurred.</param>
	/// <param name="x">The x-coordinate where the click occurred.</param>
	/// <param name="y">The y-coordinate where the click occurred.</param>
	public TreeNodeMouseClickEventArgs(TreeNode node, MouseButtons button, int clicks, int x, int y)
		: base(default(MouseButtons), 0, 0, 0, 0)
	{
	}
}
