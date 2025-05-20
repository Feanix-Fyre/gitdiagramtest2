using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal readonly struct TreeViewItemWrapper
{
	public readonly TreeItem item;

	public readonly int depth;

	public int id => 0;

	public IEnumerable<int> childrenIds => null;

	public bool hasChildren => false;

	public TreeViewItemWrapper(TreeItem item, int depth)
	{
		this.item = default(TreeItem);
		this.depth = 0;
	}
}
