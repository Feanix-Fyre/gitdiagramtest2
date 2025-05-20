using System;
using UnityEngine.UI;

namespace UnityEngine.InputSystem.UI;

[AddComponentMenu("Input/Virtual Mouse")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/UISupport.html#virtual-mouse-cursor-control")]
public class VirtualMouseInput : MonoBehaviour
{
	public enum CursorMode
	{
		SoftwareCursor = 0,
		HardwareCursorIfAvailable = 1
	}

	[SerializeField]
	[Tooltip("Whether the component should set the cursor position of the hardware mouse cursor, if one is available. If so, the software cursor pointed (to by 'Cursor Graphic') will be hidden.")]
	[Header("Cursor")]
	private CursorMode m_CursorMode;

	[SerializeField]
	[Tooltip("The graphic that represents the software cursor. This is hidden if a hardware cursor (see 'Cursor Mode') is used.")]
	private Graphic m_CursorGraphic;

	[SerializeField]
	[Tooltip("The transform for the software cursor. Will only be set if a software cursor is used (see 'Cursor Mode'). Moving the cursor updates the anchored position of the transform.")]
	private RectTransform m_CursorTransform;

	[SerializeField]
	[Tooltip("Speed in pixels per second with which to move the cursor. Scaled by the input from 'Stick Action'.")]
	[Header("Motion")]
	private float m_CursorSpeed;

	[SerializeField]
	[Tooltip("Scale factor to apply to 'Scroll Wheel Action' when setting the mouse 'scrollWheel' control.")]
	private float m_ScrollSpeed;

	[SerializeField]
	[Tooltip("Vector2 action that moves the cursor left/right (X) and up/down (Y) on screen.")]
	[Space(10f)]
	private InputActionProperty m_StickAction;

	[Tooltip("Button action that triggers a left-click on the mouse.")]
	[SerializeField]
	private InputActionProperty m_LeftButtonAction;

	[Tooltip("Button action that triggers a middle-click on the mouse.")]
	[SerializeField]
	private InputActionProperty m_MiddleButtonAction;

	[SerializeField]
	[Tooltip("Button action that triggers a right-click on the mouse.")]
	private InputActionProperty m_RightButtonAction;

	[Tooltip("Button action that triggers a forward button (button #4) click on the mouse.")]
	[SerializeField]
	private InputActionProperty m_ForwardButtonAction;

	[Tooltip("Button action that triggers a back button (button #5) click on the mouse.")]
	[SerializeField]
	private InputActionProperty m_BackButtonAction;

	[SerializeField]
	[Tooltip("Vector2 action that feeds into the mouse 'scrollWheel' action (scaled by 'Scroll Speed').")]
	private InputActionProperty m_ScrollWheelAction;

	private Canvas m_Canvas;

	private Mouse m_VirtualMouse;

	private Mouse m_SystemMouse;

	private Action m_AfterInputUpdateDelegate;

	private Action<InputAction.CallbackContext> m_ButtonActionTriggeredDelegate;

	private double m_LastTime;

	private Vector2 m_LastStickValue;

	public RectTransform cursorTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float cursorSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public CursorMode cursorMode
	{
		get
		{
			return default(CursorMode);
		}
		set
		{
		}
	}

	public Graphic cursorGraphic
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float scrollSpeed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Mouse virtualMouse => null;

	public InputActionProperty stickAction
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	public InputActionProperty leftButtonAction
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	public InputActionProperty rightButtonAction
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	public InputActionProperty middleButtonAction
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	public InputActionProperty forwardButtonAction
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	public InputActionProperty backButtonAction
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	public InputActionProperty scrollWheelAction
	{
		get
		{
			return default(InputActionProperty);
		}
		set
		{
		}
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	private void TryFindCanvas()
	{
	}

	private void TryEnableHardwareCursor()
	{
	}

	private void UpdateMotion()
	{
	}

	private void OnButtonActionTriggered(InputAction.CallbackContext context)
	{
	}

	private static void SetActionCallback(InputActionProperty field, Action<InputAction.CallbackContext> callback, bool install = true)
	{
	}

	private static void SetAction(ref InputActionProperty field, InputActionProperty value)
	{
	}

	private void OnAfterInputUpdate()
	{
	}
}
