namespace UnityEngine;

internal struct SliderHandler
{
	private readonly Rect position;

	private readonly float currentValue;

	private readonly float size;

	private readonly float start;

	private readonly float end;

	private readonly GUIStyle slider;

	private readonly GUIStyle thumb;

	private readonly GUIStyle thumbExtent;

	private readonly bool horiz;

	private readonly int id;

	public SliderHandler(Rect position, float currentValue, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent = null)
	{
		this.position = default(Rect);
		this.currentValue = 0f;
		this.size = 0f;
		this.start = 0f;
		this.end = 0f;
		this.slider = null;
		this.thumb = null;
		this.thumbExtent = null;
		this.horiz = false;
		this.id = 0;
	}

	public float Handle()
	{
		return 0f;
	}

	private float OnMouseDown()
	{
		return 0f;
	}

	private float OnMouseDrag()
	{
		return 0f;
	}

	private float OnMouseUp()
	{
		return 0f;
	}

	private float OnRepaint()
	{
		return 0f;
	}

	private EventType CurrentEventType()
	{
		return default(EventType);
	}

	private int CurrentScrollTroughSide()
	{
		return 0;
	}

	private bool IsEmptySlider()
	{
		return false;
	}

	private bool SupportsPageMovements()
	{
		return false;
	}

	private float PageMovementValue()
	{
		return 0f;
	}

	private float PageUpMovementBound()
	{
		return 0f;
	}

	private Event CurrentEvent()
	{
		return null;
	}

	private float ValueForCurrentMousePosition()
	{
		return 0f;
	}

	private float Clamp(float value)
	{
		return 0f;
	}

	private Rect ThumbSelectionRect()
	{
		return default(Rect);
	}

	private void StartDraggingWithValue(float dragStartValue)
	{
	}

	private SliderState SliderState()
	{
		return null;
	}

	private Rect ThumbExtRect()
	{
		return default(Rect);
	}

	private Rect ThumbRect()
	{
		return default(Rect);
	}

	private Rect VerticalThumbRect()
	{
		return default(Rect);
	}

	private Rect HorizontalThumbRect()
	{
		return default(Rect);
	}

	private float ClampedCurrentValue()
	{
		return 0f;
	}

	private float MousePosition()
	{
		return 0f;
	}

	private float ValuesPerPixel()
	{
		return 0f;
	}

	private float ThumbSize()
	{
		return 0f;
	}

	private float MaxValue()
	{
		return 0f;
	}

	private float MinValue()
	{
		return 0f;
	}
}
