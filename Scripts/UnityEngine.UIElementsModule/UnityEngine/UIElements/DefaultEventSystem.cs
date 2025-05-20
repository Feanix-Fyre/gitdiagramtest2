using System;

namespace UnityEngine.UIElements;

internal class DefaultEventSystem
{
	public enum UpdateMode
	{
		Always = 0,
		IgnoreIfAppNotFocused = 1
	}

	internal struct FocusBasedEventSequenceContext : IDisposable
	{
		private DefaultEventSystem es;

		public FocusBasedEventSequenceContext(DefaultEventSystem es)
		{
			this.es = null;
		}

		public void Dispose()
		{
		}
	}

	internal interface IInput
	{
		int touchCount { get; }

		bool mousePresent { get; }

		Vector3 mousePosition { get; }

		int mouseButtonCount { get; }

		bool anyKey { get; }

		float unscaledTime { get; }

		float doubleClickTime { get; }

		bool GetButtonDown(string button);

		float GetAxisRaw(string axis);

		void ClearLastPenContactEvent();

		PenData GetLastPenContactEvent();

		Touch GetTouch(int index);

		bool GetMouseButtonDown(int button);

		bool GetMouseButtonUp(int button);
	}

	private class Input : IInput
	{
		public int touchCount => 0;

		public bool mousePresent => false;

		public Vector3 mousePosition => default(Vector3);

		public int mouseButtonCount => 0;

		public bool anyKey => false;

		public float unscaledTime => 0f;

		public float doubleClickTime => 0f;

		public bool GetButtonDown(string button)
		{
			return false;
		}

		public float GetAxisRaw(string axis)
		{
			return 0f;
		}

		public void ClearLastPenContactEvent()
		{
		}

		public PenData GetLastPenContactEvent()
		{
			return default(PenData);
		}

		public Touch GetTouch(int index)
		{
			return default(Touch);
		}

		public bool GetMouseButtonDown(int button)
		{
			return false;
		}

		public bool GetMouseButtonUp(int button)
		{
			return false;
		}
	}

	private class NoInput : IInput
	{
		public int touchCount => 0;

		public bool mousePresent => false;

		public Vector3 mousePosition => default(Vector3);

		public int mouseButtonCount => 0;

		public bool anyKey => false;

		public float unscaledTime => 0f;

		public float doubleClickTime => 0f;

		public bool GetButtonDown(string button)
		{
			return false;
		}

		public float GetAxisRaw(string axis)
		{
			return 0f;
		}

		public Touch GetTouch(int index)
		{
			return default(Touch);
		}

		public void ClearLastPenContactEvent()
		{
		}

		public PenData GetLastPenContactEvent()
		{
			return default(PenData);
		}

		public bool GetMouseButtonDown(int button)
		{
			return false;
		}

		public bool GetMouseButtonUp(int button)
		{
			return false;
		}
	}

	internal static Func<bool> IsEditorRemoteConnected;

	private IInput m_Input;

	private readonly string m_HorizontalAxis;

	private readonly string m_VerticalAxis;

	private readonly string m_SubmitButton;

	private readonly string m_CancelButton;

	private readonly float m_InputActionsPerSecond;

	private readonly float m_RepeatDelay;

	private bool m_SendingTouchEvents;

	private bool m_SendingPenEvent;

	private Event m_Event;

	private BaseRuntimePanel m_FocusedPanel;

	private BaseRuntimePanel m_PreviousFocusedPanel;

	private Focusable m_PreviousFocusedElement;

	private EventModifiers m_CurrentModifiers;

	private int m_LastMousePressButton;

	private float m_NextMousePressTime;

	private int m_LastMouseClickCount;

	private Vector2 m_LastMousePosition;

	private bool m_MouseProcessedAtLeastOnce;

	private int m_ConsecutiveMoveCount;

	private Vector2 m_LastMoveVector;

	private float m_PrevActionTime;

	private bool m_IsMoveFromKeyboard;

	private bool isAppFocused => false;

	internal IInput input => null;

	public BaseRuntimePanel focusedPanel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private IInput GetDefaultInput()
	{
		return null;
	}

	private bool ShouldIgnoreEventsOnAppNotFocused()
	{
		return false;
	}

	public void Update(UpdateMode updateMode = UpdateMode.Always)
	{
	}

	internal FocusBasedEventSequenceContext FocusBasedEventSequence()
	{
		return default(FocusBasedEventSequenceContext);
	}

	private void SendIMGUIEvents()
	{
	}

	private void ProcessMouseEvents()
	{
	}

	private void SendInputEvents()
	{
	}

	internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt)
	{
	}

	internal void SendFocusBasedEvent<TArg>(Func<TArg, EventBase> evtFactory, TArg arg)
	{
	}

	private void SendPositionBasedEvent<TArg>(Vector3 mousePosition, Vector3 delta, int pointerId, int? targetDisplay, Func<Vector3, Vector3, TArg, EventBase> evtFactory, TArg arg, bool deselectIfNoTarget = false)
	{
	}

	private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel)
	{
	}

	private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers)
	{
		return null;
	}

	private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers)
	{
		return null;
	}

	private bool ProcessTouchEvents()
	{
		return false;
	}

	private bool ProcessPenEvents()
	{
		return false;
	}

	private Vector2 GetRawMoveVector()
	{
		return default(Vector2);
	}

	private bool ShouldSendMoveFromInput()
	{
		return false;
	}

	private void ProcessTabEvent(Event e, EventModifiers modifiers)
	{
	}
}
