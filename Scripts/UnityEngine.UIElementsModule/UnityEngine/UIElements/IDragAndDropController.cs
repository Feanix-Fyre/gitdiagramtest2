using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal interface IDragAndDropController<in TArgs>
{
	bool CanStartDrag(IEnumerable<int> itemIds);

	StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false);

	DragVisualMode HandleDragAndDrop(TArgs args);

	void OnDrop(TArgs args);

	void DragCleanup()
	{
	}

	void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition)
	{
	}

	IEnumerable<int> GetSortedSelectedIds()
	{
		return null;
	}
}
