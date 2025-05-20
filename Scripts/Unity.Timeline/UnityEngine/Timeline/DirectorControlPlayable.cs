using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class DirectorControlPlayable : PlayableBehaviour
{
	public PlayableDirector director;

	private bool m_SyncTime;

	private double m_AssetDuration;

	public static ScriptPlayable<DirectorControlPlayable> Create(PlayableGraph graph, PlayableDirector director)
	{
		return default(ScriptPlayable<DirectorControlPlayable>);
	}

	public override void OnPlayableDestroy(Playable playable)
	{
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	private void SyncSpeed(double speed)
	{
	}

	private void SyncStart(PlayableGraph graph, double time)
	{
	}

	private void SyncStop(PlayableGraph graph, double time)
	{
	}

	private bool DetectDiscontinuity(Playable playable, FrameData info)
	{
		return false;
	}

	private bool DetectOutOfSync(Playable playable)
	{
		return false;
	}

	private void UpdateTime(Playable playable)
	{
	}
}
