using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class TimeControlPlayable : PlayableBehaviour
{
	private ITimeControl m_timeControl;

	private bool m_started;

	public static ScriptPlayable<TimeControlPlayable> Create(PlayableGraph graph, ITimeControl timeControl)
	{
		return default(ScriptPlayable<TimeControlPlayable>);
	}

	public void Initialize(ITimeControl timeControl)
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
}
