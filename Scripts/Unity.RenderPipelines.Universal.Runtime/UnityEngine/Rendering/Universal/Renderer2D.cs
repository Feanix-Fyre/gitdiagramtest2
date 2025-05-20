using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal;

internal class Renderer2D : ScriptableRenderer
{
	private struct RenderPassInputSummary
	{
		internal bool requiresDepthTexture;

		internal bool requiresColorTexture;
	}

	internal const int k_DepthBufferBits = 32;

	private const int k_FinalBlitPassQueueOffset = 1;

	private const int k_AfterFinalBlitPassQueueOffset = 2;

	private Render2DLightingPass m_Render2DLightingPass;

	private PixelPerfectBackgroundPass m_PixelPerfectBackgroundPass;

	private UpscalePass m_UpscalePass;

	private FinalBlitPass m_FinalBlitPass;

	private DrawScreenSpaceUIPass m_DrawOffscreenUIPass;

	private DrawScreenSpaceUIPass m_DrawOverlayUIPass;

	private Light2DCullResult m_LightCullResult;

	internal RenderTargetBufferSystem m_ColorBufferSystem;

	private static readonly ProfilingSampler m_ProfilingSampler;

	private bool m_UseDepthStencilBuffer;

	private bool m_CreateColorTexture;

	private bool m_CreateDepthTexture;

	private RTHandle m_ColorTextureHandle;

	private RTHandle m_DepthTextureHandle;

	private Material m_BlitMaterial;

	private Material m_BlitHDRMaterial;

	private Material m_SamplingMaterial;

	private Renderer2DData m_Renderer2DData;

	private PostProcessPasses m_PostProcessPasses;

	internal bool createColorTexture => false;

	internal bool createDepthTexture => false;

	internal ColorGradingLutPass colorGradingLutPass => null;

	internal PostProcessPass postProcessPass => null;

	internal PostProcessPass finalPostProcessPass => null;

	internal RTHandle afterPostProcessColorHandle => null;

	internal RTHandle colorGradingLutHandle => null;

	public override int SupportedCameraStackingTypes()
	{
		return 0;
	}

	public Renderer2D(Renderer2DData data)
		: base(null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	internal override void ReleaseRenderTargets()
	{
	}

	public Renderer2DData GetRenderer2DData()
	{
		return null;
	}

	private RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData, ref CameraData cameraData)
	{
		return default(RenderPassInputSummary);
	}

	private void CreateRenderTextures(ref RenderPassInputSummary renderPassInputs, CommandBuffer cmd, ref CameraData cameraData, bool forceCreateColorTexture, FilterMode colorTextureFilterMode, out RTHandle colorTargetHandle, out RTHandle depthTargetHandle)
	{
		colorTargetHandle = null;
		depthTargetHandle = null;
	}

	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
	{
	}

	internal override void SwapColorBuffer(CommandBuffer cmd)
	{
	}

	internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
	{
		return null;
	}

	internal override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
	{
		return null;
	}

	internal override void EnableSwapBufferMSAA(bool enable)
	{
	}
}
