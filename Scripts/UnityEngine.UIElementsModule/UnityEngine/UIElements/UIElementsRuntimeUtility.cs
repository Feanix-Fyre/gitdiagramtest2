using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Profiling;

namespace UnityEngine.UIElements;

internal static class UIElementsRuntimeUtility
{
	public delegate BaseRuntimePanel CreateRuntimePanelDelegate(ScriptableObject ownerObject);

	private static bool s_RegisteredPlayerloopCallback;

	private static List<Panel> s_SortedRuntimePanels;

	private static bool s_PanelOrderingDirty;

	internal static int s_ResolvedSortingIndexMax;

	internal static readonly string s_RepaintProfilerMarkerName;

	private static readonly ProfilerMarker s_RepaintProfilerMarker;

	private static int currentOverlayIndex;

	private static DefaultEventSystem s_DefaultEventSystem;

	private static List<PanelSettings> s_PotentiallyEmptyPanelSettings;

	internal static Object activeEventSystem { get; private set; }

	internal static bool useDefaultEventSystem => false;

	internal static DefaultEventSystem defaultEventSystem => null;

	public static event Action<BaseRuntimePanel> onCreatePanel
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	static UIElementsRuntimeUtility()
	{
	}

	public static EventBase CreateEvent(Event systemEvent)
	{
		return null;
	}

	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate)
	{
		return null;
	}

	public static void DisposeRuntimePanel(ScriptableObject ownerObject)
	{
	}

	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel)
	{
	}

	private static void RemoveCachedPanelInternal(int instanceID)
	{
	}

	public static void RepaintOffscreenPanels()
	{
	}

	public static void RepaintOverlayPanel(BaseRuntimePanel panel)
	{
	}

	internal static void BeginRenderOverlays(int displayIndex)
	{
	}

	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority)
	{
	}

	internal static void EndRenderOverlays(int displayIndex)
	{
	}

	public static void RegisterEventSystem(Object eventSystem)
	{
	}

	public static void UnregisterEventSystem(Object eventSystem)
	{
	}

	public static void UpdateRuntimePanels()
	{
	}

	internal static void MarkPotentiallyEmpty(PanelSettings settings)
	{
	}

	internal static void RemoveUnusedPanels()
	{
	}

	public static void RegisterPlayerloopCallback()
	{
	}

	public static void UnregisterPlayerloopCallback()
	{
	}

	internal static void SetPanelOrderingDirty()
	{
	}

	internal static List<Panel> GetSortedPlayerPanels()
	{
		return null;
	}

	private static void SortPanels()
	{
	}

	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int? targetDisplay)
	{
		targetDisplay = null;
		return default(Vector2);
	}

	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out int? targetDisplay)
	{
		targetDisplay = null;
		return default(Vector2);
	}

	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay)
	{
		return default(Vector2);
	}

	internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta)
	{
		return default(Vector2);
	}
}
