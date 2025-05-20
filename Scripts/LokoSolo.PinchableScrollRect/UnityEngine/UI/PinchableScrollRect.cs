using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
public class PinchableScrollRect : ScrollRect, IPinchStartHandler, IPinchEndHandler, IPinchZoomHandler
{
	[Serializable]
	public class PinchEvent : UnityEvent<Vector3>
	{
	}

	[Header("Pinch Settings")]
	[SerializeField]
	protected bool resetOnEnable;

	[SerializeField]
	protected bool lockPinchCenter;

	private Vector2 initPivot;

	private Vector2 initAnchored;

	private Vector3 initScale;

	private float zoomVelocity;

	private Vector2 zoomPosDelta;

	private bool updatePivot;

	protected bool isZooming;

	protected Vector2 pinchStartPos;

	public Vector3 lowerScale;

	public Vector3 upperScale;

	[SerializeField]
	protected float pinchSensitivity;

	[SerializeField]
	protected float zoomMaxSpeed;

	[SerializeField]
	[Range(1f, 0f)]
	protected float zoomDeceleration;

	private bool initialized;

	[SerializeField]
	private PinchEvent _onScaleChanged;

	public PinchEvent onScaleChanged
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void Start()
	{
	}

	protected override void OnEnable()
	{
	}

	public virtual void OnPinchStart(PinchEventData eventData)
	{
	}

	public virtual void OnPinchEnd(PinchEventData eventData)
	{
	}

	public virtual void OnPinchZoom(PinchEventData eventData)
	{
	}

	public override void OnScroll(PointerEventData eventData)
	{
	}

	protected virtual void Update()
	{
	}

	protected override void LateUpdate()
	{
	}

	protected virtual void HandleZoom(float zoomValue)
	{
	}

	protected virtual void SetContentPivotPosition(Vector2 pivot)
	{
	}

	protected virtual void SetContentLocalScale(Vector3 newScale)
	{
	}

	protected void ResetZoom()
	{
	}

	public void SetNormalizedScale(float normalized)
	{
	}

	public virtual void ResetContent()
	{
	}

	public override void OnDrag(PointerEventData eventData)
	{
	}

	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	public override void OnEndDrag(PointerEventData eventData)
	{
	}
}
