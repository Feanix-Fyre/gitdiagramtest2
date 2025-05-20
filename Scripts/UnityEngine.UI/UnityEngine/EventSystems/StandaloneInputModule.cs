using System;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Standalone Input Module")]
public class StandaloneInputModule : PointerInputModule
{
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
	public enum InputMode
	{
		Mouse = 0,
		Buttons = 1
	}

	private float m_PrevActionTime;

	private Vector2 m_LastMoveVector;

	private int m_ConsecutiveMoveCount;

	private Vector2 m_LastMousePosition;

	private Vector2 m_MousePosition;

	private GameObject m_CurrentFocusedGameObject;

	private PointerEventData m_InputPointerEvent;

	private const float doubleClickTime = 0.3f;

	[SerializeField]
	private string m_HorizontalAxis;

	[SerializeField]
	private string m_VerticalAxis;

	[SerializeField]
	private string m_SubmitButton;

	[SerializeField]
	private string m_CancelButton;

	[SerializeField]
	private float m_InputActionsPerSecond;

	[SerializeField]
	private float m_RepeatDelay;

	[SerializeField]
	[HideInInspector]
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	private bool m_ForceModuleActive;

	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", false)]
	public InputMode inputMode => default(InputMode);

	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnMobileDevice
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	public bool forceModuleActive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float inputActionsPerSecond
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float repeatDelay
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public string horizontalAxis
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string verticalAxis
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string submitButton
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string cancelButton
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected StandaloneInputModule()
	{
	}

	private bool ShouldIgnoreEventsOnNoFocus()
	{
		return false;
	}

	public override void UpdateModule()
	{
	}

	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo)
	{
	}

	public override bool ShouldActivateModule()
	{
		return false;
	}

	public override void ActivateModule()
	{
	}

	public override void DeactivateModule()
	{
	}

	public override void Process()
	{
	}

	private bool ProcessTouchEvents()
	{
		return false;
	}

	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
	{
	}

	protected bool SendSubmitEventToSelectedObject()
	{
		return false;
	}

	private Vector2 GetRawMoveVector()
	{
		return default(Vector2);
	}

	protected bool SendMoveEventToSelectedObject()
	{
		return false;
	}

	protected void ProcessMouseEvent()
	{
	}

	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	protected virtual bool ForceAutoSelect()
	{
		return false;
	}

	protected void ProcessMouseEvent(int id)
	{
	}

	protected bool SendUpdateEventToSelectedObject()
	{
		return false;
	}

	protected void ProcessMousePress(MouseButtonEventData data)
	{
	}

	protected GameObject GetCurrentFocusedGameObject()
	{
		return null;
	}
}
