using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class DefaultMultiColumnTreeViewController<T> : MultiColumnTreeViewController
{
	private TreeDataController<T> m_TreeDataController;

	private TreeDataController<T> treeDataController => null;

	public override IList itemsSource
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DefaultMultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
		: base(null, null, null)
	{
	}

	public void SetRootItems(IList<TreeViewItemData<T>> items)
	{
	}

	public override object GetItemForIndex(int index)
	{
		return null;
	}

	public override int GetParentId(int id)
	{
		return 0;
	}

	public override bool HasChildren(int id)
	{
		return false;
	}

	public override IEnumerable<int> GetChildrenIds(int id)
	{
		return null;
	}

	public override void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true)
	{
	}

	private bool IsChildOf(int childId, int id)
	{
		return false;
	}

	public override IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null)
	{
		return null;
	}
}
