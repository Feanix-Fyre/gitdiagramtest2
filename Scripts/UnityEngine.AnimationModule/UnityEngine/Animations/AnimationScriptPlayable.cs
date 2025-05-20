using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations;

[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[StaticAccessor("AnimationScriptPlayableBindings", StaticAccessorType.DoubleColon)]
public struct AnimationScriptPlayable : IPlayable, IEquatable<AnimationScriptPlayable>
{
	private PlayableHandle m_Handle;

	private static readonly AnimationScriptPlayable m_NullPlayable;

	internal AnimationScriptPlayable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public bool Equals(AnimationScriptPlayable other)
	{
		return false;
	}
}
