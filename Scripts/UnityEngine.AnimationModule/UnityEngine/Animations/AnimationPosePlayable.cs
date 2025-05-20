using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
[StaticAccessor("AnimationPosePlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
internal struct AnimationPosePlayable : IPlayable, IEquatable<AnimationPosePlayable>
{
	private PlayableHandle m_Handle;

	private static readonly AnimationPosePlayable m_NullPlayable;

	internal AnimationPosePlayable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public bool Equals(AnimationPosePlayable other)
	{
		return false;
	}
}
