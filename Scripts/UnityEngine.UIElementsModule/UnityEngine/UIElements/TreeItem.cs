using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal readonly struct TreeItem
{
	public int id { get; }

	public int parentId { get; }

	public IEnumerable<int> childrenIds { get; }

	public bool hasChildren => false;

	public TreeItem(int id, int parentId = -1, IEnumerable<int> childrenIds = null)
	{
		this.id = 0;
		this.parentId = 0;
		this.childrenIds = null;
	}
}
