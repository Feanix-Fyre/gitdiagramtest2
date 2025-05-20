using UnityEngine.Audio;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
[RequireComponent(typeof(Transform))]
public sealed class AudioSource : AudioBehaviour
{
	public float volume
	{
		set
		{
		}
	}

	public float pitch
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[NativeProperty("SecPosition")]
	public float time
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[NativeProperty("AudioClip")]
	public AudioClip clip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AudioMixerGroup outputAudioMixerGroup
	{
		set
		{
		}
	}

	public bool isPlaying
	{
		[NativeName("IsPlayingScripting")]
		get
		{
			return false;
		}
	}

	public bool loop
	{
		set
		{
		}
	}

	public bool playOnAwake
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private static float GetPitch([NotNull("ArgumentNullException")] AudioSource source)
	{
		return 0f;
	}

	private static void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch)
	{
	}

	private static void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay)
	{
	}

	private void Play(double delay)
	{
	}

	private static void PlayOneShotHelper([NotNull("ArgumentNullException")] AudioSource source, [NotNull("NullExceptionObject")] AudioClip clip, float volumeScale)
	{
	}

	private void Stop(bool stopOneShots)
	{
	}

	[ExcludeFromDocs]
	public void Play()
	{
	}

	public void PlayDelayed(float delay)
	{
	}

	[ExcludeFromDocs]
	public void PlayOneShot(AudioClip clip)
	{
	}

	public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale)
	{
	}

	public void Stop()
	{
	}

	public void Pause()
	{
	}

	public void UnPause()
	{
	}
}
