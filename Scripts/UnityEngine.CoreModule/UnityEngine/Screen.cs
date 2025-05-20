using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType.Dot)]
public sealed class Screen
{
	public static int width
	{
		[NativeMethod(Name = "GetWidth", IsThreadSafe = true)]
		get
		{
			return 0;
		}
	}

	public static int height
	{
		[NativeMethod(Name = "GetHeight", IsThreadSafe = true)]
		get
		{
			return 0;
		}
	}

	public static float dpi
	{
		[NativeName("GetDPI")]
		get
		{
			return 0f;
		}
	}

	public static ScreenOrientation orientation => default(ScreenOrientation);

	public static bool fullScreen
	{
		[NativeName("IsFullscreen")]
		get
		{
			return false;
		}
	}

	public static FullScreenMode fullScreenMode
	{
		[NativeName("RequestSetFullscreenModeFromScript")]
		set
		{
		}
	}

	public static DisplayInfo mainWindowDisplayInfo => default(DisplayInfo);

	public static Resolution[] resolutions
	{
		[FreeFunction("ScreenScripting::GetResolutions")]
		get
		{
			return null;
		}
	}

	private static ScreenOrientation GetScreenOrientation()
	{
		return default(ScreenOrientation);
	}

	[NativeName("RequestResolution")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("SetResolution(int, int, bool, int) is obsolete. Use SetResolution(int, int, FullScreenMode, RefreshRate) instead.")]
	public static void SetResolution(int width, int height, bool fullscreen, [UnityEngine.Internal.DefaultValue("0")] int preferredRefreshRate)
	{
	}

	public static void SetResolution(int width, int height, bool fullscreen)
	{
	}

	public static void GetDisplayLayout(List<DisplayInfo> displayLayout)
	{
	}

	public static AsyncOperation MoveMainWindowTo(in DisplayInfo display, Vector2Int position)
	{
		return null;
	}

	[FreeFunction("GetMainWindowDisplayInfo")]
	private static DisplayInfo GetMainWindowDisplayInfo()
	{
		return default(DisplayInfo);
	}

	[FreeFunction("GetDisplayLayout")]
	private static void GetDisplayLayoutImpl(List<DisplayInfo> displayLayout)
	{
	}

	[FreeFunction("MoveMainWindow")]
	private static AsyncOperation MoveMainWindowImpl(in DisplayInfo display, Vector2Int position)
	{
		return null;
	}

	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
	{
	}

	private static void GetMainWindowDisplayInfo_Injected(out DisplayInfo ret)
	{
		ret = default(DisplayInfo);
	}

	private static AsyncOperation MoveMainWindowImpl_Injected(in DisplayInfo display, ref Vector2Int position)
	{
		return null;
	}
}
