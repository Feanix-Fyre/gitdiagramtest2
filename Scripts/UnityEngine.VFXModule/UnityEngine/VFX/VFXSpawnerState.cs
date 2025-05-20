using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX;

[StructLayout((LayoutKind)0)]
[NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
[RequiredByNativeCode]
public sealed class VFXSpawnerState : IDisposable
{
	private IntPtr m_Ptr;

	private bool m_Owner;

	private VFXEventAttribute m_WrapEventAttribute;

	internal VFXSpawnerState(IntPtr ptr, bool owner)
	{
	}

	[RequiredByNativeCode]
	internal static VFXSpawnerState CreateSpawnerStateWrapper()
	{
		return null;
	}

	private void PrepareWrapper()
	{
	}

	[RequiredByNativeCode]
	internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute)
	{
	}

	private void Release()
	{
	}

	~VFXSpawnerState()
	{
	}

	public void Dispose()
	{
	}

	[NativeMethod(IsThreadSafe = true)]
	private static void Internal_Destroy(IntPtr ptr)
	{
	}
}
