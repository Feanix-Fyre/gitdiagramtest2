using UnityEngine.Bindings;

namespace UnityEngine.Internal;

[NativeHeader("Runtime/Input/InputBindings.h")]
internal static class InputUnsafeUtility
{
	[NativeThrows]
	internal unsafe static bool GetKeyString__Unmanaged(byte* name, int nameLen)
	{
		return false;
	}

	[NativeThrows]
	internal unsafe static bool GetKeyUpString__Unmanaged(byte* name, int nameLen)
	{
		return false;
	}

	[NativeThrows]
	internal static bool GetKeyDownString(string name)
	{
		return false;
	}

	[NativeThrows]
	internal unsafe static bool GetKeyDownString__Unmanaged(byte* name, int nameLen)
	{
		return false;
	}

	[NativeThrows]
	internal static float GetAxis(string axisName)
	{
		return 0f;
	}

	[NativeThrows]
	internal unsafe static float GetAxis__Unmanaged(byte* axisName, int axisNameLen)
	{
		return 0f;
	}

	[NativeThrows]
	internal static float GetAxisRaw(string axisName)
	{
		return 0f;
	}

	[NativeThrows]
	internal unsafe static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen)
	{
		return 0f;
	}

	[NativeThrows]
	internal static bool GetButton(string buttonName)
	{
		return false;
	}

	[NativeThrows]
	internal unsafe static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen)
	{
		return false;
	}

	[NativeThrows]
	internal static bool GetButtonDown(string buttonName)
	{
		return false;
	}

	[NativeThrows]
	internal unsafe static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen)
	{
		return 0;
	}

	[NativeThrows]
	internal unsafe static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen)
	{
		return false;
	}
}
