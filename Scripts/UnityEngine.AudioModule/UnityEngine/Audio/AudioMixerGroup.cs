using UnityEngine.Bindings;

namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : Object
{
	[NativeProperty]
	public AudioMixer audioMixer => null;
}
