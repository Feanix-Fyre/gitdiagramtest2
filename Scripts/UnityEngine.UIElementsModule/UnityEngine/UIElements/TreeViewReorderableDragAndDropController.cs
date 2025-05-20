using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	protected class DropData
	{
		public int[] expandedIdsBeforeDrag;

		public int[] draggedIds;

		public int lastItemId;

		public float expandItemBeginTimerMs;

		public Vector2 expandItemBeginPosition;
	}

	protected DropData m_DropData;

	protected readonly BaseTreeView m_TreeView;

	private IVisualElementScheduledItem m_ExpandDropItemScheduledItem;

	private Action m_ExpandDropItemCallback;

	public TreeViewReorderableDragAndDropController(BaseTreeView view)
		: base(null)
	{
	}

	protected override int CompareId(int id1, int id2)
	{
		return 0;
	}

	public override StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
	{
		return default(StartDragArgs);
	}

	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
	{
		return default(DragVisualMode);
	}

	public override void OnDrop(IListDragAndDropArgs args)
	{
	}

	public override void DragCleanup()
	{
	}

	private void RestoreExpanded(List<int> ids)
	{
	}

	public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition)
	{
	}

	private void DelayExpandDropItem()
	{
	}

	private void ExpandDropItem()
	{
	}
}
