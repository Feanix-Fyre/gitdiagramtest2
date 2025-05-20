using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal static class UIEventRegistration
{
	private static List<IUIElementsUtility> s_Utilities;

	static UIEventRegistration()
	{
	}

	internal static void RegisterUIElementSystem(IUIElementsUtility utility)
	{
	}

	private static void TakeCapture()
	{
	}

	private static void ReleaseCapture()
	{
	}

	private static bool EndContainerGUIFromException(Exception exception)
	{
		return false;
	}

	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr)
	{
		return false;
	}

	private static void CleanupRoots()
	{
	}

	internal static void MakeCurrentIMGUIContainerDirty()
	{
	}
}
