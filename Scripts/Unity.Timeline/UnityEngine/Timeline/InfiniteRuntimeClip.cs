using UnityEngine.Playables;

namespace UnityEngine.Timeline;

internal class InfiniteRuntimeClip : RuntimeElement
{
	private Playable m_Playable;

	private static readonly long kIntervalEnd;

	public override long intervalStart => 0L;

	public override long intervalEnd => 0L;

	public override bool enable
	{
		set
		{
		}
	}

	public InfiniteRuntimeClip(Playable playable)
	{
	}

	public override void EvaluateAt(double localTime, FrameData frameData)
	{
	}

	public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
	{
	}
}
