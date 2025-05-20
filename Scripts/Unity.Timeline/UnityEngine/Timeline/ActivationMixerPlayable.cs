using UnityEngine.Playables;

namespace UnityEngine.Timeline;

internal class ActivationMixerPlayable : PlayableBehaviour
{
	private ActivationTrack.PostPlaybackState m_PostPlaybackState;

	private bool m_BoundGameObjectInitialStateIsActive;

	private GameObject m_BoundGameObject;

	public ActivationTrack.PostPlaybackState postPlaybackState
	{
		get
		{
			return default(ActivationTrack.PostPlaybackState);
		}
		set
		{
		}
	}

	public static ScriptPlayable<ActivationMixerPlayable> Create(PlayableGraph graph, int inputCount)
	{
		return default(ScriptPlayable<ActivationMixerPlayable>);
	}

	public override void OnPlayableDestroy(Playable playable)
	{
	}

	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}
}
