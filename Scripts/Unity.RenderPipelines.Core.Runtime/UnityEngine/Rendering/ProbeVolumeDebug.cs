using System;

namespace UnityEngine.Rendering;

internal class ProbeVolumeDebug : IDebugData
{
	public bool drawProbes;

	public bool drawBricks;

	public bool drawCells;

	public bool realtimeSubdivision;

	public int subdivisionCellUpdatePerFrame;

	public float subdivisionDelayInSeconds;

	public DebugProbeShadingMode probeShading;

	public float probeSize;

	public float subdivisionViewCullingDistance;

	public float probeCullingDistance;

	public int maxSubdivToVisualize;

	public int minSubdivToVisualize;

	public float exposureCompensation;

	public bool drawVirtualOffsetPush;

	public float offsetSize;

	public bool freezeStreaming;

	public int otherStateIndex;

	private void Init()
	{
	}

	public Action GetReset()
	{
		return null;
	}
}
