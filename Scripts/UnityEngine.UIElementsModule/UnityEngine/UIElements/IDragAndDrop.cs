namespace UnityEngine.UIElements;

internal interface IDragAndDrop
{
	DragAndDropData data { get; }

	void StartDrag(StartDragArgs args, Vector3 pointerPosition);

	void UpdateDrag(Vector3 pointerPosition);

	void AcceptDrag();

	void DragCleanup();

	void SetVisualMode(DragVisualMode visualMode);
}
