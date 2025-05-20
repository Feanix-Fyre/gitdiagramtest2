using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal abstract class BaseReorderableDragAndDropController : ICollectionDragAndDropController, IDragAndDropController<IListDragAndDropArgs>, IReorderable
{
	protected readonly BaseVerticalCollectionView m_View;

	protected List<int> m_SortedSelectedIds;

	public virtual bool enableReordering { get; set; }

	public IEnumerable<int> GetSortedSelectedIds()
	{
		return null;
	}

	protected BaseReorderableDragAndDropController(BaseVerticalCollectionView view)
	{
	}

	public virtual bool CanStartDrag(IEnumerable<int> itemIds)
	{
		return false;
	}

	public virtual StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
	{
		return default(StartDragArgs);
	}

	protected virtual int CompareId(int id1, int id2)
	{
		return 0;
	}

	public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args);

	public abstract void OnDrop(IListDragAndDropArgs args);

	public virtual void DragCleanup()
	{
	}

	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition)
	{
	}
}
