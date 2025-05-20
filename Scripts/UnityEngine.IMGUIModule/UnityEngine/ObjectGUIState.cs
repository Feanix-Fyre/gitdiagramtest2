using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/IMGUI/GUIState.h")]
internal class ObjectGUIState : IDisposable
{
	internal IntPtr m_Ptr;

	public void Dispose()
	{
	}

	~ObjectGUIState()
	{
	}

	private void Destroy()
	{
	}

	private static IntPtr Internal_Create()
	{
		return (IntPtr)0;
	}

	[NativeMethod(IsThreadSafe = true)]
	private static void Internal_Destroy(IntPtr ptr)
	{
	}
}
