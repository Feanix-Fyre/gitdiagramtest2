using UnityEngine.EventSystems;

namespace UnityEngine.UIElements;

[AddComponentMenu("UI Toolkit/Panel Event Handler (UI Toolkit)")]
public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent, IPointerClickHandler
{
	private enum PointerEventType
	{
		Default = 0,
		Down = 1,
		Up = 2
	}

	private class PointerEvent : IPointerEvent
	{
		public int pointerId { get; private set; }

		public string pointerType { get; private set; }

		public bool isPrimary { get; private set; }

		public int button { get; private set; }

		public int pressedButtons { get; private set; }

		public Vector3 position { get; private set; }

		public Vector3 localPosition { get; private set; }

		public Vector3 deltaPosition { get; private set; }

		public float deltaTime { get; private set; }

		public int clickCount { get; private set; }

		public float pressure { get; private set; }

		public float tangentialPressure { get; private set; }

		public float altitudeAngle { get; private set; }

		public float azimuthAngle { get; private set; }

		public float twist { get; private set; }

		public Vector2 tilt { get; private set; }

		public PenStatus penStatus { get; private set; }

		public Vector2 radius { get; private set; }

		public Vector2 radiusVariance { get; private set; }

		public EventModifiers modifiers { get; private set; }

		public bool shiftKey => false;

		public bool ctrlKey => false;

		public bool commandKey => false;

		public bool altKey => false;

		public bool actionKey => false;

		public void Read(PanelEventHandler self, PointerEventData eventData, PointerEventType eventType)
		{
		}

		public void SetPosition(Vector3 positionOverride, Vector3 deltaOverride)
		{
		}
	}

	private BaseRuntimePanel m_Panel;

	private readonly PointerEvent m_PointerEvent;

	private float m_LastClickTime;

	private bool m_Selecting;

	private Event m_Event;

	private static EventModifiers s_Modifiers;

	public IPanel panel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private GameObject selectableGameObject => null;

	private EventSystem eventSystem => null;

	private bool isCurrentFocusedPanel => false;

	private Focusable currentFocusedElement => null;

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	private void RegisterCallbacks()
	{
	}

	private void UnregisterCallbacks()
	{
	}

	private void OnPanelDestroyed()
	{
	}

	private void OnElementFocus(FocusEvent e)
	{
	}

	private void OnElementBlur(BlurEvent e)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	public void OnPointerMove(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void OnSubmit(BaseEventData eventData)
	{
	}

	public void OnCancel(BaseEventData eventData)
	{
	}

	public void OnMove(AxisEventData eventData)
	{
	}

	public void OnScroll(PointerEventData eventData)
	{
	}

	private void SendEvent(EventBase e, BaseEventData sourceEventData)
	{
	}

	private void SendEvent(EventBase e, Event sourceEvent)
	{
	}

	internal void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void ProcessImguiEvents(Focusable target)
	{
	}

	private void ProcessKeyboardEvent(Event e, Focusable target)
	{
	}

	private void ProcessTabEvent(Event e, Focusable target)
	{
	}

	private void SendTabEvent(Event e, NavigationMoveEvent.Direction direction, Focusable target)
	{
	}

	private void SendKeyUpEvent(Event e, Focusable target)
	{
	}

	private void SendKeyDownEvent(Event e, Focusable target)
	{
	}

	private bool ReadPointerData(PointerEvent pe, PointerEventData eventData, PointerEventType eventType = PointerEventType.Default)
	{
		return false;
	}
}
