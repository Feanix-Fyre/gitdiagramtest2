using System.Diagnostics;

namespace UnityEngine.InputSystem.EnhancedTouch;

public static class EnhancedTouchSupport
{
	private static int s_Enabled;

	private static InputSettings.UpdateMode s_UpdateMode;

	public static bool enabled => false;

	public static void Enable()
	{
	}

	public static void Disable()
	{
	}

	internal static void Reset()
	{
	}

	private static void SetUpState()
	{
	}

	internal static void TearDownState()
	{
	}

	private static void OnDeviceChange(InputDevice device, InputDeviceChange change)
	{
	}

	private static void OnSettingsChange()
	{
	}

	[Conditional("DEVELOPMENT_BUILD")]
	[Conditional("UNITY_EDITOR")]
	internal static void CheckEnabled()
	{
	}
}
