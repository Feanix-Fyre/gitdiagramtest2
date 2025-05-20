using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType.DoubleColon)]
[RequiredByNativeCode]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
public struct AudioPlayableOutput : IPlayableOutput
{
	private PlayableOutputHandle m_Handle;

	public static AudioPlayableOutput Null => default(AudioPlayableOutput);

	public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target)
	{
		return default(AudioPlayableOutput);
	}

	internal AudioPlayableOutput(PlayableOutputHandle handle)
	{
		m_Handle = default(PlayableOutputHandle);
	}

	public PlayableOutputHandle GetHandle()
	{
		return default(PlayableOutputHandle);
	}

	public static implicit operator PlayableOutput(AudioPlayableOutput output)
	{
		return default(PlayableOutput);
	}

	public static explicit operator AudioPlayableOutput(PlayableOutput output)
	{
		return default(AudioPlayableOutput);
	}

	public void SetTarget(AudioSource value)
	{
	}

	public void SetEvaluateOnSeek(bool value)
	{
	}

	[NativeThrows]
	private static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target)
	{
	}

	[NativeThrows]
	private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value)
	{
	}
}
