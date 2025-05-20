using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI;

internal struct PointerModel
{
	public struct ButtonState
	{
		private bool m_IsPressed;

		private PointerEventData.FramePressState m_FramePressState;

		private float m_PressTime;

		private RaycastResult m_PressRaycast;

		private GameObject m_PressObject;

		private GameObject m_RawPressObject;

		private GameObject m_LastPressObject;

		private GameObject m_DragObject;

		private Vector2 m_PressPosition;

		private float m_ClickTime;

		private int m_ClickCount;

		private bool m_Dragging;

		private bool m_ClickedOnSameGameObject;

		private bool m_IgnoreNextClick;

		public bool isPressed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ignoreNextClick
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float pressTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool clickedOnSameGameObject
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool wasPressedThisFrame => false;

		public bool wasReleasedThisFrame => false;

		public void CopyPressStateTo(PointerEventData eventData)
		{
		}

		public void CopyPressStateFrom(PointerEventData eventData)
		{
		}

		public void OnEndFrame()
		{
		}
	}

	public bool changedThisFrame;

	public ButtonState leftButton;

	public ButtonState rightButton;

	public ButtonState middleButton;

	public ExtendedPointerEventData eventData;

	private Vector2 m_ScreenPosition;

	private Vector2 m_ScrollDelta;

	private Vector3 m_WorldPosition;

	private Quaternion m_WorldOrientation;

	private float m_Pressure;

	private float m_AzimuthAngle;

	private float m_AltitudeAngle;

	private float m_Twist;

	private Vector2 m_Radius;

	public UIPointerType pointerType => default(UIPointerType);

	public Vector2 screenPosition
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector3 worldPosition
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion worldOrientation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Vector2 scrollDelta
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public float pressure
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float azimuthAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float altitudeAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float twist
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector2 radius
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public PointerModel(ExtendedPointerEventData eventData)
	{
		changedThisFrame = false;
		leftButton = default(ButtonState);
		rightButton = default(ButtonState);
		middleButton = default(ButtonState);
		this.eventData = null;
		m_ScreenPosition = default(Vector2);
		m_ScrollDelta = default(Vector2);
		m_WorldPosition = default(Vector3);
		m_WorldOrientation = default(Quaternion);
		m_Pressure = 0f;
		m_AzimuthAngle = 0f;
		m_AltitudeAngle = 0f;
		m_Twist = 0f;
		m_Radius = default(Vector2);
	}

	public void OnFrameFinished()
	{
	}

	public void CopyTouchOrPenStateFrom(PointerEventData eventData)
	{
	}
}
