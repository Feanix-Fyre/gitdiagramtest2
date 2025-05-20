using UnityEngine.Playables;

namespace UnityEngine.Timeline;

internal class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset
{
	public ClipCaps clipCaps => default(ClipCaps);

	public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
	{
		return default(Playable);
	}
}
