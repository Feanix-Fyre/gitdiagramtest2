using System;
using System.Collections.Generic;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class InputSettings : ScriptableObject
{
	public enum UpdateMode
	{
		ProcessEventsInDynamicUpdate = 1,
		ProcessEventsInFixedUpdate = 2,
		ProcessEventsManually = 3
	}

	public enum BackgroundBehavior
	{
		ResetAndDisableNonBackgroundDevices = 0,
		ResetAndDisableAllDevices = 1,
		IgnoreFocus = 2
	}

	public enum EditorInputBehaviorInPlayMode
	{
		PointersAndKeyboardsRespectGameViewFocus = 0,
		AllDevicesRespectGameViewFocus = 1,
		AllDeviceInputAlwaysGoesToGameView = 2
	}

	[Tooltip("Determine which type of devices are used by the application. By default, this is empty meaning that all devices recognized by Unity will be used. Restricting the set of supported devices will make only those devices appear in the input system.")]
	[SerializeField]
	private string[] m_SupportedDevices;

	[Tooltip("Determine when Unity processes events. By default, accumulated input events are flushed out before each fixed update and before each dynamic update. This setting can be used to restrict event processing to only where the application needs it.")]
	[SerializeField]
	private UpdateMode m_UpdateMode;

	[SerializeField]
	private int m_MaxEventBytesPerUpdate;

	[SerializeField]
	private int m_MaxQueuedEventsPerUpdate;

	[SerializeField]
	private bool m_CompensateForScreenOrientation;

	[SerializeField]
	private BackgroundBehavior m_BackgroundBehavior;

	[SerializeField]
	private EditorInputBehaviorInPlayMode m_EditorInputBehaviorInPlayMode;

	[SerializeField]
	private float m_DefaultDeadzoneMin;

	[SerializeField]
	private float m_DefaultDeadzoneMax;

	[Min(0.0001f)]
	[SerializeField]
	private float m_DefaultButtonPressPoint;

	[SerializeField]
	private float m_ButtonReleaseThreshold;

	[SerializeField]
	private float m_DefaultTapTime;

	[SerializeField]
	private float m_DefaultSlowTapTime;

	[SerializeField]
	private float m_DefaultHoldTime;

	[SerializeField]
	private float m_TapRadius;

	[SerializeField]
	private float m_MultiTapDelayTime;

	[SerializeField]
	private bool m_DisableRedundantEventsMerging;

	[SerializeField]
	private bool m_ShortcutKeysConsumeInputs;

	[NonSerialized]
	internal HashSet<string> m_FeatureFlags;

	internal static bool optimizedControlsFeatureEnabled;

	internal static bool readValueCachingFeatureEnabled;

	internal static bool paranoidReadValueCachingChecksEnabled;

	internal const int s_OldUnsupportedFixedAndDynamicUpdateSetting = 0;

	public UpdateMode updateMode
	{
		get
		{
			return default(UpdateMode);
		}
		set
		{
		}
	}

	public bool compensateForScreenOrientation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("filterNoiseOnCurrent is deprecated, filtering of noise is always enabled now.", false)]
	public bool filterNoiseOnCurrent
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float defaultDeadzoneMin
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float defaultDeadzoneMax
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float defaultButtonPressPoint
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float buttonReleaseThreshold
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float defaultTapTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float defaultSlowTapTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float defaultHoldTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float tapRadius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float multiTapDelayTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public BackgroundBehavior backgroundBehavior
	{
		get
		{
			return default(BackgroundBehavior);
		}
		set
		{
		}
	}

	public EditorInputBehaviorInPlayMode editorInputBehaviorInPlayMode
	{
		get
		{
			return default(EditorInputBehaviorInPlayMode);
		}
		set
		{
		}
	}

	public int maxEventBytesPerUpdate
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int maxQueuedEventsPerUpdate
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ReadOnlyArray<string> supportedDevices
	{
		get
		{
			return default(ReadOnlyArray<string>);
		}
		set
		{
		}
	}

	public bool disableRedundantEventsMerging
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool shortcutKeysConsumeInput
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetInternalFeatureFlag(string featureName, bool enabled)
	{
	}

	internal bool IsFeatureEnabled(string featureName)
	{
		return false;
	}

	internal void OnChange()
	{
	}
}
