using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[StaticAccessor("AnimationOffsetPlayableBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable>
{
	private PlayableHandle m_Handle;

	private static readonly AnimationOffsetPlayable m_NullPlayable;

	public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
	{
		return default(AnimationOffsetPlayable);
	}

	private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
	{
		return default(PlayableHandle);
	}

	internal AnimationOffsetPlayable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public static implicit operator Playable(AnimationOffsetPlayable playable)
	{
		return default(Playable);
	}

	public bool Equals(AnimationOffsetPlayable other)
	{
		return false;
	}

	[NativeThrows]
	private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle)
	{
		return false;
	}

	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle)
	{
		return false;
	}
}
