using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

internal class DeferredLights
{
	internal static class ShaderConstants
	{
		public static readonly int _LitStencilRef;

		public static readonly int _LitStencilReadMask;

		public static readonly int _LitStencilWriteMask;

		public static readonly int _SimpleLitStencilRef;

		public static readonly int _SimpleLitStencilReadMask;

		public static readonly int _SimpleLitStencilWriteMask;

		public static readonly int _StencilRef;

		public static readonly int _StencilReadMask;

		public static readonly int _StencilWriteMask;

		public static readonly int _LitPunctualStencilRef;

		public static readonly int _LitPunctualStencilReadMask;

		public static readonly int _LitPunctualStencilWriteMask;

		public static readonly int _SimpleLitPunctualStencilRef;

		public static readonly int _SimpleLitPunctualStencilReadMask;

		public static readonly int _SimpleLitPunctualStencilWriteMask;

		public static readonly int _LitDirStencilRef;

		public static readonly int _LitDirStencilReadMask;

		public static readonly int _LitDirStencilWriteMask;

		public static readonly int _SimpleLitDirStencilRef;

		public static readonly int _SimpleLitDirStencilReadMask;

		public static readonly int _SimpleLitDirStencilWriteMask;

		public static readonly int _ClearStencilRef;

		public static readonly int _ClearStencilReadMask;

		public static readonly int _ClearStencilWriteMask;

		public static readonly int _ScreenToWorld;

		public static int _MainLightPosition;

		public static int _MainLightColor;

		public static int _MainLightLayerMask;

		public static int _SpotLightScale;

		public static int _SpotLightBias;

		public static int _SpotLightGuard;

		public static int _LightPosWS;

		public static int _LightColor;

		public static int _LightAttenuation;

		public static int _LightOcclusionProbInfo;

		public static int _LightDirection;

		public static int _LightFlags;

		public static int _ShadowLightIndex;

		public static int _LightLayerMask;

		public static int _CookieLightIndex;
	}

	internal enum StencilDeferredPasses
	{
		StencilVolume = 0,
		PunctualLit = 1,
		PunctualSimpleLit = 2,
		DirectionalLit = 3,
		DirectionalSimpleLit = 4,
		ClearStencilPartial = 5,
		Fog = 6,
		SSAOOnly = 7
	}

	internal struct InitParams
	{
		public Material stencilDeferredMaterial;

		public LightCookieManager lightCookieManager;
	}

	internal static readonly string[] k_GBufferNames;

	private static readonly string[] k_StencilDeferredPassNames;

	private static readonly ushort k_InvalidLightOffset;

	private static readonly string k_SetupLights;

	private static readonly string k_DeferredPass;

	private static readonly string k_DeferredStencilPass;

	private static readonly string k_DeferredFogPass;

	private static readonly string k_ClearStencilPartial;

	private static readonly string k_SetupLightConstants;

	private static readonly float kStencilShapeGuard;

	private static readonly ProfilingSampler m_ProfilingSetupLights;

	private static readonly ProfilingSampler m_ProfilingDeferredPass;

	private static readonly ProfilingSampler m_ProfilingSetupLightConstants;

	private RTHandle[] GbufferRTHandles;

	private NativeArray<ushort> m_stencilVisLights;

	private NativeArray<ushort> m_stencilVisLightOffsets;

	private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

	private Mesh m_SphereMesh;

	private Mesh m_HemisphereMesh;

	private Mesh m_FullscreenMesh;

	private Material m_StencilDeferredMaterial;

	private int[] m_StencilDeferredPasses;

	private Matrix4x4[] m_ScreenToWorld;

	private ProfilingSampler m_ProfilingSamplerDeferredStencilPass;

	private ProfilingSampler m_ProfilingSamplerDeferredFogPass;

	private ProfilingSampler m_ProfilingSamplerClearStencilPartialPass;

	private LightCookieManager m_LightCookieManager;

	internal int GBufferAlbedoIndex => 0;

	internal int GBufferSpecularMetallicIndex => 0;

	internal int GBufferNormalSmoothnessIndex => 0;

	internal int GBufferLightingIndex => 0;

	internal int GbufferDepthIndex => 0;

	internal int GBufferRenderingLayers => 0;

	internal int GBufferShadowMask => 0;

	internal int GBufferSliceCount => 0;

	internal bool UseShadowMask => false;

	internal bool UseRenderingLayers => false;

	internal RenderingLayerUtils.MaskSize RenderingLayerMaskSize { get; set; }

	internal bool UseDecalLayers { get; set; }

	internal bool UseLightLayers => false;

	internal bool UseRenderPass { get; set; }

	internal bool HasDepthPrepass { get; set; }

	internal bool HasNormalPrepass { get; set; }

	internal bool HasRenderingLayerPrepass { get; set; }

	internal bool IsOverlay { get; set; }

	internal bool AccurateGbufferNormals { get; set; }

	internal MixedLightingSetup MixedLightingSetup { get; set; }

	internal bool UseJobSystem { get; set; }

	internal int RenderWidth { get; set; }

	internal int RenderHeight { get; set; }

	internal RTHandle[] GbufferAttachments { get; set; }

	internal TextureHandle[] GbufferTextureHandles { get; set; }

	internal RTHandle[] DeferredInputAttachments { get; set; }

	internal bool[] DeferredInputIsTransient { get; set; }

	internal RTHandle DepthAttachment { get; set; }

	internal RTHandle DepthCopyTexture { get; set; }

	internal GraphicsFormat[] GbufferFormats { get; set; }

	internal RTHandle DepthAttachmentHandle { get; set; }

	internal GraphicsFormat GetGBufferFormat(int index)
	{
		return default(GraphicsFormat);
	}

	internal DeferredLights(InitParams initParams, bool useNativeRenderPass = false)
	{
	}

	internal void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal void ResolveMixedLightingMode(ref RenderingData renderingData)
	{
	}

	internal void DisableFramebufferFetchInput()
	{
	}

	internal void ReleaseGbufferResources()
	{
	}

	internal void ReAllocateGBufferIfNeeded(RenderTextureDescriptor gbufferSlice, int gbufferIndex)
	{
	}

	internal void CreateGbufferResources()
	{
	}

	internal void UpdateDeferredInputAttachments()
	{
	}

	internal bool IsRuntimeSupportedThisFrame()
	{
		return false;
	}

	public void Setup(ref RenderingData renderingData, AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, RTHandle depthCopyTexture, RTHandle depthAttachment, RTHandle colorAttachment)
	{
	}

	internal void Setup(AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass)
	{
	}

	public void OnCameraCleanup(CommandBuffer cmd)
	{
	}

	internal static StencilState OverwriteStencil(StencilState s, int stencilWriteMask)
	{
		return default(StencilState);
	}

	internal static RenderStateBlock OverwriteStencil(RenderStateBlock block, int stencilWriteMask, int stencilRef)
	{
		return default(RenderStateBlock);
	}

	internal void ClearStencilPartial(CommandBuffer cmd)
	{
	}

	internal void ExecuteDeferredPass(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
	{
	}

	private void SetupMatrixConstants(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	private void PrecomputeLights(out NativeArray<ushort> stencilVisLights, out NativeArray<ushort> stencilVisLightOffsets, ref NativeArray<VisibleLight> visibleLights, bool hasAdditionalLights, Matrix4x4 view, bool isOrthographic, float zNear)
	{
		stencilVisLights = default(NativeArray<ushort>);
		stencilVisLightOffsets = default(NativeArray<ushort>);
	}

	private bool HasStencilLightsOfType(LightType type)
	{
		return false;
	}

	private void RenderStencilLights(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	private void SetAdditionalLightsShadowsKeyword(ref CommandBuffer cmd, ref RenderingData renderingData, bool hasDeferredShadows)
	{
	}

	private void RenderStencilDirectionalLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights, int mainLightIndex)
	{
	}

	private void RenderStencilPointLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights)
	{
	}

	private void RenderStencilSpotLights(CommandBuffer cmd, ref RenderingData renderingData, NativeArray<VisibleLight> visibleLights)
	{
	}

	private void RenderSSAOBeforeShading(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	private void RenderFog(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	private void InitStencilDeferredMaterial()
	{
	}

	private static Mesh CreateSphereMesh()
	{
		return null;
	}

	private static Mesh CreateHemisphereMesh()
	{
		return null;
	}

	private static Mesh CreateFullscreenMesh()
	{
		return null;
	}
}
