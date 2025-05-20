using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", StaticAccessorType.DoubleColon)]
[RequiredByNativeCode]
internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable>
{
	private PlayableHandle m_Handle;

	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable;

	public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph)
	{
		return default(AnimationMotionXToDeltaPlayable);
	}

	private static PlayableHandle CreateHandle(PlayableGraph graph)
	{
		return default(PlayableHandle);
	}

	private AnimationMotionXToDeltaPlayable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public static implicit operator Playable(AnimationMotionXToDeltaPlayable playable)
	{
		return default(Playable);
	}

	public bool Equals(AnimationMotionXToDeltaPlayable other)
	{
		return false;
	}

	public void SetAbsoluteMotion(bool value)
	{
	}

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
	{
		return false;
	}

	[NativeThrows]
	private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value)
	{
	}

	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle)
	{
		return false;
	}
}
