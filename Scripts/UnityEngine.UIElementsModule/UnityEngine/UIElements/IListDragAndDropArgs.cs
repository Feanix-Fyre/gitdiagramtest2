namespace UnityEngine.UIElements;

internal interface IListDragAndDropArgs
{
	int insertAtIndex { get; }

	int parentId { get; }

	int childIndex { get; }

	DragAndDropData dragAndDropData { get; }

	DragAndDropPosition dragAndDropPosition { get; }
}
