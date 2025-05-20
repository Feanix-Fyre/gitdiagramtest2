using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[Serializable]
[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[NativeHeader("IMGUIScriptingClasses.h")]
[RequiredByNativeCode]
public sealed class GUIStyle
{
	[NonSerialized]
	internal IntPtr m_Ptr;

	[NonSerialized]
	private GUIStyleState m_Normal;

	[NonSerialized]
	private GUIStyleState m_Hover;

	[NonSerialized]
	private GUIStyleState m_Active;

	[NonSerialized]
	private GUIStyleState m_Focused;

	[NonSerialized]
	private GUIStyleState m_OnNormal;

	[NonSerialized]
	private GUIStyleState m_OnHover;

	[NonSerialized]
	private GUIStyleState m_OnActive;

	[NonSerialized]
	private GUIStyleState m_OnFocused;

	[NonSerialized]
	private RectOffset m_Border;

	[NonSerialized]
	private RectOffset m_Padding;

	[NonSerialized]
	private RectOffset m_Margin;

	[NonSerialized]
	private RectOffset m_Overflow;

	[NonSerialized]
	private string m_Name;

	internal static bool showKeyboardFocus;

	private static GUIStyle s_None;

	[NativeProperty("Name", false, TargetType.Function)]
	internal string rawName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[NativeProperty("Font", false, TargetType.Function)]
	public Font font
	{
		set
		{
		}
	}

	[NativeProperty("m_ImagePosition", false, TargetType.Field)]
	public ImagePosition imagePosition => default(ImagePosition);

	[NativeProperty("m_Alignment", false, TargetType.Field)]
	public TextAnchor alignment
	{
		set
		{
		}
	}

	[NativeProperty("m_WordWrap", false, TargetType.Field)]
	public bool wordWrap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty("m_FixedWidth", false, TargetType.Field)]
	public float fixedWidth => 0f;

	[NativeProperty("m_FixedHeight", false, TargetType.Field)]
	public float fixedHeight => 0f;

	[NativeProperty("m_StretchWidth", false, TargetType.Field)]
	public bool stretchWidth
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty("m_StretchHeight", false, TargetType.Field)]
	public bool stretchHeight
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty("m_FontSize", false, TargetType.Field)]
	public int fontSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[NativeProperty("m_FontStyle", false, TargetType.Field)]
	public FontStyle fontStyle
	{
		set
		{
		}
	}

	[NativeProperty("m_RichText", false, TargetType.Field)]
	public bool richText
	{
		set
		{
		}
	}

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GUIStyleState normal => null;

	public RectOffset border
	{
		set
		{
		}
	}

	public RectOffset margin
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RectOffset padding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static GUIStyle none => null;

	public bool isHeightDependantOnWidth => false;

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = true)]
	private static IntPtr Internal_Create(GUIStyle self)
	{
		return (IntPtr)0;
	}

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Copy", IsThreadSafe = true)]
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other)
	{
		return (IntPtr)0;
	}

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = true)]
	private static void Internal_Destroy(IntPtr self)
	{
	}

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = true, HasExplicitThis = true)]
	private IntPtr GetStyleStatePtr(int idx)
	{
		return (IntPtr)0;
	}

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = true)]
	private IntPtr GetRectOffsetPtr(int idx)
	{
		return (IntPtr)0;
	}

	[FreeFunction(Name = "GUIStyle_Bindings::AssignRectOffset", HasExplicitThis = true)]
	private void AssignRectOffset(int idx, IntPtr srcRectOffset)
	{
	}

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw", HasExplicitThis = true)]
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
	}

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Draw2", HasExplicitThis = true)]
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
	{
	}

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSize", HasExplicitThis = true)]
	internal Vector2 Internal_CalcSize(GUIContent content)
	{
		return default(Vector2);
	}

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcSizeWithConstraints", HasExplicitThis = true)]
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
	{
		return default(Vector2);
	}

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcHeight", HasExplicitThis = true)]
	private float Internal_CalcHeight(GUIContent content, float width)
	{
		return 0f;
	}

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_CalcMinMaxWidth", HasExplicitThis = true)]
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content)
	{
		return default(Vector2);
	}

	[FreeFunction(Name = "GUIStyle_Bindings::SetMouseTooltip")]
	internal static void SetMouseTooltip(string tooltip, Rect screenRect)
	{
	}

	[FreeFunction(Name = "GUIStyle_Bindings::IsTooltipActive")]
	internal static bool IsTooltipActive(string tooltip)
	{
		return false;
	}

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	internal static void SetDefaultFont(Font font)
	{
	}

	public GUIStyle()
	{
	}

	public GUIStyle(GUIStyle other)
	{
	}

	~GUIStyle()
	{
	}

	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
	}

	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
	}

	public void Draw(Rect position, GUIContent content, int controlID)
	{
	}

	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
	{
	}

	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
	}

	public static implicit operator GUIStyle(string str)
	{
		return null;
	}

	public Vector2 CalcSize(GUIContent content)
	{
		return default(Vector2);
	}

	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
	{
		return default(Vector2);
	}

	public float CalcHeight(GUIContent content, float width)
	{
		return 0f;
	}

	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
	{
		minWidth = default(float);
		maxWidth = default(float);
	}

	public override string ToString()
	{
		return null;
	}

	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
	}

	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on)
	{
	}

	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret)
	{
		ret = default(Vector2);
	}

	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret)
	{
		ret = default(Vector2);
	}

	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret)
	{
		ret = default(Vector2);
	}

	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect)
	{
	}
}
