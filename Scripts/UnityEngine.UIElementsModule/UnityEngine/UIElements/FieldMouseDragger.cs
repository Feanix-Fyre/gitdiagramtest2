using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class FieldMouseDragger<T> : BaseFieldMouseDragger
{
	private readonly IValueField<T> m_DrivenField;

	private VisualElement m_DragElement;

	private Rect m_DragHotZone;

	public bool dragging { get; set; }

	public T startValue { get; set; }

	public FieldMouseDragger(IValueField<T> drivenField)
	{
	}

	public sealed override void SetDragZone(VisualElement dragElement, Rect hotZone)
	{
	}

	private bool CanStartDrag(int button, Vector2 localPosition)
	{
		return false;
	}

	private void UpdateValueOnPointerDown(PointerDownEvent evt)
	{
	}

	private void ProcessDownEvent(EventBase evt)
	{
	}

	private void UpdateValueOnPointerMove(PointerMoveEvent evt)
	{
	}

	private void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition)
	{
	}

	private void UpdateValueOnPointerUp(PointerUpEvent evt)
	{
	}

	private void ProcessUpEvent(EventBase evt, int pointerId)
	{
	}

	private void UpdateValueOnKeyDown(KeyDownEvent evt)
	{
	}
}
