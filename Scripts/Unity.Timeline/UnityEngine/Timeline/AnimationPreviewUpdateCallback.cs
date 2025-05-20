using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

internal class AnimationPreviewUpdateCallback : ITimelineEvaluateCallback
{
	private AnimationPlayableOutput m_Output;

	private PlayableGraph m_Graph;

	private List<IAnimationWindowPreview> m_PreviewComponents;

	public AnimationPreviewUpdateCallback(AnimationPlayableOutput output)
	{
	}

	public void Evaluate()
	{
	}

	private void FetchPreviewComponents()
	{
	}
}
