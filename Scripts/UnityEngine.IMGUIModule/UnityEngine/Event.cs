using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[StaticAccessor("GUIEvent", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/IMGUI/Event.bindings.h")]
public sealed class Event
{
	[NonSerialized]
	internal IntPtr m_Ptr;

	private static Event s_Current;

	private static Event s_MasterEvent;

	[NativeProperty("type", false, TargetType.Field)]
	public EventType rawType => default(EventType);

	[NativeProperty("mousePosition", false, TargetType.Field)]
	public Vector2 mousePosition
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	[NativeProperty("delta", false, TargetType.Field)]
	public Vector2 delta
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	[NativeProperty("pointerType", false, TargetType.Field)]
	public PointerType pointerType => default(PointerType);

	[NativeProperty("button", false, TargetType.Field)]
	public int button => 0;

	[NativeProperty("modifiers", false, TargetType.Field)]
	public EventModifiers modifiers
	{
		get
		{
			return default(EventModifiers);
		}
		set
		{
		}
	}

	[NativeProperty("pressure", false, TargetType.Field)]
	public float pressure => 0f;

	[NativeProperty("twist", false, TargetType.Field)]
	public float twist => 0f;

	[NativeProperty("tilt", false, TargetType.Field)]
	public Vector2 tilt => default(Vector2);

	[NativeProperty("penStatus", false, TargetType.Field)]
	public PenStatus penStatus => default(PenStatus);

	[NativeProperty("clickCount", false, TargetType.Field)]
	public int clickCount => 0;

	[NativeProperty("character", false, TargetType.Field)]
	public char character
	{
		get
		{
			return '\0';
		}
		set
		{
		}
	}

	[NativeProperty("keycode", false, TargetType.Field)]
	public KeyCode keyCode
	{
		get
		{
			return default(KeyCode);
		}
		set
		{
		}
	}

	[NativeProperty("displayIndex", false, TargetType.Field)]
	public int displayIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public EventType type
	{
		[FreeFunction("GUIEvent::GetType", HasExplicitThis = true)]
		get
		{
			return default(EventType);
		}
		[FreeFunction("GUIEvent::SetType", HasExplicitThis = true)]
		set
		{
		}
	}

	public string commandName
	{
		[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = true)]
		get
		{
			return null;
		}
		[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = true)]
		set
		{
		}
	}

	public bool shift => false;

	public bool control => false;

	public bool alt => false;

	public bool command => false;

	public static Event current
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool isKey => false;

	public bool isMouse => false;

	internal bool isDirectManipulationDevice => false;

	[NativeMethod("Use")]
	private void Internal_Use()
	{
	}

	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = true)]
	private static IntPtr Internal_Create(int displayIndex)
	{
		return (IntPtr)0;
	}

	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = true)]
	private static void Internal_Destroy(IntPtr ptr)
	{
	}

	[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = true)]
	public EventType GetTypeForControl(int controlID)
	{
		return default(EventType);
	}

	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = true, HasExplicitThis = true)]
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal void CopyFromPtr(IntPtr ptr)
	{
	}

	public static bool PopEvent([NotNull("ArgumentNullException")] Event outEvent)
	{
		return false;
	}

	private static void Internal_SetNativeEvent(IntPtr ptr)
	{
	}

	[RequiredByNativeCode]
	internal static void Internal_MakeMasterEventCurrent(int displayIndex)
	{
	}

	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal static int GetDoubleClickTime()
	{
		return 0;
	}

	public Event()
	{
	}

	public Event(int displayIndex)
	{
	}

	~Event()
	{
	}

	internal void CopyFrom(Event e)
	{
	}

	public static Event KeyboardEvent(string key)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public void Use()
	{
	}

	[SpecialName]
	private void get_mousePosition_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_mousePosition_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void get_delta_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_delta_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void get_tilt_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}
}
