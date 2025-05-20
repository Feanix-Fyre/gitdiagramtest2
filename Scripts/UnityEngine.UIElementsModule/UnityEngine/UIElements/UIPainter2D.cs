using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/Renderer/UIPainter2D.bindings.h")]
internal static class UIPainter2D
{
	public static IntPtr Create(bool computeBBox = false)
	{
		return (IntPtr)0;
	}

	public static void Destroy(IntPtr handle)
	{
	}

	public static void Reset(IntPtr handle)
	{
	}
}
