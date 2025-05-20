using System;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
public class TouchScreenKeyboard
{
	public enum Status
	{
		Visible = 0,
		Done = 1,
		Canceled = 2,
		LostFocus = 3
	}

	[NonSerialized]
	internal IntPtr m_Ptr;

	public static bool isSupported => false;

	internal static bool disableInPlaceEditing { get; }

	public static bool isInPlaceEditingAllowed => false;

	public string text
	{
		[NativeName("GetText")]
		get
		{
			return null;
		}
		[NativeName("SetText")]
		set
		{
		}
	}

	public static bool hideInput
	{
		[NativeName("SetInputHidden")]
		set
		{
		}
	}

	public bool active
	{
		[NativeName("IsActive")]
		get
		{
			return false;
		}
		[NativeName("SetActive")]
		set
		{
		}
	}

	public Status status
	{
		[NativeName("GetKeyboardStatus")]
		get
		{
			return default(Status);
		}
	}

	public int characterLimit
	{
		[NativeName("SetCharacterLimit")]
		set
		{
		}
	}

	public bool canGetSelection
	{
		[NativeName("CanGetSelection")]
		get
		{
			return false;
		}
	}

	public bool canSetSelection
	{
		[NativeName("CanSetSelection")]
		get
		{
			return false;
		}
	}

	public RangeInt selection
	{
		get
		{
			return default(RangeInt);
		}
		set
		{
		}
	}

	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = true)]
	private static void Internal_Destroy(IntPtr ptr)
	{
	}

	private void Destroy()
	{
	}

	~TouchScreenKeyboard()
	{
	}

	public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
	{
	}

	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder)
	{
		return (IntPtr)0;
	}

	public static TouchScreenKeyboard Open(string text, [DefaultValue("TouchScreenKeyboardType.Default")] TouchScreenKeyboardType keyboardType, [DefaultValue("true")] bool autocorrection, [DefaultValue("false")] bool multiline, [DefaultValue("false")] bool secure, [DefaultValue("false")] bool alert, [DefaultValue("\"\"")] string textPlaceholder, [DefaultValue("0")] int characterLimit)
	{
		return null;
	}

	[ExcludeFromDocs]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
	{
		return null;
	}

	private static void GetSelection(out int start, out int length)
	{
		start = default(int);
		length = default(int);
	}

	private static void SetSelection(int start, int length)
	{
	}
}
