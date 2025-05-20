using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable>
{
	private PlayableHandle m_Handle;

	public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip)
	{
		return default(AnimationClipPlayable);
	}

	private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip)
	{
		return default(PlayableHandle);
	}

	internal AnimationClipPlayable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public static implicit operator Playable(AnimationClipPlayable playable)
	{
		return default(Playable);
	}

	public bool Equals(AnimationClipPlayable other)
	{
		return false;
	}

	public void SetApplyFootIK(bool value)
	{
	}

	internal void SetRemoveStartOffset(bool value)
	{
	}

	internal void SetOverrideLoopTime(bool value)
	{
	}

	internal void SetLoopTime(bool value)
	{
	}

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
	{
		return false;
	}

	[NativeThrows]
	private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value)
	{
	}

	[NativeThrows]
	private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value)
	{
	}

	[NativeThrows]
	private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value)
	{
	}

	[NativeThrows]
	private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value)
	{
	}

	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle)
	{
		return false;
	}
}
