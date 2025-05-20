using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

internal class FrameTimeSampleHistory
{
	private List<FrameTimeSample> m_Samples;

	internal FrameTimeSample SampleAverage;

	internal FrameTimeSample SampleMin;

	internal FrameTimeSample SampleMax;

	private static Func<float, float, float> s_SampleValueAdd;

	private static Func<float, float, float> s_SampleValueMin;

	private static Func<float, float, float> s_SampleValueMax;

	private static Func<float, float, float> s_SampleValueCountValid;

	private static Func<float, float, float> s_SampleValueEnsureValid;

	private static Func<float, float, float> s_SampleValueDivide;

	public FrameTimeSampleHistory(int initialCapacity)
	{
	}

	internal void Add(FrameTimeSample sample)
	{
	}

	internal void ComputeAggregateValues()
	{
	}

	internal void DiscardOldSamples(int sampleHistorySize)
	{
	}

	internal void Clear()
	{
	}
}
