using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
public class GUILayoutUtility
{
	[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
	internal sealed class LayoutCache
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int _003Cid_003Ek__BackingField;

		internal GUILayoutGroup topLevel;

		internal GenericStack layoutGroups;

		internal GUILayoutGroup windows;

		private int id
		{
			[CompilerGenerated]
			set
			{
				_003Cid_003Ek__BackingField = value;
			}
		}

		internal LayoutCache(int instanceID = -1)
		{
		}

		public void ResetCursor()
		{
		}
	}

	private static readonly Dictionary<int, LayoutCache> s_StoredLayouts;

	private static readonly Dictionary<int, LayoutCache> s_StoredWindows;

	internal static LayoutCache current;

	internal static readonly Rect kDummyRect;

	private static GUIStyle s_SpaceStyle;

	internal static int unbalancedgroupscount { get; set; }

	internal static GUIStyle spaceStyle => null;

	private static Rect Internal_GetWindowRect(int windowID)
	{
		return default(Rect);
	}

	private static void Internal_MoveWindow(int windowID, Rect r)
	{
	}

	internal static LayoutCache GetLayoutCache(int instanceID, bool isWindow)
	{
		return null;
	}

	internal static LayoutCache SelectIDList(int instanceID, bool isWindow)
	{
		return null;
	}

	internal static void RemoveSelectedIdList(int instanceID, bool isWindow)
	{
	}

	internal static void Begin(int instanceID)
	{
	}

	internal static void BeginContainer(LayoutCache cache)
	{
	}

	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options)
	{
	}

	internal static void Layout()
	{
	}

	internal static void LayoutFromEditorWindow()
	{
	}

	internal static void LayoutFromContainer(float w, float h)
	{
	}

	internal static void LayoutFreeGroup(GUILayoutGroup toplevel)
	{
	}

	private static void LayoutSingleGroup(GUILayoutGroup i)
	{
	}

	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType)
	{
		return null;
	}

	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType)
	{
		return null;
	}

	internal static void EndLayoutGroup()
	{
	}

	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType)
	{
		return null;
	}

	internal static void EndLayoutArea()
	{
	}

	public static Rect GetRect(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		return default(Rect);
	}

	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options)
	{
		return default(Rect);
	}

	public static Rect GetRect(float width, float height, GUIStyle style, params GUILayoutOption[] options)
	{
		return default(Rect);
	}

	private static Rect DoGetRect(float minWidth, float maxWidth, float minHeight, float maxHeight, GUIStyle style, GUILayoutOption[] options)
	{
		return default(Rect);
	}

	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret)
	{
		ret = default(Rect);
	}

	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r)
	{
	}
}
