using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
internal sealed class ScalableAO : IAmbientOcclusionMethod
{
	private enum Pass
	{
		OcclusionEstimationForward = 0,
		OcclusionEstimationDeferred = 1,
		HorizontalBlurForward = 2,
		HorizontalBlurDeferred = 3,
		VerticalBlur = 4,
		CompositionForward = 5,
		CompositionDeferred = 6,
		DebugOverlay = 7
	}

	private RenderTexture m_Result;

	private PropertySheet m_PropertySheet;

	private AmbientOcclusion m_Settings;

	private readonly RenderTargetIdentifier[] m_MRT;

	private readonly int[] m_SampleCount;

	public ScalableAO(AmbientOcclusion settings)
	{
	}

	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	private void DoLazyInitialization(PostProcessRenderContext context)
	{
	}

	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource)
	{
	}

	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	public void Release()
	{
	}
}
