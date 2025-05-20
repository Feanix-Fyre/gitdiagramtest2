using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations;

[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
public struct AnimationPlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle;

	public static AnimationPlayableOutput Null => default(AnimationPlayableOutput);

	public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target)
	{
		return default(AnimationPlayableOutput);
	}

	internal AnimationPlayableOutput(PlayableOutputHandle handle)
	{
		m_Handle = default(PlayableOutputHandle);
	}

	public PlayableOutputHandle GetHandle()
	{
		return default(PlayableOutputHandle);
	}

	public static implicit operator PlayableOutput(AnimationPlayableOutput output)
	{
		return default(PlayableOutput);
	}

	public static explicit operator AnimationPlayableOutput(PlayableOutput output)
	{
		return default(AnimationPlayableOutput);
	}

	public Animator GetTarget()
	{
		return null;
	}

	public void SetTarget(Animator value)
	{
	}

	[NativeThrows]
	private static Animator InternalGetTarget(ref PlayableOutputHandle handle)
	{
		return null;
	}

	[NativeThrows]
	private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target)
	{
	}
}
