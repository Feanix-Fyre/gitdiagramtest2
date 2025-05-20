using UnityEngine.Events;

namespace UnityEngine.EventSystems;

[DisallowMultipleComponent]
public class PinchInputDetector : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
{
	private IPinchStartHandler[] pinchStartHandlers;

	private IPinchEndHandler[] pinchEndHandlers;

	private IPinchZoomHandler[] pinchZoomHandlers;

	private int touchCount;

	private bool pinching;

	private PointerEventData firstPointer;

	private PointerEventData secondPointer;

	private float previousDistance;

	private float delta;

	[SerializeField]
	protected UnityEvent onPinchStart;

	[SerializeField]
	protected UnityEvent onPinchEnd;

	protected virtual void Awake()
	{
	}

	protected virtual void RegisterPointer(PointerEventData eventData)
	{
	}

	protected virtual void UnregisterPointer(PointerEventData eventData)
	{
	}

	public virtual void OnBeginDrag(PointerEventData eventData)
	{
	}

	public virtual void OnEndDrag(PointerEventData eventData)
	{
	}

	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	private bool IsEqualPointer(PointerEventData a, PointerEventData b)
	{
		return false;
	}

	protected virtual void CalculateDistanceDelta()
	{
	}

	protected virtual void FireOnPinchStart(PinchEventData data)
	{
	}

	protected virtual void FireOnPinchEnd(PinchEventData data)
	{
	}

	protected virtual void FireOnPinchZoom(PinchEventData data)
	{
	}
}
