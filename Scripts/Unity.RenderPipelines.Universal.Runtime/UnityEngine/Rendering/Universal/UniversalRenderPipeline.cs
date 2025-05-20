using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public sealed class UniversalRenderPipeline : RenderPipeline
{
	internal static class Profiling
	{
		public static class Pipeline
		{
			public static class Renderer
			{
				private const string k_Name = "ScriptableRenderer";

				public static readonly ProfilingSampler setupCullingParameters;

				public static readonly ProfilingSampler setup;
			}

			public static class Context
			{
				private const string k_Name = "ScriptableRenderContext";

				public static readonly ProfilingSampler submit;
			}

			public static readonly ProfilingSampler beginContextRendering;

			public static readonly ProfilingSampler endContextRendering;

			public static readonly ProfilingSampler beginCameraRendering;

			public static readonly ProfilingSampler endCameraRendering;

			private const string k_Name = "UniversalRenderPipeline";

			public static readonly ProfilingSampler initializeCameraData;

			public static readonly ProfilingSampler initializeStackedCameraData;

			public static readonly ProfilingSampler initializeAdditionalCameraData;

			public static readonly ProfilingSampler initializeRenderingData;

			public static readonly ProfilingSampler initializeShadowData;

			public static readonly ProfilingSampler initializeLightData;

			public static readonly ProfilingSampler getPerObjectLightFlags;

			public static readonly ProfilingSampler getMainLightIndex;

			public static readonly ProfilingSampler setupPerFrameShaderConstants;

			public static readonly ProfilingSampler setupPerCameraShaderConstants;
		}

		private static Dictionary<int, ProfilingSampler> s_HashSamplerCache;

		public static readonly ProfilingSampler unknownSampler;

		public static ProfilingSampler TryGetOrAddCameraSampler(Camera camera)
		{
			return null;
		}
	}

	public class SingleCameraRequest
	{
		public RenderTexture destination;

		public int mipLevel;

		public CubemapFace face;

		public int slice;
	}

	public const string k_ShaderTagName = "UniversalPipeline";

	internal const int k_DefaultRenderingLayerMask = 1;

	private readonly DebugDisplaySettingsUI m_DebugDisplaySettingsUI;

	private UniversalRenderPipelineGlobalSettings m_GlobalSettings;

	internal static bool cameraStackRequiresDepthForPostprocessing;

	internal static RenderGraph s_RenderGraph;

	internal static RTHandleResourcePool s_RTHandlePool;

	private static bool useRenderGraph;

	private readonly UniversalRenderPipelineAsset pipelineAsset;

	internal bool enableHDROnce;

	private static Vector4 k_DefaultLightPosition;

	private static Vector4 k_DefaultLightColor;

	private static Vector4 k_DefaultLightAttenuation;

	private static Vector4 k_DefaultLightSpotDirection;

	private static Vector4 k_DefaultLightsProbeChannel;

	private static List<Vector4> m_ShadowBiasData;

	private static List<int> m_ShadowResolutionData;

	private Comparison<Camera> cameraComparison;

	private static Lightmapping.RequestLightsDelegate lightsDelegate;

	public static float maxShadowBias => 0f;

	public static float minRenderScale => 0f;

	public static float maxRenderScale => 0f;

	public static int maxNumIterationsEnclosingSphere => 0;

	public static int maxPerObjectLights => 0;

	public static int maxVisibleAdditionalLights => 0;

	internal static int lightsPerTile => 0;

	internal static int maxZBinWords => 0;

	internal static int maxTileWords => 0;

	internal static int maxVisibleReflectionProbes => 0;

	public override RenderPipelineGlobalSettings defaultSettings => null;

	public static UniversalRenderPipelineAsset asset => null;

	public override string ToString()
	{
		return null;
	}

	public UniversalRenderPipeline(UniversalRenderPipelineAsset asset)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void DisposeAdditionalCameraData()
	{
	}

	protected override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
	{
	}

	protected override void Render(ScriptableRenderContext renderContext, List<Camera> cameras)
	{
	}

	protected override bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data)
	{
		return false;
	}

	protected override void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
	{
	}

	[Obsolete("RenderSingleCamera is obsolete, please use RenderPipeline.SubmitRenderRequest with UniversalRenderer.SingleCameraRequest as RequestData type", false)]
	public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera)
	{
	}

	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera)
	{
	}

	internal static void RenderSingleCameraInternal(ScriptableRenderContext context, Camera camera, ref UniversalAdditionalCameraData additionalCameraData)
	{
	}

	private static bool TryGetCullingParameters(CameraData cameraData, out ScriptableCullingParameters cullingParams)
	{
		cullingParams = default(ScriptableCullingParameters);
		return false;
	}

	private static void RenderSingleCamera(ScriptableRenderContext context, ref CameraData cameraData)
	{
	}

	private static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera)
	{
	}

	private static void UpdateCameraData(ref CameraData baseCameraData, in XRPass xr)
	{
	}

	private static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData)
	{
	}

	private static bool CheckPostProcessForDepth(ref CameraData cameraData)
	{
		return false;
	}

	private static bool CheckPostProcessForDepth()
	{
		return false;
	}

	private static void SetSupportedRenderingFeatures(UniversalRenderPipelineAsset pipelineAsset)
	{
	}

	private static void InitializeCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, out CameraData cameraData)
	{
		cameraData = default(CameraData);
	}

	private static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, ref CameraData cameraData)
	{
	}

	private static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref CameraData cameraData)
	{
	}

	private static void InitializeRenderingData(UniversalRenderPipelineAsset settings, ref CameraData cameraData, ref CullingResults cullResults, CommandBuffer cmd, out RenderingData renderingData)
	{
		renderingData = default(RenderingData);
	}

	private static void InitializeShadowData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, bool mainLightCastShadows, bool additionalLightsCastShadows, bool isForwardPlus, out ShadowData shadowData)
	{
		shadowData = default(ShadowData);
	}

	private static void InitializePostProcessingData(UniversalRenderPipelineAsset settings, bool isHDROutputActive, out PostProcessingData postProcessingData)
	{
		postProcessingData = default(PostProcessingData);
	}

	private static void InitializeLightData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, int mainLightIndex, out LightData lightData)
	{
		lightData = default(LightData);
	}

	private static void ApplyTaaRenderingDebugOverrides(ref TemporalAA.Settings taaSettings)
	{
	}

	private static void UpdateTemporalAAData(ref CameraData cameraData, UniversalAdditionalCameraData additionalCameraData)
	{
	}

	private static void UpdateTemporalAATargets(ref CameraData cameraData)
	{
	}

	private static void UpdateCameraStereoMatrices(Camera camera, XRPass xr)
	{
	}

	private static PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus)
	{
		return default(PerObjectData);
	}

	private static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights)
	{
		return 0;
	}

	private static void SetupPerFrameShaderConstants()
	{
	}

	private static void SetupPerCameraShaderConstants(CommandBuffer cmd)
	{
	}

	private static void CheckAndApplyDebugSettings(ref RenderingData renderingData)
	{
	}

	private static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection)
	{
		return default(ImageUpscalingFilter);
	}

	internal static bool HDROutputForMainDisplayIsActive()
	{
		return false;
	}

	internal static bool HDROutputForAnyDisplayIsActive()
	{
		return false;
	}

	private void SetHDRState(List<Camera> cameras)
	{
	}

	internal static void GetHDROutputLuminanceParameters(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Tonemapping tonemapping, out Vector4 hdrOutputParameters)
	{
		hdrOutputParameters = default(Vector4);
	}

	internal static void GetHDROutputGradingParameters(Tonemapping tonemapping, out Vector4 hdrOutputParameters)
	{
		hdrOutputParameters = default(Vector4);
	}

	public static bool IsGameCamera(Camera camera)
	{
		return false;
	}

	[Obsolete("Please use CameraData.xr.enabled instead.", true)]
	public static bool IsStereoEnabled(Camera camera)
	{
		return false;
	}

	private void SortCameras(List<Camera> cameras)
	{
	}

	internal static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha)
	{
		return default(GraphicsFormat);
	}

	internal static GraphicsFormat MakeUnormRenderTextureGraphicsFormat()
	{
		return default(GraphicsFormat);
	}

	internal static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, ref CameraData cameraData, bool isHdrEnabled, HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture)
	{
		return default(RenderTextureDescriptor);
	}

	public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, float? innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
	{
		lightAttenuation = default(Vector4);
		lightSpotDir = default(Vector4);
	}

	internal static void GetPunctualLightDistanceAttenuation(float lightRange, ref Vector4 lightAttenuation)
	{
	}

	internal static void GetSpotAngleAttenuation(float spotAngle, float? innerSpotAngle, ref Vector4 lightAttenuation)
	{
	}

	internal static void GetSpotDirection(ref Matrix4x4 lightLocalToWorldMatrix, out Vector4 lightSpotDir)
	{
		lightSpotDir = default(Vector4);
	}

	public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel)
	{
		lightPos = default(Vector4);
		lightColor = default(Vector4);
		lightAttenuation = default(Vector4);
		lightSpotDir = default(Vector4);
		lightOcclusionProbeChannel = default(Vector4);
	}

	private static void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private static void RecordAndExecuteRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
