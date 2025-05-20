using System;

namespace UnityEngine.UIElements;

internal static class PointerDeviceState
{
	[Flags]
	internal enum LocationFlag
	{
		None = 0,
		OutsidePanel = 1
	}

	private struct PointerLocation
	{
		internal Vector2 Position { get; private set; }

		internal IPanel Panel { get; private set; }

		internal LocationFlag Flags { get; private set; }

		internal void SetLocation(Vector2 position, IPanel panel)
		{
		}
	}

	private static PointerLocation[] s_PlayerPointerLocations;

	private static int[] s_PressedButtons;

	private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture;

	internal static void RemovePanelData(IPanel panel)
	{
	}

	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType)
	{
	}

	public static void PressButton(int pointerId, int buttonId)
	{
	}

	public static void ReleaseButton(int pointerId, int buttonId)
	{
	}

	public static void ReleaseAllButtons(int pointerId)
	{
	}

	public static Vector2 GetPointerPosition(int pointerId, ContextType contextType)
	{
		return default(Vector2);
	}

	public static IPanel GetPanel(int pointerId, ContextType contextType)
	{
		return null;
	}

	private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag)
	{
		return false;
	}

	public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag)
	{
		return false;
	}

	public static int GetPressedButtons(int pointerId)
	{
		return 0;
	}

	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId)
	{
		return false;
	}

	internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel)
	{
	}

	internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId)
	{
		return null;
	}
}
