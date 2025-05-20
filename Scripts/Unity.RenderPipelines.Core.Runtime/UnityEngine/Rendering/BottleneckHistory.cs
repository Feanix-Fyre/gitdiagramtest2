using System.Collections.Generic;

namespace UnityEngine.Rendering;

internal class BottleneckHistory
{
	private List<PerformanceBottleneck> m_Bottlenecks;

	internal BottleneckHistogram Histogram;

	public BottleneckHistory(int initialCapacity)
	{
	}

	internal void DiscardOldSamples(int historySize)
	{
	}

	internal void AddBottleneckFromAveragedSample(FrameTimeSample frameHistorySampleAverage)
	{
	}

	internal void ComputeHistogram()
	{
	}

	private static PerformanceBottleneck DetermineBottleneck(FrameTimeSample s)
	{
		return default(PerformanceBottleneck);
	}

	internal void Clear()
	{
	}
}
