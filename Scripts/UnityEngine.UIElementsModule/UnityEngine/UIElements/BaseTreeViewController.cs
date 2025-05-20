using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements;

public abstract class BaseTreeViewController : CollectionViewController
{
	private Dictionary<int, TreeItem> m_TreeItems;

	private List<int> m_RootIndices;

	private List<TreeViewItemWrapper> m_ItemWrappers;

	private HashSet<int> m_TreeItemIdsWithItemWrappers;

	private List<TreeViewItemWrapper> m_WrapperInsertionList;

	private static readonly ProfilerMarker K_ExpandItemByIndex;

	private static readonly ProfilerMarker k_CreateWrappers;

	protected BaseTreeView baseTreeView => null;

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

	public void RebuildTree()
	{
	}

	public IEnumerable<int> GetRootItemIds()
	{
		return null;
	}

	public abstract IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null);

	public abstract int GetParentId(int id);

	public abstract IEnumerable<int> GetChildrenIds(int id);

	public abstract void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true);

	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem)
	{
	}

	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index)
	{
	}

	internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem)
	{
	}

	internal void PostInitRegistration(ReusableTreeViewItem treeItem)
	{
	}

	private void OnItemPointerUp(PointerUpEvent evt)
	{
	}

	private void OnToggleValueChanged(ChangeEvent<bool> evt)
	{
	}

	public override int GetIndexForId(int id)
	{
		return 0;
	}

	public override int GetIdForIndex(int index)
	{
		return 0;
	}

	public virtual bool HasChildren(int id)
	{
		return false;
	}

	internal bool Exists(int id)
	{
		return false;
	}

	public bool HasChildrenByIndex(int index)
	{
		return false;
	}

	public IEnumerable<int> GetChildrenIdsByIndex(int index)
	{
		return null;
	}

	public int GetChildIndexForId(int id)
	{
		return 0;
	}

	internal int GetIndentationDepth(int id)
	{
		return 0;
	}

	internal int GetIndentationDepthByIndex(int index)
	{
		return 0;
	}

	internal virtual bool CanChangeExpandedState(int id)
	{
		return false;
	}

	public bool IsExpanded(int id)
	{
		return false;
	}

	public bool IsExpandedByIndex(int index)
	{
		return false;
	}

	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true)
	{
	}

	public void ExpandItem(int id, bool expandAllChildren, bool refresh = true)
	{
	}

	public void CollapseItemByIndex(int index, bool collapseAllChildren)
	{
	}

	public void CollapseItem(int id, bool collapseAllChildren)
	{
	}

	internal void RegenerateWrappers()
	{
	}

	private void CreateWrappers(IEnumerable<int> treeViewItemIds, int depth, ref List<TreeViewItemWrapper> wrappers)
	{
	}

	private bool IsIndexValid(int index)
	{
		return false;
	}

	internal void RaiseItemParentChanged(int id, int newParentId)
	{
	}
}
