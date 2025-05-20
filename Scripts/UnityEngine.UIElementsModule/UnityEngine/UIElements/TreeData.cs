using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal readonly struct TreeData<T>
{
	private readonly IList<int> m_RootItemIds;

	private readonly Dictionary<int, TreeViewItemData<T>> m_Tree;

	private readonly Dictionary<int, int> m_ParentIds;

	private readonly Dictionary<int, List<int>> m_ChildrenIds;

	public IEnumerable<int> rootItemIds => null;

	public TreeData(IList<TreeViewItemData<T>> rootItems)
	{
		m_RootItemIds = null;
		m_Tree = null;
		m_ParentIds = null;
		m_ChildrenIds = null;
	}

	public TreeViewItemData<T> GetDataForId(int id)
	{
		return default(TreeViewItemData<T>);
	}

	public int GetParentId(int id)
	{
		return 0;
	}

	public void Move(int id, int newParentId, int childIndex)
	{
	}

	public bool HasAncestor(int childId, int ancestorId)
	{
		return false;
	}

	private void AddItemToParent(TreeViewItemData<T> item, int parentId, int childIndex)
	{
	}

	private void RemoveFromParent(int id, int parentId)
	{
	}

	private void UpdateParentTree(TreeViewItemData<T> current)
	{
	}

	private void RefreshTree(IList<TreeViewItemData<T>> rootItems)
	{
	}

	private void BuildTree(IEnumerable<TreeViewItemData<T>> items, bool isRoot)
	{
	}
}
