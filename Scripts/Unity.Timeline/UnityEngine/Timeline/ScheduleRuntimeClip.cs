using UnityEngine.Playables;

namespace UnityEngine.Timeline;

internal class ScheduleRuntimeClip : RuntimeClipBase
{
	private TimelineClip m_Clip;

	private Playable m_Playable;

	private Playable m_ParentMixer;

	private double m_StartDelay;

	private double m_FinishTail;

	private bool m_Started;

	public override double start => 0.0;

	public override double duration => 0.0;

	public TimelineClip clip => null;

	public Playable mixer => default(Playable);

	public Playable playable => default(Playable);

	public override bool enable
	{
		set
		{
		}
	}

	public void SetTime(double time)
	{
	}

	public ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1)
	{
	}

	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail)
	{
	}

	public override void EvaluateAt(double localTime, FrameData frameData)
	{
	}

	public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
	{
	}
}
