using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIClip.h")]
[NativeHeader("Modules/IMGUI/GUIState.h")]
internal sealed class GUIClip
{
	internal struct ParentClipScope : IDisposable
	{
		private bool m_Disposed;

		public ParentClipScope(Matrix4x4 objectTransform, Rect clipRect)
		{
			m_Disposed = false;
		}

		public void Dispose()
		{
		}
	}

	internal static Rect visibleRect
	{
		[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetVisibleRect")]
		get
		{
			return default(Rect);
		}
	}

	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
	{
	}

	internal static void Internal_Pop()
	{
	}

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetCount")]
	internal static int Internal_GetCount()
	{
		return 0;
	}

	[FreeFunction("GetGUIState().m_CanvasGUIState.m_GUIClipState.GetUserMatrix")]
	internal static Matrix4x4 GetMatrix()
	{
		return default(Matrix4x4);
	}

	internal static void SetMatrix(Matrix4x4 m)
	{
	}

	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect)
	{
	}

	internal static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect)
	{
	}

	internal static void Internal_PopParentClip()
	{
	}

	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
	{
	}

	internal static void Pop()
	{
	}

	[SpecialName]
	private static void get_visibleRect_Injected(out Rect ret)
	{
		ret = default(Rect);
	}

	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset)
	{
	}

	private static void GetMatrix_Injected(out Matrix4x4 ret)
	{
		ret = default(Matrix4x4);
	}

	private static void SetMatrix_Injected(ref Matrix4x4 m)
	{
	}

	private static void Internal_PushParentClip_Injected(ref Matrix4x4 renderTransform, ref Matrix4x4 inputTransform, ref Rect clipRect)
	{
	}
}
