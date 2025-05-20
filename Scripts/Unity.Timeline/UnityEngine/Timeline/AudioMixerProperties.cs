using System;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
internal class AudioMixerProperties : PlayableBehaviour
{
	[Range(0f, 1f)]
	public float volume;

	[Range(-1f, 1f)]
	public float stereoPan;

	[Range(0f, 1f)]
	public float spatialBlend;

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}
}
