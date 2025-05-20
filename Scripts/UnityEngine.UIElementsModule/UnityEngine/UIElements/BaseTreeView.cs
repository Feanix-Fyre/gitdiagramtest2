using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

public abstract class BaseTreeView : BaseVerticalCollectionView
{
	public new class UxmlTraits : BaseVerticalCollectionView.UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_AutoExpand;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string itemUssClassName;

	public static readonly string itemToggleUssClassName;

	public static readonly string itemIndentsContainerUssClassName;

	public static readonly string itemIndentUssClassName;

	public static readonly string itemContentContainerUssClassName;

	private bool m_AutoExpand;

	[SerializeField]
	private List<int> m_ExpandedItemIds;

	public new IList itemsSource => null;

	public new BaseTreeViewController viewController => null;

	public bool autoExpand
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal List<int> expandedItemIds
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private protected override void CreateVirtualizationController()
	{
	}

	public override void SetViewController(CollectionViewController controller)
	{
	}

	private void OnItemIndexChanged(int srcIndex, int dstIndex)
	{
	}

	internal override ICollectionDragAndDropController CreateDragAndDropController()
	{
		return null;
	}

	public BaseTreeView()
	{
	}

	public BaseTreeView(int itemHeight)
	{
	}

	internal override void OnViewDataReady()
	{
	}

	private protected override bool HandleItemNavigation(bool moveIn, bool altPressed)
	{
		return false;
	}

	public void SetSelectionById(int id)
	{
	}

	public void SetSelectionById(IEnumerable<int> ids)
	{
	}

	internal void SetSelectionInternalById(IEnumerable<int> ids, bool sendNotification)
	{
	}

	private int GetItemIndex(int id, bool expand = false)
	{
		return 0;
	}

	public bool IsExpanded(int id)
	{
		return false;
	}

	public void CollapseItem(int id, bool collapseAllChildren = false)
	{
	}

	public void ExpandItem(int id, bool expandAllChildren = false)
	{
	}

	private void OnTreeViewPointerUp(PointerUpEvent evt)
	{
	}

	private bool IsExpandedByIndex(int index)
	{
		return false;
	}

	private void CollapseItemByIndex(int index, bool collapseAll)
	{
	}

	private void ExpandItemByIndex(int index, bool expandAll)
	{
	}
}
