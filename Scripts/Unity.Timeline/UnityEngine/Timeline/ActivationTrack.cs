using System;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

[Serializable]
[TrackClipType(typeof(ActivationPlayableAsset))]
[TrackBindingType(typeof(GameObject))]
[ExcludeFromPreset]
public class ActivationTrack : TrackAsset
{
	public enum PostPlaybackState
	{
		Active = 0,
		Inactive = 1,
		Revert = 2,
		LeaveAsIs = 3
	}

	[SerializeField]
	private PostPlaybackState m_PostPlaybackState;

	private ActivationMixerPlayable m_ActivationMixer;

	public PostPlaybackState postPlaybackState
	{
		get
		{
			return default(PostPlaybackState);
		}
		set
		{
		}
	}

	internal override bool CanCompileClips()
	{
		return false;
	}

	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	internal void UpdateTrackMode()
	{
	}

	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	protected override void OnCreateClip(TimelineClip clip)
	{
	}
}
