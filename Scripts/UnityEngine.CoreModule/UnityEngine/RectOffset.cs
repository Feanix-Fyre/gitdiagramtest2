using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[Serializable]
[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/IMGUI/GUIStyle.h")]
[UsedByNativeCode]
public class RectOffset : IFormattable
{
	[NonSerialized]
	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
	internal IntPtr m_Ptr;

	private readonly object m_SourceStyle;

	[NativeProperty("left", false, TargetType.Field)]
	public int left
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[NativeProperty("right", false, TargetType.Field)]
	public int right
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[NativeProperty("top", false, TargetType.Field)]
	public int top
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[NativeProperty("bottom", false, TargetType.Field)]
	public int bottom
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int horizontal => 0;

	public int vertical => 0;

	public RectOffset()
	{
	}

	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
	internal RectOffset(object sourceStyle, IntPtr source)
	{
	}

	~RectOffset()
	{
	}

	public RectOffset(int left, int right, int top, int bottom)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	private void Destroy()
	{
	}

	[ThreadAndSerializationSafe]
	private static IntPtr InternalCreate()
	{
		return (IntPtr)0;
	}

	[ThreadAndSerializationSafe]
	private static void InternalDestroy(IntPtr ptr)
	{
	}

	public Rect Remove(Rect rect)
	{
		return default(Rect);
	}

	private void Remove_Injected(ref Rect rect, out Rect ret)
	{
		ret = default(Rect);
	}
}
