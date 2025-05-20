using System;
using System.Collections.Generic;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
[SupportsChildTracks(null, int.MaxValue)]
[TrackClipType(typeof(TrackAsset))]
[ExcludeFromPreset]
public class GroupTrack : TrackAsset
{
	public override IEnumerable<PlayableBinding> outputs => null;

	internal override bool CanCompileClips()
	{
		return false;
	}
}
