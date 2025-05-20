using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class TimelinePlayable : PlayableBehaviour
{
	private IntervalTree<RuntimeElement> m_IntervalTree;

	private List<RuntimeElement> m_ActiveClips;

	private List<RuntimeElement> m_CurrentListOfActiveClips;

	private int m_ActiveBit;

	private List<ITimelineEvaluateCallback> m_EvaluateCallbacks;

	private Dictionary<TrackAsset, Playable> m_PlayableCache;

	internal static bool muteAudioScrubbing;

	public static ScriptPlayable<TimelinePlayable> Create(PlayableGraph graph, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
	{
		return default(ScriptPlayable<TimelinePlayable>);
	}

	public void Compile(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool autoRebalance, bool createOutputs)
	{
	}

	private void CompileTrackList(PlayableGraph graph, Playable timelinePlayable, IEnumerable<TrackAsset> tracks, GameObject go, bool createOutputs)
	{
	}

	private void CreateTrackOutput(PlayableGraph graph, TrackAsset track, GameObject go, Playable playable, int port)
	{
	}

	private void EvaluateWeightsForAnimationPlayableOutput(TrackAsset track, AnimationPlayableOutput animOutput)
	{
	}

	private void EvaluateAnimationPreviewUpdateCallback(TrackAsset track, AnimationPlayableOutput animOutput)
	{
	}

	private Playable CreateTrackPlayable(PlayableGraph graph, Playable timelinePlayable, TrackAsset track, GameObject go, bool createOutputs)
	{
		return default(Playable);
	}

	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	private void Evaluate(Playable playable, FrameData frameData)
	{
	}

	private void CacheTrack(TrackAsset track, Playable playable, int port, Playable parent)
	{
	}

	private static void ForAOTCompilationOnly()
	{
	}
}
