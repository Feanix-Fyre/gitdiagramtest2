using UnityEngine.Playables;

namespace UnityEngine.Timeline;

internal class RuntimeClip : RuntimeClipBase
{
	private TimelineClip m_Clip;

	private Playable m_Playable;

	private Playable m_ParentMixer;

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

	public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
	{
	}

	private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
	{
	}

	public void SetTime(double time)
	{
	}

	public void SetDuration(double duration)
	{
	}

	public override void EvaluateAt(double localTime, FrameData frameData)
	{
	}

	public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
	{
	}
}
