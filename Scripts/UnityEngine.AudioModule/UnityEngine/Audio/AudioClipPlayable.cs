using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AudioClipPlayableBindings", StaticAccessorType.DoubleColon)]
[RequiredByNativeCode]
public struct AudioClipPlayable : IPlayable, IEquatable<AudioClipPlayable>
{
	private PlayableHandle m_Handle;

	public static AudioClipPlayable Create(PlayableGraph graph, AudioClip clip, bool looping)
	{
		return default(AudioClipPlayable);
	}

	private static PlayableHandle CreateHandle(PlayableGraph graph, AudioClip clip, bool looping)
	{
		return default(PlayableHandle);
	}

	internal AudioClipPlayable(PlayableHandle handle)
	{
		m_Handle = default(PlayableHandle);
	}

	public PlayableHandle GetHandle()
	{
		return default(PlayableHandle);
	}

	public static implicit operator Playable(AudioClipPlayable playable)
	{
		return default(Playable);
	}

	public static explicit operator AudioClipPlayable(Playable playable)
	{
		return default(AudioClipPlayable);
	}

	public bool Equals(AudioClipPlayable other)
	{
		return false;
	}

	internal void SetVolume(float value)
	{
	}

	internal void SetStereoPan(float value)
	{
	}

	internal void SetSpatialBlend(float value)
	{
	}

	public void Seek(double startTime, double startDelay, [DefaultValue("0")] double duration)
	{
	}

	[NativeThrows]
	private static void SetVolumeInternal(ref PlayableHandle hdl, float volume)
	{
	}

	[NativeThrows]
	private static void SetStereoPanInternal(ref PlayableHandle hdl, float stereoPan)
	{
	}

	[NativeThrows]
	private static void SetSpatialBlendInternal(ref PlayableHandle hdl, float spatialBlend)
	{
	}

	[NativeThrows]
	private static void SetStartDelayInternal(ref PlayableHandle hdl, double delay)
	{
	}

	[NativeThrows]
	private static void SetPauseDelayInternal(ref PlayableHandle hdl, double delay)
	{
	}

	[NativeThrows]
	private static bool InternalCreateAudioClipPlayable(ref PlayableGraph graph, AudioClip clip, bool looping, ref PlayableHandle handle)
	{
		return false;
	}
}
