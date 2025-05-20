using System;

namespace UnityEngine.InputSystem.LowLevel;

internal class NativeInputRuntime : IInputRuntime
{
	public static readonly NativeInputRuntime instance;

	private bool m_RunInBackground;

	private Action m_ShutdownMethod;

	private InputUpdateDelegate m_OnUpdate;

	private Action<InputUpdateType> m_OnBeforeUpdate;

	private Func<InputUpdateType, bool> m_OnShouldRunUpdate;

	private float m_PollingFrequency;

	private bool m_DidCallOnShutdown;

	private Action<bool> m_FocusChangedMethod;

	public InputUpdateDelegate onUpdate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<InputUpdateType> onBeforeUpdate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Func<InputUpdateType, bool> onShouldRunUpdate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<int, string> onDeviceDiscovered
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action onShutdown
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Action<bool> onPlayerFocusChanged
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isPlayerFocused => false;

	public float pollingFrequency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public double currentTime => 0.0;

	public double currentTimeForFixedUpdate => 0.0;

	public double currentTimeOffsetToRealtimeSinceStartup => 0.0;

	public float unscaledGameTime => 0f;

	public bool runInBackground
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector2 screenSize => default(Vector2);

	public ScreenOrientation screenOrientation => default(ScreenOrientation);

	public bool isInBatchMode => false;

	public int AllocateDeviceId()
	{
		return 0;
	}

	public void Update(InputUpdateType updateType)
	{
	}

	public unsafe void QueueEvent(InputEvent* ptr)
	{
	}

	public unsafe long DeviceCommand(int deviceId, InputDeviceCommand* commandPtr)
	{
		return 0L;
	}

	private void OnShutdown()
	{
	}

	private bool OnWantsToShutdown()
	{
		return false;
	}

	private void OnFocusChanged(bool focus)
	{
	}

	public void RegisterAnalyticsEvent(string name, int maxPerHour, int maxPropertiesPerEvent)
	{
	}

	public void SendAnalyticsEvent(string name, object data)
	{
	}
}
