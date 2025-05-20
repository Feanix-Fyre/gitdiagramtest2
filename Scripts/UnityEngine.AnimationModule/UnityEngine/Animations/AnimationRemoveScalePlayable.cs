using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationRemoveScalePlayableBindings", StaticAccessorType.DoubleColon)]
internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable>
{
	private PlayableHandle m_Handle;

	private static readonly AnimationRemoveScalePlayable m_NullPlayable;

	public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount)
	{
		return default(AnimationRemoveScalePlayable);
	}

	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount)
	{
		return default(PlayableHandle);
	}

	internal AnimationRemoveScalePlayable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public static implicit operator Playable(AnimationRemoveScalePlayable playable)
	{
		return default(Playable);
	}

	public bool Equals(AnimationRemoveScalePlayable other)
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
