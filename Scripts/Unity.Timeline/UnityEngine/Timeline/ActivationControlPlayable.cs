using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class ActivationControlPlayable : PlayableBehaviour
{
	public enum PostPlaybackState
	{
		Active = 0,
		Inactive = 1,
		Revert = 2
	}

	private enum InitialState
	{
		Unset = 0,
		Active = 1,
		Inactive = 2
	}

	public GameObject gameObject;

	public PostPlaybackState postPlayback;

	private InitialState m_InitialState;

	public static ScriptPlayable<ActivationControlPlayable> Create(PlayableGraph graph, GameObject gameObject, PostPlaybackState postPlaybackState)
	{
		return default(ScriptPlayable<ActivationControlPlayable>);
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public override void ProcessFrame(Playable playable, FrameData info, object userData)
	{
	}

	public override void OnGraphStart(Playable playable)
	{
	}

	public override void OnPlayableDestroy(Playable playable)
	{
	}
}
