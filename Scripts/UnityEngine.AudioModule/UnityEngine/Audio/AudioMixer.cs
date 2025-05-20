using UnityEngine.Bindings;

namespace UnityEngine.Audio;

[ExcludeFromObjectFactory]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
[ExcludeFromPreset]
public class AudioMixer : Object
{
	internal AudioMixer()
	{
	}

	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach)
	{
	}

	[NativeMethod("TransitionToSnapshot")]
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach)
	{
	}

	[NativeMethod]
	public bool SetFloat(string name, float value)
	{
		return false;
	}
}
