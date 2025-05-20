using System;
using System.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements;

internal class UIElementsUtility : IUIElementsUtility
{
	private static Stack<IMGUIContainer> s_ContainerStack;

	private static Dictionary<int, Panel> s_UIElementsCache;

	private static Event s_EventInstance;

	internal static Color editorPlayModeTintColor;

	internal static float singleLineHeight;

	private static UIElementsUtility s_Instance;

	internal static List<Panel> s_PanelsIterationList;

	internal static readonly string s_RepaintProfilerMarkerName;

	internal static readonly string s_EventProfilerMarkerName;

	private static readonly ProfilerMarker s_RepaintProfilerMarker;

	private static readonly ProfilerMarker s_EventProfilerMarker;

	internal static char[] s_Modifiers;

	private UIElementsUtility()
	{
	}

	bool IUIElementsUtility.MakeCurrentIMGUIContainerDirty()
	{
		return false;
	}

	bool IUIElementsUtility.TakeCapture()
	{
		return false;
	}

	bool IUIElementsUtility.ReleaseCapture()
	{
		return false;
	}

	bool IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled)
	{
		return false;
	}

	bool IUIElementsUtility.CleanupRoots()
	{
		return false;
	}

	bool IUIElementsUtility.EndContainerGUIFromException(Exception exception)
	{
		return false;
	}

	public static void RegisterCachedPanel(int instanceID, Panel panel)
	{
	}

	public static void RemoveCachedPanel(int instanceID)
	{
	}

	public static bool TryGetPanel(int instanceID, out Panel panel)
	{
		panel = null;
		return false;
	}

	internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container)
	{
	}

	internal static void EndContainerGUI(Event evt, Rect layoutSize)
	{
	}

	internal static EventBase CreateEvent(Event systemEvent)
	{
		return null;
	}

	internal static EventBase CreateEvent(Event systemEvent, EventType eventType)
	{
		return null;
	}

	private static bool DoDispatch(BaseVisualElementPanel panel)
	{
		return false;
	}

	internal static void GetAllPanels(List<Panel> panels, ContextType contextType)
	{
	}

	internal static Dictionary<int, Panel>.Enumerator GetPanelsIterator()
	{
		return default(Dictionary<int, Panel>.Enumerator);
	}

	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite)
	{
		return 0f;
	}

	internal static string ParseMenuName(string menuName)
	{
		return null;
	}
}
