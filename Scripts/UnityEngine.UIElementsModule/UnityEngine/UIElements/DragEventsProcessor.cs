namespace UnityEngine.UIElements;

internal abstract class DragEventsProcessor
{
	internal enum DragState
	{
		None = 0,
		CanStartDrag = 1,
		Dragging = 2
	}

	private bool m_IsRegistered;

	private DragState m_DragState;

	private Vector3 m_Start;

	protected readonly VisualElement m_Target;

	protected virtual bool supportsDragEvents => false;

	private bool useDragEvents => false;

	protected IDragAndDrop dragAndDrop => null;

	internal virtual bool isEditorContext => false;

	internal DragEventsProcessor(VisualElement target)
	{
	}

	private void RegisterCallbacksFromTarget(AttachToPanelEvent evt)
	{
	}

	private void RegisterCallbacksFromTarget()
	{
	}

	private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt)
	{
	}

	internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = false)
	{
	}

	protected abstract bool CanStartDrag(Vector3 pointerPosition);

	protected internal abstract StartDragArgs StartDrag(Vector3 pointerPosition);

	protected internal abstract void UpdateDrag(Vector3 pointerPosition);

	protected internal abstract void OnDrop(Vector3 pointerPosition);

	protected abstract void ClearDragAndDropUI(bool dragCancelled);

	private void OnPointerDownEvent(PointerDownEvent evt)
	{
	}

	internal void OnPointerUpEvent(PointerUpEvent evt)
	{
	}

	private void OnPointerLeaveEvent(PointerLeaveEvent evt)
	{
	}

	private void OnPointerCancelEvent(PointerCancelEvent evt)
	{
	}

	private void OnPointerCapturedOut(PointerCaptureOutEvent evt)
	{
	}

	private void OnPointerMoveEvent(PointerMoveEvent evt)
	{
	}

	private DragEventsProcessor GetDropTarget(Vector2 position)
	{
		return null;
	}
}
