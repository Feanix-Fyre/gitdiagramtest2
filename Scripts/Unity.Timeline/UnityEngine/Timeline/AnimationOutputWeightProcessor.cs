using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback
{
	private struct WeightInfo
	{
		public Playable mixer;

		public Playable parentMixer;

		public int port;
	}

	private AnimationPlayableOutput m_Output;

	private AnimationMotionXToDeltaPlayable m_MotionXPlayable;

	private readonly List<WeightInfo> m_Mixers;

	public AnimationOutputWeightProcessor(AnimationPlayableOutput output)
	{
	}

	private void FindMixers()
	{
	}

	private void FindMixers(Playable parent, int port, Playable node)
	{
	}

	public void Evaluate()
	{
	}
}
