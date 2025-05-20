using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems;

public class PointerEventData : BaseEventData
{
	public enum InputButton
	{
		Left = 0,
		Right = 1,
		Middle = 2
	}

	public enum FramePressState
	{
		Pressed = 0,
		Released = 1,
		PressedAndReleased = 2,
		NotChanged = 3
	}

	private GameObject m_PointerPress;

	public List<GameObject> hovered;

	public GameObject pointerEnter { get; set; }

	public GameObject lastPress { get; private set; }

	public GameObject rawPointerPress { get; set; }

	public GameObject pointerDrag { get; set; }

	public GameObject pointerClick { get; set; }

	public RaycastResult pointerCurrentRaycast { get; set; }

	public RaycastResult pointerPressRaycast { get; set; }

	public bool eligibleForClick { get; set; }

	public int displayIndex { get; set; }

	public int pointerId { get; set; }

	public Vector2 position { get; set; }

	public Vector2 delta { get; set; }

	public Vector2 pressPosition { get; set; }

	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	public Vector3 worldPosition { get; set; }

	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	public Vector3 worldNormal { get; set; }

	public float clickTime { get; set; }

	public int clickCount { get; set; }

	public Vector2 scrollDelta { get; set; }

	public bool useDragThreshold { get; set; }

	public bool dragging { get; set; }

	public InputButton button { get; set; }

	public float pressure { get; set; }

	public float tangentialPressure { get; set; }

	public float altitudeAngle { get; set; }

	public float azimuthAngle { get; set; }

	public float twist { get; set; }

	public Vector2 tilt { get; set; }

	public PenStatus penStatus { get; set; }

	public Vector2 radius { get; set; }

	public Vector2 radiusVariance { get; set; }

	public bool fullyExited { get; set; }

	public bool reentered { get; set; }

	public Camera enterEventCamera => null;

	public Camera pressEventCamera => null;

	public GameObject pointerPress
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PointerEventData(EventSystem eventSystem)
		: base(null)
	{
	}

	public bool IsPointerMoving()
	{
		return false;
	}

	public bool IsScrolling()
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
