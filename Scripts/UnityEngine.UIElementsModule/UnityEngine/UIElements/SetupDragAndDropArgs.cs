using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal readonly struct SetupDragAndDropArgs
{
	public readonly VisualElement draggedElement;

	public readonly IEnumerable<int> selectedIds;

	public readonly StartDragArgs startDragArgs;

	internal SetupDragAndDropArgs(VisualElement draggedElement, IEnumerable<int> selectedIds, StartDragArgs startDragArgs)
	{
		this.draggedElement = null;
		this.selectedIds = null;
		this.startDragArgs = default(StartDragArgs);
	}
}
