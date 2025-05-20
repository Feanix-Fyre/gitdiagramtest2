using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal;

public sealed class UniversalRenderer : ScriptableRenderer
{
	private static class Profiling
	{
		private const string k_Name = "UniversalRenderer";

		public static readonly ProfilingSampler createCameraRenderTarget;
	}

	private struct RenderPassInputSummary
	{
		internal bool requiresDepthTexture;

		internal bool requiresDepthPrepass;

		internal bool requiresNormalsTexture;

		internal bool requiresColorTexture;

		internal bool requiresColorTextureCreated;

		internal bool requiresMotionVectors;

		internal RenderPassEvent requiresDepthNormalAtEvent;

		internal RenderPassEvent requiresDepthTextureEarliestEvent;
	}

	internal class RenderGraphFrameResources
	{
		internal TextureHandle backBufferColor;

		internal TextureHandle cameraColor;

		internal TextureHandle cameraDepth;

		internal TextureHandle mainShadowsTexture;

		internal TextureHandle additionalShadowsTexture;

		internal TextureHandle[] gbuffer;

		internal TextureHandle cameraOpaqueTexture;

		internal TextureHandle cameraDepthTexture;

		internal TextureHandle cameraNormalsTexture;

		internal TextureHandle motionVectorColor;

		internal TextureHandle motionVectorDepth;

		internal TextureHandle internalColorLut;

		internal TextureHandle overlayUITexture;
	}

	private const GraphicsFormat k_DepthStencilFormat = GraphicsFormat.D32_SFloat_S8_UInt;

	private const int k_DepthBufferBits = 32;

	private const int k_FinalBlitPassQueueOffset = 1;

	private const int k_AfterFinalBlitPassQueueOffset = 2;

	private static readonly List<ShaderTagId> k_DepthNormalsOnly;

	private bool m_Clustering;

	private DepthOnlyPass m_DepthPrepass;

	private DepthNormalOnlyPass m_DepthNormalPrepass;

	private CopyDepthPass m_PrimedDepthCopyPass;

	private MotionVectorRenderPass m_MotionVectorPass;

	private MainLightShadowCasterPass m_MainLightShadowCasterPass;

	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

	private GBufferPass m_GBufferPass;

	private CopyDepthPass m_GBufferCopyDepthPass;

	private DeferredPass m_DeferredPass;

	private DrawObjectsPass m_RenderOpaqueForwardOnlyPass;

	private DrawObjectsPass m_RenderOpaqueForwardPass;

	private DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass;

	private DrawSkyboxPass m_DrawSkyboxPass;

	private CopyDepthPass m_CopyDepthPass;

	private CopyColorPass m_CopyColorPass;

	private TransparentSettingsPass m_TransparentSettingsPass;

	private DrawObjectsPass m_RenderTransparentForwardPass;

	private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass;

	private FinalBlitPass m_FinalBlitPass;

	private CapturePass m_CapturePass;

	private XROcclusionMeshPass m_XROcclusionMeshPass;

	private CopyDepthPass m_XRCopyDepthPass;

	private DrawScreenSpaceUIPass m_DrawOffscreenUIPass;

	private DrawScreenSpaceUIPass m_DrawOverlayUIPass;

	internal RenderTargetBufferSystem m_ColorBufferSystem;

	internal RTHandle m_ActiveCameraColorAttachment;

	private RTHandle m_ColorFrontBuffer;

	internal RTHandle m_ActiveCameraDepthAttachment;

	internal RTHandle m_CameraDepthAttachment;

	private RTHandle m_XRTargetHandleAlias;

	internal RTHandle m_DepthTexture;

	private RTHandle m_NormalsTexture;

	private RTHandle m_DecalLayersTexture;

	private RTHandle m_OpaqueColor;

	private RTHandle m_MotionVectorColor;

	private RTHandle m_MotionVectorDepth;

	private ForwardLights m_ForwardLights;

	private DeferredLights m_DeferredLights;

	private RenderingMode m_RenderingMode;

	private DepthPrimingMode m_DepthPrimingMode;

	private CopyDepthMode m_CopyDepthMode;

	private bool m_DepthPrimingRecommended;

	private StencilState m_DefaultStencilState;

	private LightCookieManager m_LightCookieManager;

	private IntermediateTextureMode m_IntermediateTextureMode;

	private bool m_VulkanEnablePreTransform;

	private Material m_BlitMaterial;

	private Material m_BlitHDRMaterial;

	private Material m_CopyDepthMaterial;

	private Material m_SamplingMaterial;

	private Material m_StencilDeferredMaterial;

	private Material m_CameraMotionVecMaterial;

	private Material m_ObjectMotionVecMaterial;

	private PostProcessPasses m_PostProcessPasses;

	private static RTHandle m_RenderGraphCameraColorHandle;

	private static RTHandle m_RenderGraphCameraDepthHandle;

	internal static TextureHandle m_ActiveRenderGraphColor;

	internal static TextureHandle m_ActiveRenderGraphDepth;

	internal bool m_TargetIsBackbuffer;

	internal RenderGraphFrameResources frameResources;

	private static bool m_UseIntermediateTexture;

	internal RenderingMode renderingModeRequested => default(RenderingMode);

	internal RenderingMode renderingModeActual => default(RenderingMode);

	internal bool accurateGbufferNormals => false;

	public DepthPrimingMode depthPrimingMode
	{
		get
		{
			return default(DepthPrimingMode);
		}
		set
		{
		}
	}

	internal ColorGradingLutPass colorGradingLutPass => null;

	internal PostProcessPass postProcessPass => null;

	internal PostProcessPass finalPostProcessPass => null;

	internal RTHandle colorGradingLut => null;

	internal DeferredLights deferredLights => null;

	public override int SupportedCameraStackingTypes()
	{
		return 0;
	}

	public UniversalRenderer(UniversalRendererData data)
		: base(null)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	internal override void ReleaseRenderTargets()
	{
	}

	private void SetupFinalPassDebug(ref CameraData cameraData)
	{
	}

	public static bool IsOffscreenDepthTexture(in CameraData cameraData)
	{
		return false;
	}

	private bool IsDepthPrimingEnabled(ref CameraData cameraData)
	{
		return false;
	}

	private bool IsWebGL()
	{
		return false;
	}

	private bool IsGLESDevice()
	{
		return false;
	}

	private bool IsGLDevice()
	{
		return false;
	}

	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
	{
	}

	public override void FinishRendering(CommandBuffer cmd)
	{
	}

	private void EnqueueDeferred(ref RenderingData renderingData, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow)
	{
	}

	private RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData)
	{
		return default(RenderPassInputSummary);
	}

	private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, bool primedDepth, CommandBuffer cmd, ref CameraData cameraData)
	{
	}

	private bool PlatformRequiresExplicitMsaaResolve()
	{
		return false;
	}

	private bool RequiresIntermediateColorTexture(ref CameraData cameraData)
	{
		return false;
	}

	private bool CanCopyDepth(ref CameraData cameraData)
	{
		return false;
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

	private void CleanupRenderGraphResources()
	{
	}

	internal static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp)
	{
		return default(TextureHandle);
	}

	private bool RequiresColorAndDepthTextures(out bool createColorTexture, out bool createDepthTexture, ref RenderingData renderingData, RenderPassInputSummary renderPassInputs)
	{
		createColorTexture = default(bool);
		createDepthTexture = default(bool);
		return false;
	}

	private void CreateRenderGraphCameraRenderTargets(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal override void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private void OnBeforeRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private void OnMainRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private void OnAfterRendering(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
