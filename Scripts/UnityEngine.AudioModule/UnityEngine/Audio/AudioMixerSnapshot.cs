using UnityEngine.Bindings;

namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
public class AudioMixerSnapshot : Object
{
	[NativeProperty]
	public AudioMixer audioMixer => null;

	public void TransitionTo(float timeToReach)
	{
	}
}
