using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[Serializable]
[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
public sealed class GUIStyleState
{
	[NonSerialized]
	internal IntPtr m_Ptr;

	private readonly GUIStyle m_SourceStyle;

	[NativeProperty("Background", false, TargetType.Function)]
	public Texture2D background
	{
		set
		{
		}
	}

	[NativeProperty("textColor", false, TargetType.Field)]
	public Color textColor
	{
		set
		{
		}
	}

	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = true)]
	private static IntPtr Init()
	{
		return (IntPtr)0;
	}

	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
	private void Cleanup()
	{
	}

	public GUIStyleState()
	{
	}

	private GUIStyleState(GUIStyle sourceStyle, IntPtr source)
	{
	}

	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
	{
		return null;
	}

	~GUIStyleState()
	{
	}

	[SpecialName]
	private void set_textColor_Injected(ref Color value)
	{
	}
}
