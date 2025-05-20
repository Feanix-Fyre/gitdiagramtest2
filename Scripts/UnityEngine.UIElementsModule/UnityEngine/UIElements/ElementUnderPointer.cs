namespace UnityEngine.UIElements;

internal class ElementUnderPointer
{
	private VisualElement[] m_PendingTopElementUnderPointer;

	private VisualElement[] m_TopElementUnderPointer;

	private IPointerEvent[] m_TriggerPointerEvent;

	private IMouseEvent[] m_TriggerMouseEvent;

	private Vector2[] m_PickingPointerPositions;

	private bool[] m_IsPickingPointerTemporaries;

	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary)
	{
		pickPosition = default(Vector2);
		isTemporary = default(bool);
		return null;
	}

	internal VisualElement GetTopElementUnderPointer(int pointerId)
	{
		return null;
	}

	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos)
	{
	}

	private Vector2 GetEventPointerPosition(EventBase triggerEvent)
	{
		return default(Vector2);
	}

	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
	{
	}

	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent)
	{
	}

	private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary)
	{
	}

	internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType)
	{
	}
}
