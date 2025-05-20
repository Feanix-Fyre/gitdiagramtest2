using System.Collections;

namespace System.Windows.Forms;

internal class OpenTreeNodeEnumerator : IEnumerator
{
	private TreeNode start;

	private TreeNode current;

	private bool started;

	public object Current => null;

	public TreeNode CurrentNode => null;

	public OpenTreeNodeEnumerator(TreeNode start)
	{
	}

	public bool MoveNext()
	{
		return false;
	}

	public bool MovePrevious()
	{
		return false;
	}

	public void Reset()
	{
	}
}
