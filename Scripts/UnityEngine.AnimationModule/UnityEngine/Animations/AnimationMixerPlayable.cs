using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable>
{
	private PlayableHandle m_Handle;

	private static readonly AnimationMixerPlayable m_NullPlayable;

	public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0)
	{
		return default(AnimationMixerPlayable);
	}

	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0)
	{
		return default(PlayableHandle);
	}

	internal AnimationMixerPlayable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public static implicit operator Playable(AnimationMixerPlayable playable)
	{
		return default(Playable);
	}

	public bool Equals(AnimationMixerPlayable other)
	{
		return false;
	}

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
	{
		return false;
	}

	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
	{
		return false;
	}
}
