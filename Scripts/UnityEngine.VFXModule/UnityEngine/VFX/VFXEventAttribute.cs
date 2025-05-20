using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX;

[StructLayout((LayoutKind)0)]
[RequiredByNativeCode]
[NativeType(Header = "Modules/VFX/Public/VFXEventAttribute.h")]
public sealed class VFXEventAttribute : IDisposable
{
	private IntPtr m_Ptr;

	private bool m_Owner;

	private VisualEffectAsset m_VfxAsset;

	private VFXEventAttribute(IntPtr ptr, bool owner, VisualEffectAsset vfxAsset)
	{
	}

	internal static VFXEventAttribute CreateEventAttributeWrapper()
	{
		return null;
	}

	internal void SetWrapValue(IntPtr ptrToEventAttribute)
	{
	}

	internal static IntPtr Internal_Create()
	{
		return (IntPtr)0;
	}

	internal static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset)
	{
		return null;
	}

	internal void Internal_InitFromAsset(VisualEffectAsset vfxAsset)
	{
	}

	private void Release()
	{
	}

	~VFXEventAttribute()
	{
	}

	public void Dispose()
	{
	}

	[NativeMethod(IsThreadSafe = true)]
	internal static void Internal_Destroy(IntPtr ptr)
	{
	}
}
