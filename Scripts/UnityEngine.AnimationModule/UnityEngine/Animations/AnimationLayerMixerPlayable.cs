using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[RequiredByNativeCode]
[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable>
{
	private PlayableHandle m_Handle;

	private static readonly AnimationLayerMixerPlayable m_NullPlayable;

	public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount, bool singleLayerOptimization)
	{
		return default(AnimationLayerMixerPlayable);
	}

	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0)
	{
		return default(PlayableHandle);
	}

	internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public static implicit operator Playable(AnimationLayerMixerPlayable playable)
	{
		return default(Playable);
	}

	public bool Equals(AnimationLayerMixerPlayable other)
	{
		return false;
	}

	public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask)
	{
	}

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
	{
		return false;
	}

	[NativeThrows]
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value)
	{
	}

	[NativeThrows]
	private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask)
	{
	}

	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
	{
		return false;
	}
}
