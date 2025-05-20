using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
public class Cursor
{
	public static bool visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static CursorLockMode lockState
	{
		get
		{
			return default(CursorLockMode);
		}
		set
		{
		}
	}

	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
	{
	}

	private static void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode)
	{
	}
}
