namespace System.Windows.Forms;

/// <summary>Provides data for the <see cref="E:System.Windows.Forms.TreeView.BeforeLabelEdit" /> and <see cref="E:System.Windows.Forms.TreeView.AfterLabelEdit" /> events.</summary>
public class NodeLabelEditEventArgs : EventArgs
{
	private TreeNode node;

	private string label;

	private bool cancel;

	/// <summary>Gets or sets a value indicating whether the edit has been canceled.</summary>
	/// <returns>
	///   <see langword="true" /> if the edit has been canceled; otherwise, <see langword="false" />.</returns>
	public bool CancelEdit
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets the tree node containing the text to edit.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.TreeNode" /> that represents the tree node containing the text to edit.</returns>
	public TreeNode Node => null;

	/// <summary>Gets the new text to associate with the tree node.</summary>
	/// <returns>The string value that represents the new <see cref="T:System.Windows.Forms.TreeNode" /> label or <see langword="null" /> if the user cancels the edit.</returns>
	public string Label => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.NodeLabelEditEventArgs" /> class for the specified <see cref="T:System.Windows.Forms.TreeNode" />.</summary>
	/// <param name="node">The tree node containing the text to edit.</param>
	public NodeLabelEditEventArgs(TreeNode node)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.NodeLabelEditEventArgs" /> class for the specified <see cref="T:System.Windows.Forms.TreeNode" /> and the specified text with which to update the tree node label.</summary>
	/// <param name="node">The tree node containing the text to edit.</param>
	/// <param name="label">The new text to associate with the tree node.</param>
	public NodeLabelEditEventArgs(TreeNode node, string label)
	{
	}

	internal void SetLabel(string label)
	{
	}
}
