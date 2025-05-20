using System.Collections.Generic;

namespace UnityEngine.Rendering;

public class DebugFrameTiming
{
	private const string k_FpsFormatString = "{0:F1}";

	private const string k_MsFormatString = "{0:F2}ms";

	private const float k_RefreshRate = 0.2f;

	internal FrameTimeSampleHistory m_FrameHistory;

	internal BottleneckHistory m_BottleneckHistory;

	private FrameTiming[] m_Timing;

	private FrameTimeSample m_Sample;

	public int bottleneckHistorySize { get; set; }

	public int sampleHistorySize { get; set; }

	public void UpdateFrameTiming()
	{
	}

	public void RegisterDebugUI(List<DebugUI.Widget> list)
	{
	}

	internal void Reset()
	{
	}
}
