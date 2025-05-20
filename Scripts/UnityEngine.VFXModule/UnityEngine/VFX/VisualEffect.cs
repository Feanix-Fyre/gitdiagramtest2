using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX;

[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectBindings.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/VFX/Public/VisualEffect.h")]
public class VisualEffect : Behaviour
{
	private VFXEventAttribute m_cachedEventAttribute;

	public Action<VFXOutputEventArgs> outputEventReceived;

	public VisualEffectAsset visualEffectAsset => null;

	public VFXEventAttribute CreateVFXEventAttribute()
	{
		return null;
	}

	[RequiredByNativeCode]
	private static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source)
	{
		return null;
	}

	[RequiredByNativeCode]
	private static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId)
	{
	}
}
