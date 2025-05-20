namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.TreeView.AfterCheck" />, <see cref="E:System.Windows.Forms.TreeView.AfterCollapse" />, <see cref="E:System.Windows.Forms.TreeView.AfterExpand" />, or <see cref="E:System.Windows.Forms.TreeView.AfterSelect" /> events of a <see cref="T:System.Windows.Forms.TreeView" /> control.</summary>
public class TreeViewEventArgs : EventArgs
{
	private TreeNode node;

	private TreeViewAction action;

	/// <summary>Gets the tree node that has been checked, expanded, collapsed, or selected.</summary>
	/// <returns>The <see cref="T:System.Windows.Forms.TreeNode" /> that has been checked, expanded, collapsed, or selected.</returns>
	public TreeNode Node => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.TreeViewEventArgs" /> class for the specified tree node.</summary>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> that the event is responding to.</param>
	public TreeViewEventArgs(TreeNode node)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.TreeViewEventArgs" /> class for the specified tree node and with the specified type of action that raised the event.</summary>
	/// <param name="node">The <see cref="T:System.Windows.Forms.TreeNode" /> that the event is responding to.</param>
	/// <param name="action">The type of <see cref="T:System.Windows.Forms.TreeViewAction" /> that raised the event.</param>
	public TreeViewEventArgs(TreeNode node, TreeViewAction action)
	{
	}
}
