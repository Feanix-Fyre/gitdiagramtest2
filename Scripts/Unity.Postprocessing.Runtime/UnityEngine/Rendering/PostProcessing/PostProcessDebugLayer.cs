using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class PostProcessDebugLayer
{
	[Serializable]
	public class OverlaySettings
	{
		public bool linearDepth;

		[Range(0f, 16f)]
		public float motionColorIntensity;

		[Range(4f, 128f)]
		public int motionGridSize;

		public ColorBlindnessType colorBlindnessType;

		[Range(0f, 1f)]
		public float colorBlindnessStrength;
	}

	public LightMeterMonitor lightMeter;

	public HistogramMonitor histogram;

	public WaveformMonitor waveform;

	public VectorscopeMonitor vectorscope;

	private Dictionary<MonitorType, Monitor> m_Monitors;

	private int frameWidth;

	private int frameHeight;

	public OverlaySettings overlaySettings;

	public RenderTexture debugOverlayTarget { get; private set; }

	public bool debugOverlayActive { get; private set; }

	public DebugOverlay debugOverlay { get; private set; }

	internal void OnEnable()
	{
	}

	internal void OnDisable()
	{
	}

	private void DestroyDebugOverlayTarget()
	{
	}

	public void RequestMonitorPass(MonitorType monitor)
	{
	}

	public void RequestDebugOverlay(DebugOverlay mode)
	{
	}

	internal void SetFrameSize(int width, int height)
	{
	}

	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	internal void RenderMonitors(PostProcessRenderContext context)
	{
	}

	internal void RenderSpecialOverlays(PostProcessRenderContext context)
	{
	}

	internal void EndFrame()
	{
	}
}
