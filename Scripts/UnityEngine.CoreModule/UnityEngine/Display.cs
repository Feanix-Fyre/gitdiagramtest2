using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/DisplayManager.h")]
[UsedByNativeCode]
public class Display
{
	public delegate void DisplaysUpdatedDelegate();

	internal IntPtr nativeDisplay;

	public static Display[] displays;

	private static Display _mainDisplay;

	private static int m_ActiveEditorGameViewTarget;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static DisplaysUpdatedDelegate onDisplaysUpdated;

	public int renderingWidth => 0;

	public int renderingHeight => 0;

	public int systemWidth => 0;

	public int systemHeight => 0;

	public RenderBuffer colorBuffer => default(RenderBuffer);

	public bool active => false;

	public bool requiresSrgbBlitToBackbuffer => false;

	public static Display main => null;

	internal Display()
	{
	}

	internal Display(IntPtr nativeDisplay)
	{
	}

	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
	{
		return default(Vector3);
	}

	[RequiredByNativeCode]
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay)
	{
	}

	[RequiredByNativeCode]
	internal static void FireDisplaysUpdated()
	{
	}

	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h)
	{
		w = default(int);
		h = default(int);
	}

	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h)
	{
		w = default(int);
		h = default(int);
	}

	[FreeFunction("UnityDisplayManager_GetRenderingBuffersWrapper")]
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth)
	{
		color = default(RenderBuffer);
		depth = default(RenderBuffer);
	}

	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
	{
		rx = default(int);
		ry = default(int);
		return 0;
	}

	[FreeFunction("UnityDisplayManager_DisplayActive")]
	private static bool GetActiveImpl(IntPtr nativeDisplay)
	{
		return false;
	}

	[FreeFunction("UnityDisplayManager_RequiresSRGBBlitToBackbuffer")]
	private static bool RequiresSrgbBlitToBackbufferImpl(IntPtr nativeDisplay)
	{
		return false;
	}
}
